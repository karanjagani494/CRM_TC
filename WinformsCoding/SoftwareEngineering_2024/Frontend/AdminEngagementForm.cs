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
    public partial class AdminEngagementForm : Form
    {
        showTables ShowTables = new showTables();
        public AdminEngagementForm()
        {
            InitializeComponent();
            FormOpener.OpenAdminDashboardPages(AdminHomeBt, MembersBt, StaffEventsBt, AdminBookingsBt, EngagementBt, AdminQueryBt, Attendance_log_bt);
           
        }

        private void RefreshBt_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(AdminEngagementForm));
        }

        private void AdminEngagementLoad(object sender, EventArgs e)
        {
            string query = "SELECT \r\n    m.member_id AS `Member_ID`,\r\n    m.membership_id AS `Membership_ID`,\r\n    COUNT(DISTINCT al.attendance_id) AS `Events_Attended`,\r\n    COUNT(DISTINCT b.Booking_id) AS `Events_Booked`,\r\n    m.joining_date AS `Joining_Date`\r\nFROM \r\n    members m\r\nLEFT JOIN \r\n    attendance_log al ON m.member_id = al.member_id AND al.event_id IS NOT NULL\r\nLEFT JOIN \r\n    bookings b ON m.member_id = b.member_id\r\nGROUP BY \r\n    m.member_id, m.membership_id, m.joining_date\r\nORDER BY \r\n    m.member_id;\r\n";
            ShowTables.GRIDVIEW(EngagementsTableDg, query);
        }
    }
}
