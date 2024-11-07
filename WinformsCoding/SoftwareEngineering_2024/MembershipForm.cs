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
    public partial class MembershipForm : Form
    {
        public MembershipForm()
        {
            InitializeComponent();
            CommCb.CheckedChanged += MembershipOption_CheckedChanged;
            WorkspaceFtCb.CheckedChanged += MembershipOption_CheckedChanged;
            CommKeysCb.CheckedChanged += MembershipOption_CheckedChanged;
            WorkspacePtCb.CheckedChanged += MembershipOption_CheckedChanged;
            FbLink.Click += Opener.OpenFacebook;
            GmapLink.Click += Opener.OpenGoogleMaps;
            IgLink.Click += Opener.OpenInstagram;
            LogInLink.Click += LogInLink_Click;

        }

        private void LogInLink_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(LoginForm));
        }


        private void MembershipOption_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkedBox && checkedBox.Checked)
            {
                // Uncheck all other checkboxes except the one that was just checked
                foreach (Control control in MembershipPanel.Controls)
                {
                    if (control is CheckBox checkBox && checkBox != checkedBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }


        }

        private void PreviousPageBt_Click(object sender, EventArgs e)
        {
            Opener.GoBack(this);
        }

        private void ProceedIntBt_Click(object sender, EventArgs e)
        {
            if (Opener.AreTextBoxesFilledAndCheckboxesChecked(this))
            {
                Opener.OpenForm(this, typeof(Payment));
            }

        }

        
    }
}
