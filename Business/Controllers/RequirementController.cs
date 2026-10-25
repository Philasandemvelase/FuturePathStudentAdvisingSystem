using System.Collections.Generic;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;
using FuturePathStudentAdvisingSystem.DAL;

namespace FuturePathStudentAdvisingSystem.Business.Controllers
{
    /// <summary>
    /// Use case (Administrator): Maintain programme requirements, i.e. the eligibility
    /// rules that RecommendationController applies.
    /// </summary>
    public class RequirementController
    {
        private ProgrammeRequirementDAL requirementDal = new ProgrammeRequirementDAL();
        private LookupController lookup = new LookupController();

        /// <summary>The rules of one programme with readable subject names.</summary>
        public List<RequirementListItem> GetRequirements(int degreeID)
        {
            Dictionary<int, string> names = lookup.SubjectNames();
            List<RequirementListItem> items = new List<RequirementListItem>();
            foreach (ProgrammeRequirement rule in requirementDal.GetByDegree(degreeID))
            {
                RequirementListItem item = new RequirementListItem();
                item.Requirement = rule;
                item.SubjectName = LookupController.NameOf(names, rule.SubjectID);
                if (rule.AcceptedAlternativeSubjectID.HasValue)
                {
                    item.AlternativeName = LookupController.NameOf(names, rule.AcceptedAlternativeSubjectID.Value);
                }
                else
                {
                    item.AlternativeName = "None";
                }
                items.Add(item);
            }
            return items;
        }

        /// <summary>Adds (RequirementID = 0) or updates a rule.</summary>
        public void SaveRequirement(ProgrammeRequirement requirement)
        {
            if (requirement.DegreeID <= 0)
            {
                throw new BusinessRuleException("Select a programme.");
            }
            if (requirement.SubjectID <= 0)
            {
                throw new BusinessRuleException("Select the required subject.");
            }
            if (requirement.MinimumMark < 0 || requirement.MinimumMark > 100)
            {
                throw new BusinessRuleException("The minimum mark must be between 0 and 100.");
            }
            if (requirement.AcceptedAlternativeSubjectID.HasValue &&
                requirement.AcceptedAlternativeSubjectID.Value == requirement.SubjectID)
            {
                throw new BusinessRuleException("The accepted alternative must be a different subject.");
            }
            if (requirement.Notes != null && requirement.Notes.Length > 255)
            {
                throw new BusinessRuleException("Notes can be at most 255 characters.");
            }

            // One rule per subject per programme.
            foreach (ProgrammeRequirement other in requirementDal.GetByDegree(requirement.DegreeID))
            {
                if (other.SubjectID == requirement.SubjectID && other.RequirementID != requirement.RequirementID)
                {
                    throw new BusinessRuleException("This programme already has a rule for that subject. Use Edit to change it.");
                }
            }

            if (requirement.RequirementType == null || requirement.RequirementType == "")
            {
                requirement.RequirementType = "Subject";
            }

            if (requirement.RequirementID == 0)
            {
                requirementDal.Add(requirement);
            }
            else if (requirementDal.Update(requirement) == false)
            {
                throw new BusinessRuleException("This rule no longer exists.");
            }
        }

        public void DeleteRequirement(int requirementID)
        {
            requirementDal.Delete(requirementID);
        }
    }
}
