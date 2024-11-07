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
    public partial class UserHomeForm1 : Form
    {
        public UserHomeForm1()
        {
            InitializeComponent();
            FbLink.Click += Opener.OpenFacebook;
            GmapLink.Click += Opener.OpenGoogleMaps;
            IgLink.Click += Opener.OpenInstagram;
            HomeBt.Click += FormOpener.OpenUserHomeForm;
            MembershipsBt.Click += FormOpener.OpenUserMembershipForm;
        }

        private void Websitelb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Opener.OpenLink("https://www.togetherculture.com");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserHomeForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
