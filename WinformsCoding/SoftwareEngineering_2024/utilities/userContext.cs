using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cmp;
using MySql.Data.MySqlClient;
using SoftwareEngineering_2024.DB_connect;

namespace SoftwareEngineering_2024.utilities
{
    public class UserContext
    {
        // For accessing the database
        private db_connect db = new db_connect();

        // Static properties to store user data temporarily
        public static string? EMAIL { get; set; }
        public static int Memberid { get; set; }

        // Method to clear the context if needed (e.g., logout)
        public static void ClearContext()
        {
            EMAIL = null;
            Memberid = 0;  // Clear the Memberid as well
        }

        // Retrieve MemberID based on the static EMAIL property
        public int? RetrieveMemberID()
        {
            // Ensure EMAIL is not null or empty before attempting to retrieve the MemberID
            if (string.IsNullOrEmpty(EMAIL))
            {
                throw new Exception("Email is not set.");
            }

            Console.WriteLine($"The email being processed is: {EMAIL}");


            const string Retrieve_query = "SELECT member_id FROM members WHERE lower(email) = @email";

            using (MySqlCommand retrieveCmd = new MySqlCommand(Retrieve_query, db.GetConnection()))
            {
                retrieveCmd.Parameters.AddWithValue("@email", EMAIL);

                try
                {
                    db.OpenConnection();
                    object result = retrieveCmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int memberId))
                    {
                        UserContext.Memberid = memberId;  // Store memberId as a string (for reuse)
                        Console.WriteLine(memberId);
                        return memberId;  // Return as int
                    }
                    else
                    {
                        return null;  // Return null if no result is found
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving MemberID: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

    }
}










