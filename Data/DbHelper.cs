using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FuturePathStudentAdvisingSystem.Data
{
    /// <summary>
    /// Shared plumbing for every DAL class so each one only contains its SQL and mapping.
    /// Each call opens its own connection and closes it again (using blocks).
    ///
    /// Errors are NOT swallowed: a SqlException (e.g. number 547 = foreign key / check
    /// constraint, 2627 = duplicate unique value) reaches the form, which should catch it
    /// and show a message. Returning false on every error hides real bugs.
    /// </summary>
    public static class DbHelper
    {
        /// <summary>Runs a SELECT and maps every row with <paramref name="map"/>.</summary>
        public static List<T> Query<T>(string sql, Func<IDataRecord, T> map, Action<SqlCommand> addParameters = null)
        {
            var results = new List<T>();
            using (SqlConnection conn = DbConnectionFactory.CreateOpenConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (addParameters != null) addParameters(cmd);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        results.Add(map(reader));
                }
            }
            return results;
        }

        /// <summary>Runs a SELECT expected to return at most one row; null if none.</summary>
        public static T QuerySingle<T>(string sql, Func<IDataRecord, T> map, Action<SqlCommand> addParameters = null) where T : class
        {
            List<T> rows = Query(sql, map, addParameters);
            return rows.Count > 0 ? rows[0] : null;
        }

        /// <summary>Runs INSERT/UPDATE/DELETE and returns the number of rows affected.</summary>
        public static int Execute(string sql, Action<SqlCommand> addParameters = null)
        {
            using (SqlConnection conn = DbConnectionFactory.CreateOpenConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (addParameters != null) addParameters(cmd);
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>Runs an INSERT ... OUTPUT INSERTED.id and returns the new ID.</summary>
        public static int InsertAndGetId(string sql, Action<SqlCommand> addParameters)
        {
            using (SqlConnection conn = DbConnectionFactory.CreateOpenConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                addParameters(cmd);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
