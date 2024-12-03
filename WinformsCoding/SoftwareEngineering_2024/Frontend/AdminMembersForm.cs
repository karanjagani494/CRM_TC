using SoftwareEngineering_2024.DB_connect;
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

        private void AdminMembersForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM user;"; // Query to load payment data
            userDAL.PopulateDataGridViewUsingBindingSource(MembersTableDg, query);
        }
    }
}
