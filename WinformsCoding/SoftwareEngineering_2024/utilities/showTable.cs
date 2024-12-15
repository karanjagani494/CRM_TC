using SoftwareEngineering_2024.DB_connect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SoftwareEngineering_2024.utilities
{
    public class showTables
    {
        public db_connect db = new db_connect();
        
        public void GRIDVIEW(DataGridView dataGridView, string query)
        {


            try
            {
                if (db.OpenConnection())
                {
                    // Create a MySQL command
                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

                    // Use MySqlDataAdapter to fill DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to the DataGridView
                    dataGridView.DataSource = dataTable; // Ensure DATAGRID matches your DataGridView name

                    // Close the connection after fetching data
                    db.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Unable to connect to the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void DeleteRecord(string tableName, string keyColumn, TextBox textBoxMemberId)
        {
            try
            {
                // Get the member ID from the textbox
                string memberId = textBoxMemberId.Text.Trim();

                // Check if the textbox is not empty
                if (string.IsNullOrEmpty(memberId))
                {
                    MessageBox.Show("Please enter a valid Member ID.");
                    return;
                }

                // Create the DELETE query
                string deleteQuery = $"DELETE FROM {tableName} WHERE {keyColumn} = @MemberId";

                // Open the database connection
                if (db.OpenConnection())
                {
                    // Prepare the command
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, db.GetConnection());
                    cmd.Parameters.AddWithValue("@MemberId", memberId);

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if any rows were deleted
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given Member ID.");
                    }
                }
                else
                {
                    MessageBox.Show("Unable to connect to the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                db.CloseConnection();
            }
        }




    }
}
