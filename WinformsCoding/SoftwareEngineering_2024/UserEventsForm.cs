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
    public partial class UserEventsForm : Form
    {
        public UserEventsForm()
        {
            InitializeComponent();
            FormOpener.OpenUserDashboardPages(HomeBt, MembershipsBt, EventsBt, MyBookingsBt, SpaceBt, QueryBt);
        }

        private void ViewEventsLinkBt_Click(object sender, EventArgs e)
        {
            Opener.OpenLink("https://www.togetherculture.com/events");
        }
    }
}
