using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering_2024
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            /*FbLink.Click += Opener.OpenFacebook;
            GmapLink.Click += Opener.OpenGoogleMaps;
            IgLink.Click += Opener.OpenInstagram;*/
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);
            LogInLink.Click += LogInLink_LinkClicked;
        }


        private void LogInLink_LinkClicked(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(LoginForm));
        }

        private void ProceedIntBt_Click(object sender, EventArgs e)
        {
            // Check if all required textboxes are filled
            if (Opener.AreTextBoxesFilledAndCheckboxesChecked(this))
            {
                Opener.OpenForm(this, typeof(InterestDptForm));
            }
        }


        private void PreviousPageBt_Click(object sender, EventArgs e)
        {

            Opener.GoBack(this);

        }

       
    }
}
