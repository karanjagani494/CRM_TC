using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SoftwareEngineering_2024
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
                string connectionString = "server=127.0.0.1:3306;user=root;password=Shau@410;database=test;";
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

            // Get the connection instance
            public MySqlConnection GetConnection()
            {
                return connection;
            }
        }
    }


