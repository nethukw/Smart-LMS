using MySql.Data.MySqlClient;

namespace SmartLMS
{
    public static class DBHelper
    {
        private static string connectionString = "server=localhost;user=root;database=SmartLMS;password=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
