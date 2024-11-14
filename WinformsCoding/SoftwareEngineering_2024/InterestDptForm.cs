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
    public partial class InterestDptForm : Form
    {
        public InterestDptForm()
        {
            InitializeComponent();
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);
            LogInLink.Click += LogInLink_Click;
            ProceedTagBt.Click += ProceedTagBt_Click;


        }

        private void ProceedTagBt_Click(object? sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(TagsForm));
        }

        private void LogInLink_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(LoginForm));
        }

        private void PreviousPageBt_Click(object sender, EventArgs e)
        {
            Opener.GoBack(this);
        }
    }
}
