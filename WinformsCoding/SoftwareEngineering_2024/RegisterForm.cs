using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cmp;
using SoftwareEngineering_2024;

namespace SoftwareEngineering_2024
{
    public partial class SignUpForm : Form
    {
        private userDAL userDAL;
        public SignUpForm()
        {
            InitializeComponent();
            FbLink.Click += Opener.OpenFacebook;
            GmapLink.Click += Opener.OpenGoogleMaps;
            IgLink.Click += Opener.OpenInstagram;
            LogInLink.Click += LogInLink_LinkClicked;
            userDAL = new userDAL();

        }


        private void LogInLink_LinkClicked(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(LoginForm));

           


}

        private void ProceedIntBt_Click(object sender, EventArgs e)
        {
            
            userDAL.TestDatabaseConnection();

            // Check if all required textboxes are filled
            if (Opener.AreTextBoxesFilledAndCheckboxesChecked(this))
            {
                Opener.OpenForm(this, typeof(InterestDptForm));

                

        

                string Email = email.Text;
                string Password = password.Text;
                string Firstname = firstName.Text;
                string Lastname = lastName.Text;
                string Phonenumber = phoneNumber.Text;
                string Housenumber = houseNumber.Text;
                string City = city.Text;
                string State = state.Text;
                string Country = country.Text;
                string Street = street.Text;
                string Citycode = cityCode.Text;




                // Attempt to register the user
                bool isRegistered = userDAL.RegisterUser(Email, Password, Firstname, Lastname, Phonenumber, Housenumber, City, State, Country, Street, Citycode);

                // if (isRegistered)
                // {
                //     lblStatus.Text = "Registration successful!";
                // }
                // else
                // {
                //     lblStatus.Text = "Registration failed. User may already exist.";
                // }


                //}
                // else
                //  {
                //     lblStatus.Text = "Please fill in all fields and accept terms.";
                //  }

            }
            
        }


        private void PreviousPageBt_Click(object sender, EventArgs e)
        {

            Opener.GoBack(this);

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void phoneNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
