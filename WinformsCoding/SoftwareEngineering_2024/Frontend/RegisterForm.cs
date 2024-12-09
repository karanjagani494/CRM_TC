using SoftwareEngineering_2024.DB_connect;
using SoftwareEngineering_2024.utilities;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace SoftwareEngineering_2024
{
    public partial class SignUpForm : Form
    {
        private userDAL userDAL = new userDAL();
        private UserContext userContext = new UserContext();
        private EmailService emailService = new EmailService();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static string Firstname { get;  set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static string Lastname { get; set; }


        public SignUpForm()
        {
            InitializeComponent();
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);
            phoneNumber.KeyPress += Opener.Number_KeyPress;
            LogInLink.Click += LogInLink_LinkClicked;
            phoneNumber.TextChanged += (s, e) => Opener.ValidateNumericTextBox(phoneNumber);
        }

        private void LogInLink_LinkClicked(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(LoginForm));
        }

        public void ProceedIntBt_Click(object sender, EventArgs e)
        {
            // Check if all required textboxes are filled
            if (Opener.AreTextBoxesFilledAndCheckboxesChecked(this))
            {
                string str1 = email.Text;
                string Email = str1.ToLower(); // Store email in lowercase
                string Password = password.Text;
                string RePass = rePassTb.Text;

                string str2 = firstName.Text;
                Firstname = str2.ToUpper(); // Assign to class variable
                string str3 = lastName.Text;
                Lastname = str3.ToUpper(); // Assign to class variable

                string Phonenumber = phoneNumber.Text;
                string Housenumber = houseNumber.Text;
                string City = city.Text;
                string State = state.Text;
                string Country = country.Text;
                string Street = street.Text;
                string Citycode = cityCode.Text;

                if (Password != RePass)
                {
                    MessageBox.Show("Passwords do not match",
                        "Registration Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    bool isRegistered = userDAL.RegisterMember(Email, Password, Firstname, Lastname, Phonenumber, Housenumber, Street, City, State, Country, Citycode);

                    UserContext.EMAIL = Email; // Store email in UserContext
                    userContext.RetrieveMemberID();

                    if (isRegistered)
                    {
                        FormTracker.StepsCompleted[0] = true; // Mark the form as completed
                        Opener.OpenForm(this, typeof(InterestDptForm));
                    }
                }
            }
        }

        public void callemail()
        {
            string toEmail = UserContext.EMAIL;
            string subject = "Welcome to CRM!";

            // Personalize the email body with the user's first and last name
            string body = $"Dear {Firstname} {Lastname},\n\nThank you for registering with us.\n\nBest Regards,\nCRM Team";

            emailService.SendEmail(toEmail, subject, body);
        }

        private void PreviousPageBt_Click(object sender, EventArgs e)
        {
            Opener.GoBack(this);
        }
    }
}

