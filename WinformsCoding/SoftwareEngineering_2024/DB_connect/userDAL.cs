using MySql.Data.MySqlClient;
using SoftwareEngineering_2024.utilities;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SoftwareEngineering_2024.DB_connect
{
    public class userDAL
    {

        private db_connect db = new db_connect();
        private UserContext userContext = new UserContext();



        public void TestDatabaseConnection()
        {
            db.TestConnection();
        }


        /* id can be used in any method */
        private int id = UserContext.Memberid;

        //public DataTable GetMembersData()
        //{
        //    string query = "SELECT * FROM members";  // Ensure the table name is correct
        //    DataTable dataTable = new DataTable();

        //    try
        //    {
        //        if (db.OpenConnection())
        //        {
        //            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
        //            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        //            adapter.Fill(dataTable);  // Fill the DataTable with data
        //            db.CloseConnection();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error fetching members data: " + ex.Message);
        //        db.CloseConnection();
        //    }

        //    return dataTable;
        //}

        //  ===== REGISTER MEMBER IN "TEST" DATABSE IN "MEMBER" TABLE =====
        public bool RegisterMember(string Email, string Password, string Firstname, string Lastname, string Phonenumber, string Housenumber, string City, string State, string Country, string Street, string Citycode)
        {
            // Hash the password before storing it
            string hashedPassword = HashPassword(Password);

            // Check if the user with the given email already exists
            using (MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM members WHERE email = @Email", db.GetConnection()))
            {
                checkCmd.Parameters.AddWithValue("@Email", Email);

                try
                {
                    db.OpenConnection();
                    var result = checkCmd.ExecuteScalar();
                    db.CloseConnection();

                    if (result != null && Convert.ToInt32(result) > 0)
                    {
                        // User already exists, show an alert box
                        MessageBox.Show("A user with this email already exists. Please use a different email.",
                                        "Registration Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error checking user existence: " + ex.Message);
                    db.CloseConnection();
                    return false;
                }
            }

            // User doesn't exist, proceed with insertion
            using (MySqlCommand registerCmd = new MySqlCommand(SqlQueries.RegisterMember, db.GetConnection()))
            {
                registerCmd.Parameters.AddWithValue("@first_name", Firstname);
                registerCmd.Parameters.AddWithValue("@last_name", Lastname);
                registerCmd.Parameters.AddWithValue("@Email", Email);
                registerCmd.Parameters.AddWithValue("@phone_no", Phonenumber);
                registerCmd.Parameters.AddWithValue("@password", hashedPassword);
                registerCmd.Parameters.AddWithValue("@house_no", Housenumber);
                registerCmd.Parameters.AddWithValue("@street", Street);
                registerCmd.Parameters.AddWithValue("@city", City);
                registerCmd.Parameters.AddWithValue("@state", State);
                registerCmd.Parameters.AddWithValue("@city_code", Citycode);
                registerCmd.Parameters.AddWithValue("@country", Country);


                registerCmd.Parameters.AddWithValue("@member_id", id); /* this will save member id in table*/
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

        //  =====REGISTER MEMBER INTEREST AND TAGS MEMBERSHIP TYPE=====
        public bool SaveInterestToDatabase(List<string> INTEREST)
        {

            using (MySqlCommand registerCmd = new MySqlCommand(SqlQueries.INTEREST_query, db.GetConnection()))
            {
                //// Prepare parameters for interests
                //registerCmd.Parameters.AddWithValue("@userId", GetUserId());  // Replace with your user ID retrieval logic

                // For the 5 interest columns (interest_1, interest_2, etc.)
                for (int i = 0; i < 5; i++)
                {
                    if (i < INTEREST.Count)
                    {
                        // If the interest exists, assign it to the corresponding column
                        registerCmd.Parameters.AddWithValue($"@interest_{i + 1}", INTEREST[i]);
                    }
                    else
                    {
                        // If there's no interest, set it as NULL
                        registerCmd.Parameters.AddWithValue($"@interest_{i + 1}", DBNull.Value);
                    }
                }


                registerCmd.Parameters.AddWithValue("@member_id", id); /* this will save member id in table*/

                try
                {
                    db.OpenConnection();
                    registerCmd.ExecuteNonQuery();
                    db.CloseConnection();
                    return true;
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


        public bool SaveTagToDatabase(List<string> TAG)
        {
            using (MySqlCommand registerCmd = new MySqlCommand(SqlQueries.TAG_query, db.GetConnection()))
            {

                // For the 5 interest columns (interest_1, interest_2, etc.)
                for (int i = 0; i < 12; i++)
                {
                    if (i < TAG.Count)
                    {
                        // If the interest exists, assign it to the corresponding column
                        registerCmd.Parameters.AddWithValue($"@tag_{i + 1}", TAG[i]);
                    }
                    else
                    {
                        // If there's no interest, set it as NULL
                        registerCmd.Parameters.AddWithValue($"@tag_{i + 1}", DBNull.Value);
                    }
                }

                registerCmd.Parameters.AddWithValue("@member_id", id); /* this will save member id in table*/

                try
                {
                    db.OpenConnection();
                    registerCmd.ExecuteNonQuery();
                    db.CloseConnection();
                    return true;
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


        public bool SaveMem_TypeToDatabase(int Type)
        {
            using (MySqlCommand registerCmd = new MySqlCommand(SqlQueries.MemInfo_query, db.GetConnection()))
            {
                registerCmd.Parameters.AddWithValue("@membership_id", Type);

               
                try
                {
                    db.OpenConnection();
                    int rowsAffected = registerCmd.ExecuteNonQuery();
                    db.CloseConnection();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }



        public bool Payment_infoToDatabse(string CardHolder_name, string Card_no, string Cvv, string House_no, string City, string State, string Country, string Street, string Citycode, string Exp_date)
        {


            // User doesn't exist, proceed with insertion
            using (MySqlCommand registerCmd = new MySqlCommand(SqlQueries.Payment_query, db.GetConnection()))
            {



                registerCmd.Parameters.AddWithValue("@cardHolder_name", CardHolder_name);
                registerCmd.Parameters.AddWithValue("@card_no", Card_no);
                registerCmd.Parameters.AddWithValue("@cvv", Cvv);
                registerCmd.Parameters.AddWithValue("@house_no", House_no);
                registerCmd.Parameters.AddWithValue("@city", City);
                registerCmd.Parameters.AddWithValue("@state", State);
                registerCmd.Parameters.AddWithValue("@country", Country);
                registerCmd.Parameters.AddWithValue("@street", Street);
                registerCmd.Parameters.AddWithValue("@citycode", Citycode);
                registerCmd.Parameters.AddWithValue("@exp_date", Exp_date);

                registerCmd.Parameters.AddWithValue("@member_id", id); //* this will save member id in table*/


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




        /* This method is called when user press the prvious button and this method will delete thw last entered data from the databse*/
        public bool DeleteUserByMEmid()
        {

            int id = UserContext.Memberid;
            string Delete_query = "DELETE FROM members WHERE member_id = @member_id";

            using (MySqlCommand command = new MySqlCommand(Delete_query, db.GetConnection()))
            {
                command.Parameters.AddWithValue("@member_id", id);


                try
                {
                    db.OpenConnection();
                    command.ExecuteNonQuery();
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




        //This method will authentic the user at the time of login
        public bool AuthenticateUser(string Email, string Password)
        {
            string hashedPassword = HashPassword(Password); // Hash the input password

            using (MySqlCommand cmd = new MySqlCommand(SqlQueries.AuthenticateUser, db.GetConnection()))
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
