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
        private showTables ShowTables = new showTables();

        public AdminMembersForm()
        {
            InitializeComponent();
            FormOpener.OpenAdminDashboardPages(AdminHomeBt, MembersBt, StaffEventsBt, AdminBookingsBt, EngagementBt, AdminQueryBt);
        }

        private void AdminMembersForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT \r\n    m.member_id AS MemberID,\r\n    m.first_name AS FirstName,\r\n    m.last_name AS LastName,\r\n    m.email AS Email,\r\n    m.phone_no AS PhoneNumber,\r\n    m.membership_id AS MembershipID, \r\n    m.joining_date AS JoiningDate,\r\n    m.house_no AS HouseNumber,\r\n    m.street AS Street,\r\n    m.city AS City,\r\n    m.state AS State,\r\n    m.city_code AS CityCode,\r\n    m.country AS Country\r\nFROM \r\n    members m;\r\n";
            ShowTables.GRIDVIEW(MembersTableDg, query);
        }

       
    }
}
