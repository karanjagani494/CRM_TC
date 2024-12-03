using SoftwareEngineering_2024.DB_connect;
using SoftwareEngineering_2024.utilities;

namespace SoftwareEngineering_2024
{
    public partial class SignUpForm : Form
    {
        private userDAL userDAL = new userDAL();
        private UserContext userContext = new UserContext();
        public SignUpForm()
        {
            InitializeComponent();
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);
            phoneNumber.KeyPress += Opener.Number_KeyPress;
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

                string str1 = email.Text;
                string Email = str1.ToLower();  /* TO lower will store always in lowercase of email */
                string Password = password.Text;

                /* TO lower will store always in UPPERCASE  of first and last name */
                string str2 = firstName.Text;
                string Firstname = str2.ToUpper();
                string str3 = lastName.Text;
                string Lastname = str3.ToUpper();

                string Phonenumber = phoneNumber.Text;
                string Housenumber = houseNumber.Text;
                string City = city.Text;
                string State = state.Text;
                string Country = country.Text;
                string Street = street.Text;
                string Citycode = cityCode.Text;



                

               

                // Attempt to register the user
                bool isRegistered = userDAL.RegisterMember(Email, Password, Firstname, Lastname, Phonenumber, Housenumber, Street, City, State, Country, Citycode);

                UserContext.EMAIL = Email; /*  this line is storin email in userContext file in utilitis folder  */
                userContext.RetrieveMemberID();

                if (isRegistered) {


                    FormTracker.StepsCompleted[0] = true;
                    bool print = FormTracker.StepsCompleted[0];
                    Console.WriteLine(print);

                }


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

        //private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Allow control keys (e.g., backspace) and digits
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        // Reject the input if it is not a digit or control key
        //        e.Handled = true;
        //    }
        //}


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
