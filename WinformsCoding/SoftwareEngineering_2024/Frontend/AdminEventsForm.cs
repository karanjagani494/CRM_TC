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
    public partial class AdminEventsForm : Form

    {
        private showTables ShowTables = new showTables();

        public AdminEventsForm()
        {
            InitializeComponent();
            FormOpener.OpenAdminDashboardPages(AdminHomeBt, MembersBt, StaffEventsBt, AdminBookingsBt, EngagementBt, AdminQueryBt, Attendance_log_bt);

        }

        private void AdminEventsForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT \r\n    e.event_id AS EventID,\r\n    e.event_name AS EventName,\r\n    e.event_date AS EventDate,\r\n    e.event_type AS EventType,\r\n    e.space AS Space,\r\n   e.public_price AS PublicPrice,\r\n    e.member_price AS MemberPrice\r\nFROM \r\n    events e;\r\n";
            ShowTables.GRIDVIEW(EventsTableDg, query);
        }

        private void RefreshBt_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(AdminEventsForm));
        }
    }
}
