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
            //if (sender is CheckBox checkedBox && checkedBox.Checked)
            //{
            //    // Uncheck all other checkboxes except the one that was just checked
            //    foreach (Control control in MembershipPanel.Controls)
            //    {
            //        if (control is CheckBox checkBox && checkBox != checkedBox)
            //        {
            //            checkBox.Checked = false;
            //        }
            //    }
            //}



            string Type = GetSelectedMem_type();

            if (!string.IsNullOrEmpty(Type)) // Check if the list is not null and contains items
            {
                try
                {
                    // Use the UserDAL instance to save the interests to the database
                    bool Registered = userDAL.SaveMem_TypeToDatabase(Type);
                    MessageBox.Show("Interests saved successfully!");
                    FormTracker.StepsCompleted[3] = true; //this will count this form if the form is completed then it will store true
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select at least one interest.");
            }

        }





        private string GetSelectedMem_type()
        {
            

            // Check each radio button and add the corresponding interest to the list if it's checked
            if (partTime_cb.Checked) return ("Part_TIME");
            if (fullTime_cb.Checked) return("Full_Time");
            if (Community_cb.Checked) return("Community01");
            if (Community02_cb.Checked) return ("Community02");
            

            return null;
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
                Opener.OpenForm(this, typeof(Payment));
            }

        }

        private void TCLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
