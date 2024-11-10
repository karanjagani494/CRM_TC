using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SoftwareEngineering_2024
{
    public partial class LoginForm : Form
    {
        // Initialize userDAL to ensure it's not null when used
        private userDAL userDAL = new userDAL();

        public LoginForm()
        {
            InitializeComponent();
<<<<<<< HEAD
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);
=======

            // Attach events to link labels
            FbLink.Click += Opener.OpenFacebook;
            GmapLink.Click += Opener.OpenGoogleMaps;
            IgLink.Click += Opener.OpenInstagram;
>>>>>>> ed5919cbbbb322d554e0967e4a9c5ff1d857dadb
            AccountCreateLink.Click += SignUpLinkClicked;
        }

        private void SignUpLinkClicked(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(SignUpForm));
        }

        private void LoginBt_Click(object sender, EventArgs e)
        {
            // Retrieve email and password from form inputs
            string Email = email_txt?.Text ?? string.Empty;
            string Password = password_txt?.Text ?? string.Empty;

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter both email and password.", "Login Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Authenticate the user
            bool isAuthenticated = userDAL.AuthenticateUser(Email, Password);

            if (isAuthenticated)
            {
                // Navigate to UserHomeForm1 if authentication is successful
                Opener.OpenForm(this, typeof(UserHomeForm1));
            }
            else
            {
                // Show error message if authentication fails
                MessageBox.Show("Invalid email or password. Please try again.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void SignUpLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // You might not need this method if it's redundant
        }
    }
}
