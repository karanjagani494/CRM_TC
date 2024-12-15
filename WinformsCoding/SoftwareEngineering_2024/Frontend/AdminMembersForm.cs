using SoftwareEngineering_2024.DB_connect;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SoftwareEngineering_2024.utilities;
using System.Windows.Forms.DataVisualization.Charting;

namespace SoftwareEngineering_2024
{
    public partial class AdminMembersForm : Form
    {
        private showTables ShowTables = new showTables();
        private DataVisualization dv = new DataVisualization();

        public AdminMembersForm()
        {
            InitializeComponent();
            FormOpener.OpenAdminDashboardPages(AdminHomeBt, MembersBt, StaffEventsBt, AdminBookingsBt, EngagementBt, AdminQueryBt, Attendance_log_bt);
        }

        private void AdminMembersForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT \r\n    m.member_id AS MemberID,\r\n    m.first_name AS FirstName,\r\n    m.last_name AS LastName,\r\n    m.email AS Email,\r\n    m.phone_no AS PhoneNumber,\r\n    m.membership_id AS MembershipID, \r\n    m.joining_date AS JoiningDate,\r\n    m.house_no AS HouseNumber,\r\n    m.street AS Street,\r\n    m.city AS City,\r\n    m.state AS State,\r\n    m.city_code AS CityCode,\r\n    m.country AS Country\r\nFROM \r\n    members m;\r\n";
            ShowTables.GRIDVIEW(MembersTableDg, query);
            //string query2 = "SELECT membership_id, COUNT(*) AS member_count FROM members GROUP BY membership_id ORDER BY membership_id";
        }

        private void MemQ1Bt_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT membership_id, COUNT(*) AS member_count FROM members GROUP BY membership_id ORDER BY membership_id";
            ShowTables.GRIDVIEW(MembersTableDg, query1);

        }

        private void MemQ2Bt_Click(object sender, EventArgs e)
        {
            string query2 = "SELECT membership_id, COUNT(*) AS member_count FROM members GROUP BY membership_id ORDER BY membership_id";
            ShowTables.GRIDVIEW(MembersTableDg, query2);
        }



        private void RefreshBt_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(AdminMembersForm));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowTables.DeleteRecord("Members", "member_id", querytxt);
        }
    }
}
