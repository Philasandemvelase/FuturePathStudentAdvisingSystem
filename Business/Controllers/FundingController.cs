using System;
using System.Collections.Generic;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;
using FuturePathStudentAdvisingSystem.DAL;

namespace FuturePathStudentAdvisingSystem.Business.Controllers
{
    /// <summary>
    /// Use cases: View funding options (learner) and Maintain funding options (administrator).
    /// A funding option is linked to faculties (FundingFaculty) and optionally to specific
    /// programmes (FundingProgramme).
    /// </summary>
    public class FundingController
    {
        private FundingOptionDAL fundingDal = new FundingOptionDAL();
        private FundingFacultyDAL fundingFacultyDal = new FundingFacultyDAL();
        private FundingProgrammeDAL fundingProgrammeDal = new FundingProgrammeDAL();
        private LookupController lookup = new LookupController();

        /// <summary>Every funding option with its links, sorted by name (administrator list).</summary>
        public List<FundingListItem> GetAll()
        {
            List<FundingListItem> items = Build(fundingDal.GetAll());
            items.Sort(CompareByName);
            return items;
        }

        private static int CompareByName(FundingListItem a, FundingListItem b)
        {
            return string.Compare(a.Funding.FundingName, b.Funding.FundingName, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Learner search: only active options that have not closed, filtered by
        /// faculty (0 = any), programme (0 = any) and type (null = any).
        /// An option matches a programme if it is linked to that programme, or has no
        /// programme links and is linked to the programme's faculty.
        /// </summary>
        public List<FundingListItem> Search(int facultyID, int degreeID, string fundingType)
        {
            DegreeProgramme degree = null;
            if (degreeID > 0)
            {
                degree = lookup.GetProgramme(degreeID);
            }

            // GetActive() returns options sorted by closing date. Options without a
            // closing date are put at the end of the list.
            List<FundingListItem> withDate = new List<FundingListItem>();
            List<FundingListItem> withoutDate = new List<FundingListItem>();

            foreach (FundingListItem item in Build(fundingDal.GetActive()))
            {
                if (fundingType != null && item.Funding.FundingType != fundingType)
                {
                    continue;   // wrong type
                }
                if (facultyID > 0 && item.FacultyIDs.Contains(facultyID) == false)
                {
                    continue;   // not for this faculty
                }
                if (degree != null)
                {
                    bool linkedToProgramme = item.DegreeIDs.Contains(degree.DegreeID);
                    bool linkedToFacultyOnly = item.DegreeIDs.Count == 0 && item.FacultyIDs.Contains(degree.FacultyID);
                    if (linkedToProgramme == false && linkedToFacultyOnly == false)
                    {
                        continue;   // not for this programme
                    }
                }

                if (item.Funding.ClosingDate.HasValue)
                {
                    withDate.Add(item);
                }
                else
                {
                    withoutDate.Add(item);
                }
            }

            List<FundingListItem> result = new List<FundingListItem>();
            result.AddRange(withDate);
            result.AddRange(withoutDate);
            return result;
        }

        public FundingListItem GetByID(int fundingID)
        {
            FundingOption option = fundingDal.GetByID(fundingID);
            if (option == null)
            {
                return null;
            }
            List<FundingOption> one = new List<FundingOption>();
            one.Add(option);
            return Build(one)[0];
        }

        /// <summary>
        /// Adds (FundingID = 0) or updates a funding option and replaces its faculty and programme links.
        /// </summary>
        public void Save(FundingOption funding, List<int> facultyIDs, List<int> degreeIDs)
        {
            Validate(funding, facultyIDs);

            if (funding.FundingID == 0)
            {
                fundingDal.Add(funding);   // fills in funding.FundingID
            }
            else if (fundingDal.Update(funding) == false)
            {
                throw new BusinessRuleException("This funding option no longer exists.");
            }

            // ---- FundingFaculty: delete links that were unticked, add new ones ----
            List<FundingFaculty> oldFacultyLinks = fundingFacultyDal.GetByFunding(funding.FundingID);
            List<int> keptFaculties = new List<int>();
            foreach (FundingFaculty link in oldFacultyLinks)
            {
                if (facultyIDs.Contains(link.FacultyID))
                {
                    keptFaculties.Add(link.FacultyID);
                }
                else
                {
                    fundingFacultyDal.Delete(link.FundingFacultyID);
                }
            }
            foreach (int id in facultyIDs)
            {
                if (keptFaculties.Contains(id) == false)
                {
                    FundingFaculty link = new FundingFaculty();
                    link.FundingID = funding.FundingID;
                    link.FacultyID = id;
                    fundingFacultyDal.Add(link);
                }
            }

            // ---- FundingProgramme: the same for programme links ----
            List<int> keptProgrammes = new List<int>();
            foreach (FundingProgramme link in fundingProgrammeDal.GetAll())
            {
                if (link.FundingID != funding.FundingID)
                {
                    continue;
                }
                if (degreeIDs.Contains(link.DegreeID))
                {
                    keptProgrammes.Add(link.DegreeID);
                }
                else
                {
                    fundingProgrammeDal.Delete(link.FundingProgrammeID);
                }
            }
            foreach (int id in degreeIDs)
            {
                if (keptProgrammes.Contains(id) == false)
                {
                    FundingProgramme link = new FundingProgramme();
                    link.FundingID = funding.FundingID;
                    link.DegreeID = id;
                    fundingProgrammeDal.Add(link);
                }
            }
        }

        /// <summary>Hides the option from learners. Records are kept for history.</summary>
        public void Deactivate(int fundingID)
        {
            FundingOption option = fundingDal.GetByID(fundingID);
            if (option == null)
            {
                throw new BusinessRuleException("Select a funding option first.");
            }
            option.IsActive = false;
            fundingDal.Update(option);
        }

        private void Validate(FundingOption f, List<int> facultyIDs)
        {
            if (f.FundingName == null || f.FundingName.Trim() == "")
            {
                throw new BusinessRuleException("Funding name is required.");
            }
            if (f.FundingName.Length > 100)
            {
                throw new BusinessRuleException("Funding name can be at most 100 characters.");
            }
            if (Array.IndexOf(LookupController.FundingTypeList, f.FundingType) < 0)
            {
                throw new BusinessRuleException("Select a funding type.");
            }
            if (f.EligibilityDescription == null || f.EligibilityDescription.Trim() == "")
            {
                throw new BusinessRuleException("Describe who is eligible.");
            }
            if (f.IsActive && f.ClosingDate.HasValue && f.ClosingDate.Value.Date < DateTime.Today)
            {
                throw new BusinessRuleException("An active funding option cannot have a closing date in the past.");
            }
            if (facultyIDs == null || facultyIDs.Count == 0)
            {
                throw new BusinessRuleException("Link the funding option to at least one faculty.");
            }

            // No two funding options may have the same name.
            foreach (FundingOption other in fundingDal.GetAll())
            {
                if (other.FundingID != f.FundingID &&
                    other.FundingName.Trim().ToLower() == f.FundingName.Trim().ToLower())
                {
                    throw new BusinessRuleException("Another funding option already has this name.");
                }
            }
        }

        /// <summary>Adds the linked faculty and programme IDs (and their names) to each option.</summary>
        private List<FundingListItem> Build(List<FundingOption> options)
        {
            List<FundingFaculty> facultyLinks = fundingFacultyDal.GetAll();
            List<FundingProgramme> programmeLinks = fundingProgrammeDal.GetAll();
            Dictionary<int, string> facultyNames = lookup.FacultyNames();
            Dictionary<int, string> programmeNames = lookup.ProgrammeNames();

            List<FundingListItem> items = new List<FundingListItem>();
            foreach (FundingOption option in options)
            {
                FundingListItem item = new FundingListItem();
                item.Funding = option;

                foreach (FundingFaculty link in facultyLinks)
                {
                    if (link.FundingID == option.FundingID)
                    {
                        item.FacultyIDs.Add(link.FacultyID);
                    }
                }
                foreach (FundingProgramme link in programmeLinks)
                {
                    if (link.FundingID == option.FundingID)
                    {
                        item.DegreeIDs.Add(link.DegreeID);
                    }
                }

                // "Linked to" shows the programmes if there are any, otherwise the faculties.
                string linkedTo = "";
                if (item.DegreeIDs.Count > 0)
                {
                    foreach (int id in item.DegreeIDs)
                    {
                        linkedTo = AddName(linkedTo, LookupController.NameOf(programmeNames, id));
                    }
                }
                else
                {
                    foreach (int id in item.FacultyIDs)
                    {
                        linkedTo = AddName(linkedTo, LookupController.NameOf(facultyNames, id));
                    }
                }
                item.LinkedTo = linkedTo;
                items.Add(item);
            }
            return items;
        }

        private static string AddName(string list, string name)
        {
            if (name == "")
            {
                return list;
            }
            if (list == "")
            {
                return name;
            }
            return list + ", " + name;
        }
    }
}
