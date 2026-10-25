using System.Collections.Generic;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.DAL;

namespace FuturePathStudentAdvisingSystem.Business.Controllers
{
    /// <summary>
    /// Read-only reference data for drop-down lists (grades, provinces, faculties,
    /// programmes, subjects, categories, funding types), plus id-to-name look-ups
    /// that the other controllers use.
    /// </summary>
    public class LookupController
    {
        private GradeLevelDAL gradeDal = new GradeLevelDAL();
        private FacultyDAL facultyDal = new FacultyDAL();
        private DegreeProgrammeDAL degreeDal = new DegreeProgrammeDAL();
        private SubjectDAL subjectDal = new SubjectDAL();
        private InterestQuestionCategoryDAL categoryDal = new InterestQuestionCategoryDAL();

        public static string[] Provinces =
        {
            "Eastern Cape", "Free State", "Gauteng", "KwaZulu-Natal", "Limpopo",
            "Mpumalanga", "North West", "Northern Cape", "Western Cape"
        };

        public static string[] FundingTypeList =
        {
            FundingTypes.Scholarship, FundingTypes.Bursary, FundingTypes.FinancialAid, FundingTypes.ExternalFunding
        };

        public List<GradeLevel> GetGradeLevels()
        {
            return gradeDal.GetAll();
        }

        public List<Faculty> GetFaculties()
        {
            return facultyDal.GetAll();
        }

        public List<Subject> GetSubjects()
        {
            return subjectDal.GetAll();
        }

        public List<InterestQuestionCategory> GetCategories()
        {
            return categoryDal.GetAll();
        }

        public List<DegreeProgramme> GetAllProgrammes()
        {
            return degreeDal.GetAll();
        }

        /// <summary>Active programmes of one faculty. facultyID 0 means all faculties.</summary>
        public List<DegreeProgramme> GetActiveProgrammes(int facultyID)
        {
            List<DegreeProgramme> result = new List<DegreeProgramme>();
            foreach (DegreeProgramme programme in degreeDal.GetActive())
            {
                if (facultyID == 0 || programme.FacultyID == facultyID)
                {
                    result.Add(programme);
                }
            }
            return result;
        }

        public DegreeProgramme GetProgramme(int degreeID)
        {
            return degreeDal.GetByID(degreeID);
        }

        /// <summary>Names of the interest categories that count for a programme (strongest first).</summary>
        public List<string> InterestCategoriesFor(int degreeID)
        {
            Dictionary<int, string> names = CategoryNames();
            List<string> result = new List<string>();
            foreach (DegreeInterestMap map in new DegreeInterestMapDAL().GetByDegree(degreeID))
            {
                result.Add(NameOf(names, map.CategoryID));
            }
            return result;
        }

        // ---------- id -> name look-ups (one database query each) ----------

        public Dictionary<int, string> SubjectNames()
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            foreach (Subject s in subjectDal.GetAll())
            {
                names[s.SubjectID] = s.SubjectName;
            }
            return names;
        }

        public Dictionary<int, string> FacultyNames()
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            foreach (Faculty f in facultyDal.GetAll())
            {
                names[f.FacultyID] = f.FacultyName;
            }
            return names;
        }

        public Dictionary<int, string> ProgrammeNames()
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            foreach (DegreeProgramme d in degreeDal.GetAll())
            {
                names[d.DegreeID] = d.DegreeName;
            }
            return names;
        }

        public Dictionary<int, string> CategoryNames()
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            foreach (InterestQuestionCategory c in categoryDal.GetAll())
            {
                names[c.CategoryID] = c.CategoryName;
            }
            return names;
        }

        public Dictionary<int, string> GradeNames()
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            foreach (GradeLevel g in gradeDal.GetAll())
            {
                names[g.GradeLevelID] = g.GradeName;
            }
            return names;
        }

        /// <summary>Finds a name in a look-up; returns "" if the id is not there.</summary>
        public static string NameOf(Dictionary<int, string> names, int id)
        {
            if (names.ContainsKey(id))
            {
                return names[id];
            }
            return "";
        }
    }
}
