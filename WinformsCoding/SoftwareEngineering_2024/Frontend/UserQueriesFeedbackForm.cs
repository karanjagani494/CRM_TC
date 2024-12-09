using SoftwareEngineering_2024.DB_connect;
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
    public partial class UserQueriesFeedbackForm : Form
    {
        public UserQueriesFeedbackForm()
        {
            InitializeComponent();
            FormOpener.OpenUserDashboardPages(HomeBt, MembershipsBt, EventsBt, MyBookingsBt, SpaceBt, QueryBt);
        }

        private LoginForm loginForm = new LoginForm();
        private userDAL userDAL = new userDAL();


        private void QuerySubmitBt_Click(object sender, EventArgs e)
        {
            int? id = loginForm.Give_Id();
            string Query_description = QueryTb.Text;
            string selectedQueryType = QueryTypeCb.SelectedItem.ToString();
            bool IsQueryTypeSelected = QueryTypeCb.SelectedItem != null;
            bool IsTextSubmitted = !string.IsNullOrWhiteSpace(QueryTb.Text);

            if (!IsQueryTypeSelected || !IsTextSubmitted)
            {
                MessageBox.Show("Query Not Submitted\n No Query Type Selected or no text written", "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                bool Registered = userDAL.SaveQueryFeedbackToDatabase(selectedQueryType, Query_description, id);
                QueryTb.Clear();
                QueryTypeCb.SelectedIndex = 0;
                MessageBox.Show("Query Submitted", "Submission Done", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
            
        }
    }
}
