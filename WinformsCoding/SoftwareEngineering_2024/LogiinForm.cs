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
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);
            AccountCreateLink.Click += SignUpLinkClicked;
        }

        private void SignUpLinkClicked(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(SignUpForm));
        }

        private void LoginBt_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(UserHomeForm1));
        }

        private void SignUpLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
