using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SoftwareEngineering_2024

{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void OpenLink(string url)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Ensures the URL is opened using the default browser
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link: " + ex.Message);
            }
        }

        private void Fb_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.facebook.com/p/Together-Culture-CIC-100092890960501/");
        }

        private void Gmaps_Click(object sender, EventArgs e)
        {
            OpenLink("https://maps.app.goo.gl/W6YYduRmSFShLCPu6");
        }

        private void Ig_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.instagram.com/togetherculture.cambridge/");
        }

        private void SignUpLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();

            this.Hide();
            signUpForm.Size = this.Size;
            signUpForm.ShowDialog();
        }
    }
}
