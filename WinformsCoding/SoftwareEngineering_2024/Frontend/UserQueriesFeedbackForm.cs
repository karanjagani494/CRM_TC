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

        

            


        private void QuerySubmitBt_Click(object sender, EventArgs e)
        {
            bool IsQueryTypeSelected = QueryTypeCb.SelectedItem != null;
            bool IsTextSubmitted = !string.IsNullOrWhiteSpace(QueryTb.Text);

            if (!IsQueryTypeSelected || !IsTextSubmitted)
            {
                MessageBox.Show("Query Not Submitted\n No Query Type Selected or no text written", "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                QueryTb.Clear();
                QueryTypeCb.SelectedIndex = 0;
                MessageBox.Show("Query Submitted", "Submission Done", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }
    }
}
