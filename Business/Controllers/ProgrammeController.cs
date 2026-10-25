using System;
using System.Collections.Generic;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;
using FuturePathStudentAdvisingSystem.DAL;

namespace FuturePathStudentAdvisingSystem.Business.Controllers
{
    /// <summary>
    /// Use case (Administrator): Maintain faculties and degree programmes.
    /// Programmes are deactivated, never deleted, so saved sessions keep their history.
    /// </summary>
    public class ProgrammeController
    {
        private DegreeProgrammeDAL degreeDal = new DegreeProgrammeDAL();
        private FacultyDAL facultyDal = new FacultyDAL();

        /// <summary>All programmes (active and inactive) with their faculty names, sorted by name.</summary>
        public List<ProgrammeListItem> GetProgrammes()
        {
            Dictionary<int, string> facultyNames = new LookupController().FacultyNames();
            List<ProgrammeListItem> items = new List<ProgrammeListItem>();
            foreach (DegreeProgramme d in degreeDal.GetAll())
            {
                ProgrammeListItem item = new ProgrammeListItem();
                item.Programme = d;
                item.FacultyName = LookupController.NameOf(facultyNames, d.FacultyID);
                items.Add(item);
            }
            items.Sort(CompareProgrammes);
            return items;
        }

        private static int CompareProgrammes(ProgrammeListItem a, ProgrammeListItem b)
        {
            return string.Compare(a.Programme.DegreeName, b.Programme.DegreeName, StringComparison.OrdinalIgnoreCase);
        }

        public DegreeProgramme GetProgramme(int degreeID)
        {
            return degreeDal.GetByID(degreeID);
        }

        /// <summary>All faculties sorted by name.</summary>
        public List<Faculty> GetFaculties()
        {
            List<Faculty> faculties = facultyDal.GetAll();
            faculties.Sort(CompareFaculties);
            return faculties;
        }

        private static int CompareFaculties(Faculty a, Faculty b)
        {
            return string.Compare(a.FacultyName, b.FacultyName, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>Adds (DegreeID = 0) or updates a programme.</summary>
        public void SaveProgramme(DegreeProgramme programme)
        {
            if (programme.DegreeName == null)
            {
                programme.DegreeName = "";
            }
            programme.DegreeName = programme.DegreeName.Trim();

            if (programme.DegreeName == "")
            {
                throw new BusinessRuleException("Programme name is required.");
            }
            if (programme.DegreeName.Length > 100)
            {
                throw new BusinessRuleException("Programme name can be at most 100 characters.");
            }
            if (programme.FacultyID <= 0)
            {
                throw new BusinessRuleException("Select the faculty that offers this programme.");
            }
            if (programme.Description != null && programme.Description.Length > 500)
            {
                throw new BusinessRuleException("Description can be at most 500 characters.");
            }

            // No two programmes may have the same name.
            foreach (DegreeProgramme other in degreeDal.GetAll())
            {
                if (other.DegreeID != programme.DegreeID && other.DegreeName.ToLower() == programme.DegreeName.ToLower())
                {
                    throw new BusinessRuleException("A programme with this name already exists.");
                }
            }

            if (programme.DegreeID == 0)
            {
                degreeDal.Add(programme);
            }
            else if (degreeDal.Update(programme) == false)
            {
                throw new BusinessRuleException("This programme no longer exists.");
            }
        }

        public void DeactivateProgramme(int degreeID)
        {
            DegreeProgramme programme = degreeDal.GetByID(degreeID);
            if (programme == null)
            {
                throw new BusinessRuleException("Select a programme first.");
            }
            programme.IsActive = false;
            degreeDal.Update(programme);
        }

        /// <summary>Adds (FacultyID = 0) or renames a faculty.</summary>
        public void SaveFaculty(Faculty faculty)
        {
            if (faculty.FacultyName == null)
            {
                faculty.FacultyName = "";
            }
            faculty.FacultyName = faculty.FacultyName.Trim();

            if (faculty.FacultyName == "")
            {
                throw new BusinessRuleException("Faculty name is required.");
            }
            if (faculty.FacultyName.Length > 50)
            {
                throw new BusinessRuleException("Faculty name can be at most 50 characters.");
            }
            foreach (Faculty other in facultyDal.GetAll())
            {
                if (other.FacultyID != faculty.FacultyID && other.FacultyName.ToLower() == faculty.FacultyName.ToLower())
                {
                    throw new BusinessRuleException("A faculty with this name already exists.");
                }
            }

            if (faculty.FacultyID == 0)
            {
                facultyDal.Add(faculty);
            }
            else if (facultyDal.Update(faculty) == false)
            {
                throw new BusinessRuleException("This faculty no longer exists.");
            }
        }
    }
}
