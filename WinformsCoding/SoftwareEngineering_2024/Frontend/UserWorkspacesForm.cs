using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SoftwareEngineering_2024.DB_connect;

namespace SoftwareEngineering_2024
{
    public partial class UserWorkspacesForm : Form
    {
        public UserWorkspacesForm()
        {
            InitializeComponent();
            FormOpener.OpenUserDashboardPages(HomeBt, MembershipsBt, EventsBt, MyBookingsBt, SpaceBt, QueryBt);
        }
        

        db_connect db = new db_connect();


        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            // Get the selected date from the DateTimePicker
            string selectedDate = WsDateDtp.Value.ToString("yyyy-MM-dd");

            // SQL query to fetch available spaces
            string query = @"
        SELECT DISTINCT space
        FROM (SELECT 'cafe' AS space UNION ALL SELECT 'art room' UNION ALL SELECT 'living room'
              UNION ALL SELECT 'tech room' UNION ALL SELECT 'together hall') AS AllSpaces
        WHERE space NOT IN (
            SELECT space
            FROM events -- Replace with 
            WHERE event_date = @selectedDate
        );";

            try
            {
                // Open the connection before executing the query
                if (db.OpenConnection())
                {
                    using (MySqlConnection conn = db.GetConnection())
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Add the selectedDate parameter
                            cmd.Parameters.AddWithValue("@selectedDate", selectedDate);

                            // Execute the query
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                StringBuilder availableSpaces = new StringBuilder("Available Spaces:\n");

                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        availableSpaces.AppendLine(reader.GetString(0));
                                    }
                                }
                                else
                                {
                                    availableSpaces.AppendLine("No spaces are available for the selected date.");
                                }

                                // Show results
                                MessageBox.Show(availableSpaces.ToString(), "Available Spaces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection after each query
                db.CloseConnection();
            }
            Opener.OpenForm(this, typeof(UserWorkspacesForm));
        }
    }
}