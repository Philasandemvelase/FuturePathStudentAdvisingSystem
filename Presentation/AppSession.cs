using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Entities;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    public enum UserRole
    {
        Guest,
        Learner,
        CareerAdvisor,
        Administrator
    }

    /// <summary>
    /// What the open screens share: who is signed in, and the advisory session in progress.
    /// Child forms open and close freely, so this state lives here, not in a form.
    /// All business logic is in the controllers (Business\Controllers).
    /// </summary>
    internal static class AppSession
    {
        public static UserRole Role = UserRole.Guest;

        /// <summary>The signed-in staff account (null for guests and learners).</summary>
        public static UserAccount CurrentUser;

        /// <summary>The learner journey in progress (one controller per advisory session).</summary>
        public static AdvisorySessionController Advisory = new AdvisorySessionController();

        /// <summary>A saved session a Career Advisor is viewing (0 = the live session).</summary>
        public static int ViewedSessionID = 0;

        /// <summary>The signed-in username, or "" when nobody is signed in.</summary>
        public static string Username
        {
            get
            {
                if (CurrentUser == null)
                {
                    return "";
                }
                return CurrentUser.Username;
            }
        }

        public static void StartNewAdvisory()
        {
            Advisory = new AdvisorySessionController();
            ViewedSessionID = 0;
        }

        public static UserRole RoleOf(UserAccount user)
        {
            if (LoginController.IsAdministrator(user))
            {
                return UserRole.Administrator;
            }
            if (LoginController.IsCareerAdvisor(user))
            {
                return UserRole.CareerAdvisor;
            }
            return UserRole.Guest;
        }

        public static string RoleDisplayName(UserRole role)
        {
            if (role == UserRole.Learner)
            {
                return "Learner";
            }
            if (role == UserRole.CareerAdvisor)
            {
                return Roles.CareerAdvisor;
            }
            if (role == UserRole.Administrator)
            {
                return Roles.Administrator;
            }
            return "Guest";
        }
    }
}
