using System;
using System.Data;
using System.Data.SqlClient;

namespace FuturePathStudentAdvisingSystem.Data
{
    /// <summary>
    /// Null-safe helpers so DAOs don't repeat DBNull checks.
    ///   Reading:  learner.SchoolName = reader.ReadString("schoolName");
    ///   Writing:  cmd.AddParameter("@schoolName", learner.SchoolName);   // null -> DBNull
    /// </summary>
    public static class DataExtensions
    {
        // ---------- reading (by column name) ----------

        public static int ReadInt(this IDataRecord r, string column)
        {
            return Convert.ToInt32(r[column]);      // works for INT, SMALLINT, TINYINT
        }

        public static int? ReadNullableInt(this IDataRecord r, string column)
        {
            object v = r[column];
            return v == DBNull.Value ? (int?)null : Convert.ToInt32(v);
        }

        public static decimal ReadDecimal(this IDataRecord r, string column)
        {
            return Convert.ToDecimal(r[column]);
        }

        public static decimal? ReadNullableDecimal(this IDataRecord r, string column)
        {
            object v = r[column];
            return v == DBNull.Value ? (decimal?)null : Convert.ToDecimal(v);
        }

        /// <summary>Returns null for SQL NULL.</summary>
        public static string ReadString(this IDataRecord r, string column)
        {
            object v = r[column];
            return v == DBNull.Value ? null : Convert.ToString(v);
        }

        /// <summary>Returns "" for SQL NULL (handy for TextBoxes).</summary>
        public static string ReadStringOrEmpty(this IDataRecord r, string column)
        {
            return ReadString(r, column) ?? string.Empty;
        }

        public static bool ReadBool(this IDataRecord r, string column)
        {
            return Convert.ToBoolean(r[column]);
        }

        public static DateTime ReadDateTime(this IDataRecord r, string column)
        {
            return Convert.ToDateTime(r[column]);
        }

        public static DateTime? ReadNullableDateTime(this IDataRecord r, string column)
        {
            object v = r[column];
            return v == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(v);
        }

        // ---------- writing ----------

        /// <summary>Adds a parameter, converting C# null to SQL NULL.</summary>
        public static SqlParameter AddParameter(this SqlCommand cmd, string name, object value)
        {
            return cmd.Parameters.AddWithValue(name, value ?? DBNull.Value);
        }
    }
}
