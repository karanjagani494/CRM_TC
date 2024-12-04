using Mysqlx.Notice;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareEngineering_2024
{
    public partial class TagsForm : Form
    {


        private userDAL userDAL = new userDAL();


        public TagsForm()
        {
            InitializeComponent();
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);
            LogInLink.Click += LogInLink_Click;
            ProceedMembBt.Click += ProceedMembBt_Click;
        }

        private void ProceedMembBt_Click(object? sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(MembershipForm)); // Opens MembershipForm and stores TagsForm



            List<string> TAG = GetSelectedInterest(); // Ensure you are calling the correct method

            if (TAG != null && TAG.Count > 0) // Check if the list is not null and contains items
            {
                try
                {

                    bool Registered = userDAL.SaveTagToDatabase(TAG);
                    MessageBox.Show("Interests saved successfully!");
                    FormTracker.StepsCompleted[2] = true; //this will count this form if the form is completed then it will store true
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




        //TAKING INPUT FROM CHECK BOX
        private List<string> GetSelectedInterest()
        {
            List<string> TAG = new List<string>();

            // Check each radio button and add the corresponding interest to the list if it's checked
            if (Tech_cb.Checked) TAG.Add("TEC");
            if (Healthcare_cb.Checked) TAG.Add("HEALTHCARE");
            if (Employment_cb.Checked) TAG.Add("EMPLOYMENT");
            if (Space_cb.Checked) TAG.Add("SPACE");
            if (Politics_cb.Checked) TAG.Add("POLITICS");
            if (Law_cb.Checked) TAG.Add("LAW");
            if (Music_cb.Checked) TAG.Add("MUSIC");
            if (Fashion_cb.Checked) TAG.Add("FASHION");
            if (Gaming_cb.Checked) TAG.Add("GAMING");
            if (Education_cb.Checked) TAG.Add("EDUCATION");
            if (Business_cb.Checked) TAG.Add("BUSINESS");
            if (Nature_cb.Checked) TAG.Add("NATURE");

            return TAG;
        }

        private void LogInLink_Click(object? sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(LoginForm)); // Opens LoginForm and stores current form
        }

        private void PreviousPageBt_Click(object sender, EventArgs e)
        {
            Opener.GoBack(this);
            FormTracker.StepsCompleted[2] = false;
            userDAL.DeleteUserByMEmid();
        }

        private void EmploymentCb_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
