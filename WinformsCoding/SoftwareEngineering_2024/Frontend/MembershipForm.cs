using Mysqlx.Notice;
using SoftwareEngineering_2024.DB_connect;
using SoftwareEngineering_2024.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering_2024
{
    public partial class MembershipForm : Form
    {

        private userDAL userDAL = new userDAL();
        int member_id = UserContext.Memberid;

        public MembershipForm()
        {
            InitializeComponent();
            Community_cb.CheckedChanged += MembershipOption_CheckedChanged;
            fullTime_cb.CheckedChanged += MembershipOption_CheckedChanged;
            Community02_cb.CheckedChanged += MembershipOption_CheckedChanged;
            partTime_cb.CheckedChanged += MembershipOption_CheckedChanged;
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);
            LogInLink.Click += LogInLink_Click;

        }

        private void LogInLink_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(LoginForm));
        }

        



    public void MembershipOption_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkedBox && checkedBox.Checked)
            {
                // Uncheck all other checkboxes except the one that was just checked
                foreach (Control control in MembershipPanel.Controls)
                {
                    if (control is CheckBox checkBox && checkBox != checkedBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private int GetSelectedMem_type()
        {

            if (partTime_cb.Checked) return 1;
            if (fullTime_cb.Checked) return 2;
            if (Community_cb.Checked) return 3;
            if (Community02_cb.Checked) return 4;


            return 0;
        }

        private void PreviousPageBt_Click(object sender, EventArgs e)
        {
            Opener.GoBack(this);
            FormTracker.StepsCompleted[3] = false;
            userDAL.DeleteUserByMEmid();
        }

        private void ProceedIntBt_Click(object sender, EventArgs e)
        {
            if (Opener.AreTextBoxesFilledAndCheckboxesChecked(this))
            {
                int membership_id = GetSelectedMem_type();

                if (membership_id != 0) // Check if the list is not null and contains items
                {
                    try
                    {
                        // Use the UserDAL instance to save the interests to the database
                        bool Registered = userDAL.SaveMem_TypeToDatabase(membership_id, member_id);
                        MessageBox.Show("Membership saved successfully!");
                        FormTracker.StepsCompleted[3] = true; //this will count this form if the form is completed then it will store true
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please select at least one Membership.");
                }

                Opener.OpenForm(this, typeof(Payment));
            }

        }

        private void TCLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
