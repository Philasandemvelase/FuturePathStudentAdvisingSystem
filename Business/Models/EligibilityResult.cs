using System.Collections.Generic;
using FuturePathStudentAdvisingSystem.Business.Entities;

namespace FuturePathStudentAdvisingSystem.Business.Models
{
    /// <summary>One line of the "Why this outcome?" table.</summary>
    public class ReasonLine
    {
        public string Check { get; set; }
        public string Result { get; set; }
        public string Explanation { get; set; }
    }

    /// <summary>
    /// The outcome of checking a learner against ONE degree programme.
    /// It holds the RecommendationResult row that gets saved, plus the text the screens show.
    /// </summary>
    public class EligibilityResult
    {
        public DegreeProgramme Degree { get; set; }
        public string FacultyName { get; set; }

        /// <summary>The row stored in dbo.RecommendationResult (scores, outcome, gap).</summary>
        public RecommendationResult Result { get; set; }

        /// <summary>Short banner text, e.g. "Strong Match" or "! Required subjects missing".</summary>
        public string Headline { get; set; }

        /// <summary>One sentence explaining the outcome.</summary>
        public string Detail { get; set; }

        public List<ReasonLine> Reasons { get; set; }

        public EligibilityResult()
        {
            Reasons = new List<ReasonLine>();
        }

        /// <summary>"Strong Match", "Possible Match", "Not Currently Eligible" or "More Information Needed".</summary>
        public string Outcome
        {
            get
            {
                if (Result == null)
                {
                    return "";
                }
                return Result.AdvisoryOutcome;
            }
        }
    }
}
