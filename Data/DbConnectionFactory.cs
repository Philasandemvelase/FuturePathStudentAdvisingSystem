using System;
using System.Configuration;
using System.Data.SqlClient;

namespace FuturePathStudentAdvisingSystem.Data
{
    /// <summary>
    /// The ONE place the app gets database connections from.
    /// Every DAO should do:
    ///     using (SqlConnection conn = DbConnectionFactory.CreateOpenConnection())
    ///     using (SqlCommand cmd = new SqlCommand(sql, conn)) { ... }
    /// The connection string lives in App.config under the name "FuturePathDB".
    /// </summary>
    public static class DbConnectionFactory
    {
        public const string ConnectionName = "FuturePathDB";

        private static readonly Lazy<string> _connectionString = new Lazy<string>(() =>
        {
            ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings[ConnectionName];
            if (setting == null || string.IsNullOrWhiteSpace(setting.ConnectionString))
            {
                throw new ConfigurationErrorsException(
                    "Connection string '" + ConnectionName + "' is missing from App.config.");
            }
            return setting.ConnectionString;
        });

        public static string ConnectionString
        {
            get { return _connectionString.Value; }
        }

        /// <summary>Returns an OPEN connection. Always wrap it in a using block.</summary>
        public static SqlConnection CreateOpenConnection()
        {
            var conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch
            {
                conn.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Opens a connection and counts the tables. Used at start-up so a missing
        /// database shows a clear message instead of a crash deep inside a form.
        /// </summary>
        public static bool TryTestConnection(out string message)
        {
            const string sql =
                "SELECT DB_NAME(), " +
                "(SELECT COUNT(*) FROM sys.tables WHERE is_ms_shipped = 0), " +
                "(SELECT COUNT(*) FROM dbo.Learner);";
            try
            {
                using (SqlConnection conn = CreateOpenConnection())
                using (var cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    message = string.Format("Connected to {0}: {1} tables, {2} learners.",
                        reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2));
                    return true;
                }
            }
            catch (SqlException ex)
            {
                message = DescribeSqlError(ex);
                return false;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        private static string DescribeSqlError(SqlException ex)
        {
            switch (ex.Number)
            {
                case 4060: // cannot open database
                    return "The FuturePathDB database does not exist yet.\n" +
                           "Run Database\\01_CreateDatabase.sql, 02_CreateTables.sql and 03_SeedData.sql.\n\n" + ex.Message;
                case 208:  // invalid object name
                    return "FuturePathDB exists but its tables are missing.\n" +
                           "Run Database\\02_CreateTables.sql then 03_SeedData.sql.\n\n" + ex.Message;
                case -1:
                case 2:
                case 53:
                case -1983577832:
                    return "Could not reach SQL Server LocalDB at (localdb)\\MSSQLLocalDB.\n" +
                           "Check LocalDB is installed (Visual Studio Installer > Data storage and processing),\n" +
                           "or run 'sqllocaldb start MSSQLLocalDB' in a command prompt.\n\n" + ex.Message;
                default:
                    return "SQL error " + ex.Number + ": " + ex.Message;
            }
        }
    }
}
