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
            FbLink.Click += Opener.OpenFacebook;
            GmapLink.Click += Opener.OpenGoogleMaps;
            IgLink.Click += Opener.OpenInstagram;
            AccountCreateLink.Click += SignUpLinkClicked;
        }

        private void SignUpLinkClicked(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(SignUpForm));
        }
    }
}
