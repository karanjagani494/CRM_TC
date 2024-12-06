using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SoftwareEngineering_2024.DB_connect
{

    public class db_connect
    {
        private MySqlConnection connection;

        // Constructor
        public db_connect()
        {
            InitializeConnection();
        }

        // Initialize database connection
        private void InitializeConnection()
        {
            string connectionString = "server=localhost;port=3307;database=final_crm;user=root;password=;";

            connection = new MySqlConnection(connectionString);
        }

        // Open the connection
        public bool OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle connection errors
                Console.WriteLine("MySQL Connection Error: " + ex.Message);
                return false;
            }
        }

        // Close the connection
        public bool CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle disconnection errors
                Console.WriteLine("MySQL Disconnection Error: " + ex.Message);
                return false;
            }
        }

        // Test the connection by running a simple query
        public bool TestConnection()
        {
            try
            {
                if (OpenConnection())
                {
                    Console.WriteLine("Database connection is successful.");
                    CloseConnection();
                    return true;
                }
                else
                {
                    Console.WriteLine("Failed to connect to the database.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database connection error: " + ex.Message);
                return false;
            }
        }


        // Get the connection instance
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }

}


