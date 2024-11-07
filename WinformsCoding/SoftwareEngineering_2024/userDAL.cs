using MySql.Data.MySqlClient;
using SoftwareEngineering_2024;
using System;
using System.Security.Cryptography;
using System.Text;

namespace YourNamespace
{
    public class UserDAL
    {
        private db_connect db = new db_connect();

        // Register a new user
        public bool RegisterUser(string username, string password, string email)
        {
            // Hash the password before storing it
            string hashedPassword = HashPassword(password);

            using (MySqlCommand checkUserCmd = new MySqlCommand(SqlQueries.CheckUserExist, db.GetConnection()))
            {
                checkUserCmd.Parameters.AddWithValue("@Username", username);
                checkUserCmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    db.OpenConnection();
                    var result = checkUserCmd.ExecuteScalar();
                    db.CloseConnection();

                    if (result != null)
                    {
                        // User already exists
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error checking user: " + ex.Message);
                    db.CloseConnection();
                    return false;
                }
            }

            // User doesn't exist, proceed with insertion
            using (MySqlCommand registerCmd = new MySqlCommand(SqlQueries.RegisterUser, db.GetConnection()))
            {
                registerCmd.Parameters.AddWithValue("@Username", username);
                registerCmd.Parameters.AddWithValue("@Password", hashedPassword);
                registerCmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    db.OpenConnection();
                    registerCmd.ExecuteNonQuery();
                    db.CloseConnection();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error registering user: " + ex.Message);
                    db.CloseConnection();
                    return false;
                }
            }
        }


        // Authenticate user
        public bool AuthenticateUser(string username, string password)
        {
            string hashedPassword = HashPassword(password);

            using (MySqlCommand cmd = new MySqlCommand(SqlQueries.AuthenticateUser, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@Username", username);

                try
                {
                    db.OpenConnection();
                    var result = cmd.ExecuteScalar();
                    db.CloseConnection();

                    if (result != null)
                    {
                        string storedHashedPassword = result.ToString();
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
        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
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
