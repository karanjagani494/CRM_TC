using SoftwareEngineering_2024.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering_2024
{
    public partial class Attendance_Log : Form
    {
        public Attendance_Log()
        {
            InitializeComponent();
            FormOpener.OpenAdminDashboardPages(AdminHomeBt, MembersBt, StaffEventsBt, AdminBookingsBt, EngagementBt, AdminQueryBt, Attendance_log_bt);
        }

        showTables ShowTables = new showTables();

        private void Attendance_Log_Load(object sender, EventArgs e)
        {
            string query = "SELECT \r\n    m.member_id AS MemberID,\r\n    m.first_name AS FirstName,\r\n    m.last_name AS LastName,\r\n    m.email AS Email,\r\n    m.phone_no AS PhoneNumber,\r\n    m.membership_id AS MembershipID, \r\n    m.joining_date AS JoiningDate,\r\n    m.house_no AS HouseNumber,\r\n    m.street AS Street,\r\n    m.city AS City,\r\n    m.state AS State,\r\n    m.city_code AS CityCode,\r\n    m.country AS Country\r\nFROM \r\n    members m;\r\n";
            ShowTables.GRIDVIEW(AttendanceLogTableDg, query);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void MemQ1Bt_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT membership_id, COUNT(*) AS member_count FROM members GROUP BY membership_id ORDER BY membership_id";
            ShowTables.GRIDVIEW(AttendanceLogTableDg, query1);

        }

        private void MemQ2Bt_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT membership_id, COUNT(*) AS member_count FROM members GROUP BY membership_id ORDER BY membership_id";
            ShowTables.GRIDVIEW(AttendanceLogTableDg, query1);
        }

        private void MemQuerySubmitBt_Click(object sender, EventArgs e)
        {
            string query3 = querytxt.Text;
            ShowTables.GRIDVIEW(AttendanceLogTableDg, query3);
        }
    }
}
