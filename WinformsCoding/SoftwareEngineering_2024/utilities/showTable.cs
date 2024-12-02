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
        public  void GRIDVIEW( DataGridView dataGridView, string query)
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


    }
}
