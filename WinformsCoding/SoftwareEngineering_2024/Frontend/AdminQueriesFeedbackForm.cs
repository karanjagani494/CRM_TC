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
            FormOpener.OpenAdminDashboardPages(AdminHomeBt, MembersBt, StaffEventsBt, AdminBookingsBt, EngagementBt, AdminQueryBt);
        }

        private void AdminQueriesFeedbacksForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT \r\n    i.inquiries_id AS InquiryID,\r\n    i.member_id AS MemberID,\r\n    i.inquiry_description AS InquiryDescription,\r\n    i.inquiry_mode AS InquiryMode,\r\n    i.inquiry_type_id AS InquiryTypeID,\r\n    i.user_category_id AS UserCategoryID,\r\n    i.inquiry_date AS InquiryDate,\r\n    i.follow_up_count AS FollowUpCount,\r\n    i.status AS Status\r\nFROM \r\n    inquiries_and_feedback i;\r\n";
            ShowTables.GRIDVIEW(QueriesFeedbackTableDg, query);
        }

    }
}
