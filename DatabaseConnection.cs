using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CollegeManagement
{
    internal class DatabaseConnection
    {
        private MySqlConnection connection;

        public DatabaseConnection()
        {
            string connectionString = "Server=127.0.0.1;Database=collegedb;Uid=root;";
            connection = new MySqlConnection(connectionString);

        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
