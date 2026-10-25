using System;
using System.Security.Cryptography;
using System.Text;

namespace FuturePathStudentAdvisingSystem.Business
{
    /// <summary>
    /// Passwords are stored as PLAIN TEXT in UserAccount.passwordHash,
    /// so you can type them straight into the table (View Data) and read them back.
    /// Accounts that still hold an old SHA-256 hash (e.g. from 03_SeedData.sql) also still work.
    /// </summary>
    public static class PasswordHasher
    {
        /// <summary>What gets saved in the database: the password itself (no hashing).</summary>
        public static string Hash(string plainPassword)
        {
            if (plainPassword == null)
            {
                throw new ArgumentNullException("plainPassword");
            }
            return plainPassword;
        }

        /// <summary>True if the typed password matches what is stored. Passwords are case-sensitive.</summary>
        public static bool Verify(string plainPassword, string storedValue)
        {
            if (plainPassword == null || storedValue == null || storedValue.Trim() == "")
            {
                return false;
            }
            string stored = storedValue.Trim();   // the CHAR(64) column pads with spaces

            // 1. Plain-text password (new way)
            if (stored == plainPassword)
            {
                return true;
            }

            // 2. Old SHA-256 hash (accounts created by 03_SeedData.sql)
            if (stored.Length == 64 && string.Equals(Sha256(plainPassword), stored, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }

        /// <summary>SHA-256 as 64 hex characters, only used to recognise the old seeded accounts.</summary>
        private static string Sha256(string text)
        {
            SHA256 sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(text));
            sha.Dispose();
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
