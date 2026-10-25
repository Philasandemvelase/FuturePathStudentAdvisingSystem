using System;

namespace FuturePathStudentAdvisingSystem.Business
{
    /// <summary>
    /// Thrown by a controller when user input breaks a business rule
    /// (e.g. "Select your grade", "Mark must be between 0 and 100").
    /// The message is written for the user, so forms can show it as-is:
    ///     catch (BusinessRuleException ex) { MessageBox.Show(ex.Message); }
    /// Database errors (SqlException) are a different, technical kind of error.
    /// </summary>
    public class BusinessRuleException : Exception
    {
        public BusinessRuleException(string message) : base(message) { }
    }
}
