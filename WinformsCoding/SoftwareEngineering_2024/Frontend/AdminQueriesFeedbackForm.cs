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
    public partial class AdminQueriesFeedbackForm : Form
    {
        private showTables ShowTables = new showTables();

        public AdminQueriesFeedbackForm()
        {
            InitializeComponent();
            FormOpener.OpenAdminDashboardPages(AdminHomeBt, MembersBt, StaffEventsBt, AdminBookingsBt, EngagementBt, AdminQueryBt, Attendance_log_bt);
        }



        private void RefreshBt_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(AdminQueriesFeedbackForm));
        }

        private void AdminQueriesFeedbackLoad(object sender, EventArgs e)
        {
            string query = "SELECT \r\n    `queries_feedback`.`Queries_Feedback_id` AS `Feedback_ID`,\r\n    `queries_feedback`.`Query_Type` AS `Type`,\r\n    `queries_feedback`.`Queries_Feedback_description` AS `Description`,\r\n    `queries_feedback`.`member_id` AS `Member_ID`\r\nFROM \r\n    `fresh`.`queries_feedback`;\r\n";
            ShowTables.GRIDVIEW(QueriesFeedbackTableDg, query);
        }
    }
}
