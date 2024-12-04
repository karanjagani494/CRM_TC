using SoftwareEngineering_2024.DB_connect;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SoftwareEngineering_2024.utilities;

namespace SoftwareEngineering_2024
{
    public partial class AdminMembersForm : Form
    {
        private userDAL userDal = new userDAL();
        public db_connect db;
        private showTables ShowTables = new showTables();

        public AdminMembersForm()
        {
            InitializeComponent();
            // Initialize the dashboard and other pages
            db = new db_connect();
            //button1.Click += button1_Click;
            FormOpener.OpenAdminDashboardPages(AdminHomeBt, MembersBt, StaffEventsBt, AdminBookingsBt, EngagementBt, AdminQueryBt);
        }

        // Method to load data into the DataGridView
        //private void GRIDVIEW()
        //{
        //    // SQL query to fetch data
        //    string query = "SELECT * FROM members";  // Ensure 'members' is your actual table name

        //    try
        //    {
        //        if (db.OpenConnection())
        //        {
        //            // Create a MySQL command
        //            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

        //            // Use MySqlDataAdapter to fill DataTable
        //            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        //            DataTable dataTable = new DataTable();
        //            adapter.Fill(dataTable);

        //            // Bind the data to the DataGridView
        //            karan.DataSource = dataTable; // Ensure DATAGRID matches your DataGridView name

        //            // Close the connection after fetching data
        //            db.CloseConnection();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Unable to connect to the database.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //}

        // Event handler for the form load event


        // Event handler for the button click
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    GRIDVIEW();  // Reload data when the button is clicked
        //}

        private void AdminMembersForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM members";
            ShowTables.GRIDVIEW(MembersTableDg , query);

        }
    }
}
