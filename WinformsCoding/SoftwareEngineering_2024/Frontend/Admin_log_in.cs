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
    public partial class Admin_log_in : Form
    {
        public Admin_log_in()
        {
            InitializeComponent();
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);
        }

        private void AdminLoginBt_Click(object sender, EventArgs e)
        {
            FormOpener.OpenUserForm(this, typeof(AdminHomeForm));
        }

        private void Admin_log_in_Load(object sender, EventArgs e)
        {

        }
    }
}
