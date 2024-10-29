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
            FbLink.Click += Opener.OpenFacebook;
            GmapLink.Click += Opener.OpenGoogleMaps;
            IgLink.Click += Opener.OpenInstagram;
            LogInLink.Click += LogInLink_Click;
            ProceedTagBt.Click += ProceedIntBt_Click;
           

        }

        private void ProceedIntBt_Click(object? sender, EventArgs e)
        {
            Opener.OpenDialog(typeof(TagsForm), "tagForm", this);
            throw new NotImplementedException();
        }

        private void LogInLink_Click(object? sender, EventArgs e)
        {
            Opener.OpenDialog(typeof(LoginForm), "loginForm", this);
            throw new NotImplementedException();
        }



        
    }
}
