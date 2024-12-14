using SoftwareEngineering_2024.DB_connect;
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
            bool IsQueryTypeSelected = QueryTypeCb.SelectedItem != null;
            bool IsTextSubmitted = !string.IsNullOrWhiteSpace(QueryTb.Text);
            //int? id = loginForm.Give_Id();
            int id = UserContext.Memberid;



            if (!IsQueryTypeSelected || !IsTextSubmitted)
            {
                MessageBox.Show("Query Not Submitted\n No Query Type Selected or no text written", "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (IsQueryTypeSelected && IsTextSubmitted)
            {
                string selectedQueryType = QueryTypeCb.SelectedItem.ToString();
                string Query_description = QueryTb.Text;
                bool Registered = userDAL.SaveQueryFeedbackToDatabase(selectedQueryType, Query_description, id);
                if (Registered)
                {
                    MessageBox.Show("Query Submitted", "Submission Done", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    QueryTb.Clear();
                    QueryTypeCb.SelectedIndex = 0;

                }
                else
                {
                    MessageBox.Show("Query Not Submitted", "Query Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }

            }
            else
            {
                MessageBox.Show("Query Not Submitted", "Error Ocurred while submission", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

       
    }
}
