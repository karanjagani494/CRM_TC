using SoftwareEngineering_2024.utilities;
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
    public partial class ThankYouForm : Form
    {

        private SignUpForm SignUpForm = new SignUpForm();

      EmailService emailService = new EmailService();
        public ThankYouForm()
        {
            InitializeComponent();
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);

        }

        private void ThankyouLoginBt_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(LoginForm));

            /* this will send emil to user who is registering*/


            SignUpForm.callemail();
        }
    }
}
