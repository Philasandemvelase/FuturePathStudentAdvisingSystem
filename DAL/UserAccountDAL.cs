using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>
    /// Login accounts. Table: dbo.UserAccount
    /// Passwords are never stored or compared as plain text: they are hashed with
    /// PasswordHasher (SHA-256), the same way 03_SeedData.sql hashes them.
    /// </summary>
    public class UserAccountDAL
    {
        private const string SelectSql =
            "SELECT userID, username, passwordHash, role, isActive " +
            "FROM dbo.UserAccount";

        /// <summary>
        /// Returns the account if the username exists, is active and the password matches;
        /// otherwise null. Pass the password exactly as the user typed it.
        /// </summary>
        public UserAccount Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
                return null;

            UserAccount user = DbHelper.QuerySingle<UserAccount>(
                SelectSql + " WHERE username = @username AND isActive = 1;", Map,
                cmd => cmd.AddParameter("@username", username.Trim()));

            if (user == null || !PasswordHasher.Verify(password, user.PasswordHash))
                return null;

            return user;
        }

        /// <summary>
        /// Creates an account. The plain password is hashed here, so callers never handle hashes.
        /// The new ID is copied into user.UserID. Throws SqlException 2627 if the username is taken.
        /// </summary>
        public bool Add(UserAccount user, string password)
        {
            const string sql =
                "INSERT INTO dbo.UserAccount (username, passwordHash, role, isActive) " +
                "OUTPUT INSERTED.userID " +
                "VALUES (@username, @passwordHash, @role, @isActive);";

            user.PasswordHash = PasswordHasher.Hash(password);
            user.UserID = DbHelper.InsertAndGetId(sql, cmd =>
            {
                cmd.AddParameter("@username", user.Username);
                cmd.AddParameter("@passwordHash", user.PasswordHash);
                cmd.AddParameter("@role", user.Role);
                cmd.AddParameter("@isActive", user.IsActive);
            });
            return user.UserID > 0;
        }

        /// <summary>Updates username, role and active flag. Does NOT change the password (use ChangePassword).</summary>
        public bool Update(UserAccount user)
        {
            const string sql =
                "UPDATE dbo.UserAccount " +
                "SET username = @username, role = @role, isActive = @isActive " +
                "WHERE userID = @userID;";

            return DbHelper.Execute(sql, cmd =>
            {
                cmd.AddParameter("@username", user.Username);
                cmd.AddParameter("@role", user.Role);
                cmd.AddParameter("@isActive", user.IsActive);
                cmd.AddParameter("@userID", user.UserID);
            }) == 1;
        }

        /// <summary>Sets a new password (plain text in, hash stored).</summary>
        public bool ChangePassword(int userID, string newPassword)
        {
            const string sql = "UPDATE dbo.UserAccount SET passwordHash = @passwordHash WHERE userID = @userID;";
            return DbHelper.Execute(sql, cmd =>
            {
                cmd.AddParameter("@passwordHash", PasswordHasher.Hash(newPassword));
                cmd.AddParameter("@userID", userID);
            }) == 1;
        }

        public bool Delete(int userID)
        {
            const string sql = "DELETE FROM dbo.UserAccount WHERE userID = @userID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@userID", userID)) == 1;
        }

        public UserAccount GetByID(int userID)
        {
            return DbHelper.QuerySingle<UserAccount>(SelectSql + " WHERE userID = @userID;", Map,
                cmd => cmd.AddParameter("@userID", userID));
        }

        public List<UserAccount> GetAll()
        {
            return DbHelper.Query<UserAccount>(SelectSql + " ORDER BY username;", Map);
        }

        private static UserAccount Map(IDataRecord r)
        {
            return new UserAccount
            {
                UserID = r.ReadInt("userID"),
                Username = r.ReadString("username"),
                PasswordHash = r.ReadString("passwordHash"),
                Role = r.ReadString("role"),
                IsActive = r.ReadBool("isActive")
            };
        }
    }
}
