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
    public partial class UserMembershipsForm : Form
    {
        public UserMembershipsForm()
        {
            InitializeComponent();
            HomeBt.Click += FormOpener.OpenUserHomeForm;
            MembershipsBt.Click += FormOpener.OpenUserMembershipForm;

        }

        private void ChangeMembershipBt_Click(object sender, EventArgs e)
        {
            // Open the MembershipForm to allow the user to change their membership
            MembershipForm membershipForm = new MembershipForm
            {
                IsChangeMembershipMode = true // A property to indicate change mode
            };

            if (membershipForm.ShowDialog() == DialogResult.OK)
            {
                // Handle the selected membership, which can be retrieved from MembershipForm
                string selectedMembership = membershipForm.SelectedMembership;

                // Optionally, navigate to the checkout form
                Payment paymentCM = new Payment(selectedMembership);
                paymentCM.ShowDialog();
            }
        }


    }
}
