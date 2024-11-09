using MySql.Data.MySqlClient;
using SoftwareEngineering_2024;
using System;
using System.Security.Cryptography;
using System.Text;

namespace SoftwareEngineering_2024
{
    public class userDAL
    {

        private db_connect db = new db_connect();

        public void TestDatabaseConnection()
        {
            db.TestConnection();
        }





        // Register a new user
        public bool RegisterUser(string Email, string Password, string Firstname, string Lastname, string Phonenumber, string Housenumber, string City, string State, string Country, string Street,  string Citycode)
        {
            // Hash the password before storing it
            string hashedPassword = HashPassword(Password);

            //using (MySqlCommand checkUserCmd = new MySqlCommand(SqlQueries.CheckUserExist, db.GetConnection()))
            //{
            //    checkUserCmd.Parameters.AddWithValue("@Username", username);
            //    checkUserCmd.Parameters.AddWithValue("@Email", email);

            //    try
            //    {
            //        db.OpenConnection();
            //        var result = checkUserCmd.ExecuteScalar();
            //        db.CloseConnection();

            //        if (result != null)
            //        {
            //            // User already exists
            //            return false;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Error checking user: " + ex.Message);
            //        db.CloseConnection();
            //        return false;
            //    }
            //}

            // User doesn't exist, proceed with insertion
            using (MySqlCommand registerCmd = new MySqlCommand(SqlQueries.RegisterUser, db.GetConnection()))
            {
                registerCmd.Parameters.AddWithValue("@Email", Email);
                registerCmd.Parameters.AddWithValue("@password", Password);
                registerCmd.Parameters.AddWithValue("@firstName", Firstname);
                registerCmd.Parameters.AddWithValue("@lastName", Lastname);
                registerCmd.Parameters.AddWithValue("@phoneNumber", Phonenumber);
                registerCmd.Parameters.AddWithValue("@houseNumber", Housenumber);
                registerCmd.Parameters.AddWithValue("@city", City);
                registerCmd.Parameters.AddWithValue("@state", State);
                registerCmd.Parameters.AddWithValue("@country", Country);
                registerCmd.Parameters.AddWithValue("@street", Street);
                registerCmd.Parameters.AddWithValue("@cityCode", Citycode);
                

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
        //public bool AuthenticateUser(string username, string password)
        //{
        //    string hashedPassword = HashPassword(password);

        //    using (MySqlCommand cmd = new MySqlCommand(SqlQueries.AuthenticateUser, db.GetConnection()))
        //    {
        //        cmd.Parameters.AddWithValue("@Username", username);

        //        try
        //        {
        //            db.OpenConnection();
        //            var result = cmd.ExecuteScalar();
        //            db.CloseConnection();

        //            if (result != null)
        //            {
        //                string storedHashedPassword = result.ToString();
        //                return storedHashedPassword == hashedPassword;
        //            }
        //            return false;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Error: " + ex.Message);
        //            db.CloseConnection();
        //            return false;
        //        }
        //    }
        //}

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
