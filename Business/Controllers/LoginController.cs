using System.Collections.Generic;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.DAL;

namespace FuturePathStudentAdvisingSystem.Business.Controllers
{
    /// <summary>
    /// Use case: Authenticate staff (Career Advisor / System Administrator).
    /// Learners do not log in; they start an advisory session from the Welcome screen.
    /// </summary>
    public class LoginController
    {
        private UserAccountDAL userDal = new UserAccountDAL();

        /// <summary>
        /// Returns the signed-in account. If the details are missing, wrong or the account
        /// is inactive, it throws a BusinessRuleException with a message for the user.
        /// </summary>
        public UserAccount Login(string username, string password)
        {
            if (username == null || username.Trim() == "" || password == null || password == "")
            {
                throw new BusinessRuleException("Enter both your username and password.");
            }

            // The DAL hashes the password and only accepts active accounts.
            UserAccount user = userDal.Login(username, password);
            if (user != null)
            {
                return user;
            }

            // Login() returns null for a wrong password AND for an inactive account,
            // so look the username up to tell the user which one it is.
            List<UserAccount> allUsers = userDal.GetAll();
            foreach (UserAccount account in allUsers)
            {
                if (account.Username.ToLower() == username.Trim().ToLower() && account.IsActive == false)
                {
                    throw new BusinessRuleException("This account is inactive. Contact the system administrator.");
                }
            }
            throw new BusinessRuleException("Username or password is incorrect. Please try again.");
        }

        public static bool IsAdministrator(UserAccount user)
        {
            return user != null && user.Role == Roles.Administrator;
        }

        public static bool IsCareerAdvisor(UserAccount user)
        {
            return user != null && user.Role == Roles.CareerAdvisor;
        }
    }
}
