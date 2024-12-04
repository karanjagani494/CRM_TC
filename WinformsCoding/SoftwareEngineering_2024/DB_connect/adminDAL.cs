using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SoftwareEngineering_2024.utilities;
using System.Security.Cryptography;

namespace SoftwareEngineering_2024.DB_connect
{
    public class adminDAL
    {
        private db_connect db = new db_connect();
        private UserContext userContext = new UserContext();
        private int id = UserContext.Memberid;


        /* This will authenticate admin from the database*/

        public bool AuthenticateAdmin(string Email, string Password)
        {
            string hashedPassword = HashPassword(Password); // Hash the input password

            using (MySqlCommand cmd = new MySqlCommand(SqlQueries.AuthenticateAdmin, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@Email", Email);

                try
                {
                    db.OpenConnection();
                    var result = cmd.ExecuteScalar();
                    db.CloseConnection();

                    if (result != null)
                    {
                        string storedHashedPassword = result.ToString();
                        Console.WriteLine($"Stored Hashed Password: {storedHashedPassword}");
                        Console.WriteLine($"Input Hashed Password: {hashedPassword}");

                        // Check if passwords match
                        return storedHashedPassword == hashedPassword;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    db.CloseConnection();
                    return false;
                }
            }
        }


        // Helper method to hash passwords
        private static string HashPassword(string Password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }




















    }
}
