using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using YourNamespace;

namespace SoftwareEngineering_2024
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            FbLink.Click += Opener.OpenFacebook;
            GmapLink.Click += Opener.OpenGoogleMaps;
            IgLink.Click += Opener.OpenInstagram;
            LogInLink.Click += LogInLink_LinkClicked;
        }


        private void LogInLink_LinkClicked(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(LoginForm));
        }

        private void ProceedIntBt_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(InterestDptForm));

            string username = username_text.Text.Trim();
            string password = password_text.Text.Trim();
            string email = email_text.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (!IsValidEmail(email))
            //{
            //    MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            // Call your UserDAL to register the user
            UserDAL userDAL = new UserDAL();
            bool isRegistered = userDAL.RegisterUser(username, password, email);

            if (isRegistered)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Opener.OpenForm(this, typeof(LoginForm)); // Redirect to login form after successful registration
            }
            else
            {
                MessageBox.Show("Registration failed. Username may already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void TCLogo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Opener.GoBack(this);
        }

        private void PreviousPageBt_Click(object sender, EventArgs e)
        {

        }

        private void EmailSuTb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void email_text_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
