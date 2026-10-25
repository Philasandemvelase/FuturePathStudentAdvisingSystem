using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>A login account for an administrator or career advisor. Table: dbo.UserAccount</summary>
    public class UserAccount
    {
        public int    UserID { get; set; }  // userID - PK
        public string Username { get; set; } = string.Empty;  // username
        public string PasswordHash { get; set; } = string.Empty;  // passwordHash - SHA-256 hex (64 chars). Use PasswordHasher, never store plain text.
        public string Role { get; set; } = string.Empty;  // role - See Roles constants.
        public bool   IsActive { get; set; } = true;  // isActive
    }
}
