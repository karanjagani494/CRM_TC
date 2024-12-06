using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SoftwareEngineering_2024.DB_connect;
using SoftwareEngineering_2024.utilities;

namespace SoftwareEngineering_2024
{
    public partial class LoginForm : Form
    {
        // Initialize userDAL to ensure it's not null when used
        private userDAL userDAL = new userDAL();

        public LoginForm()
        {
            InitializeComponent();

            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);

            AccountCreateLink.Click += SignUpLinkClicked;
        }

        private void SignUpLinkClicked(object sender, EventArgs e)
        {
            FormOpener.OpenUserForm(this, typeof(SignUpForm));
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

            // Declare a variable to store the registration status
            bool isRegistered;

            // Authenticate the user and get the registration status
            bool isAuthenticated = userDAL.AuthenticateUser(Email, Password, out isRegistered);

            if (isAuthenticated)
            {
                if (isRegistered)
                {
                    // Navigate to UserHomeForm1 if authentication is successful and registration is complete
                    Opener.OpenForm(this, typeof(UserHomeForm1));
                }
                else
                {
                    // Show an error message if registration is not completed
                    MessageBox.Show("Please complete the registration process before logging in.",
                                     "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Show error message if authentication fails
                MessageBox.Show("Invalid email or password. Please try again.",
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AdminLoginLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormOpener.OpenUserForm(this, typeof(Admin_log_in));
        }
    }
}
