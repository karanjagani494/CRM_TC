using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SoftwareEngineering_2024.DB_connect;
namespace SoftwareEngineering_2024.utilities
{
    public  class FormTracker
    {

        private db_connect db = new db_connect();

        public static bool[] StepsCompleted = new bool[5];
        public void UpdateRegistrationStatus(string email)
        {
            // Check if all the registration steps are completed
            bool allStepsCompleted = FormTracker.StepsCompleted.All(step => step);

            // Set the registration status based on the steps completed
            int registrationStatus = allStepsCompleted ? 1 : 0;

            // Define the query to update the registration status in the database
            string query = "UPDATE members SET is_registered = @RegistrationStatus WHERE email = @Email";

            // Establish the database connection and execute the update
            using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))

            {
                cmd.Parameters.AddWithValue("@RegistrationStatus", registrationStatus);
                cmd.Parameters.AddWithValue("@Email", email);
                try
                {
                    db.OpenConnection();
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                }
                catch (Exception ex)
                {
                    // Optionally log or handle exception
                    throw new Exception("Database operation failed: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }



    }
}
