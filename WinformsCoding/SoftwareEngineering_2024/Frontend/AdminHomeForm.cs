using LiveCharts.WinForms;
using LiveCharts.Wpf;
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
using System.Windows.Forms.DataVisualization.Charting;


namespace SoftwareEngineering_2024
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
            FormOpener.OpenAdminDashboardPages(AdminHomeBt, MembersBt, StaffEventsBt, AdminBookingsBt, EngagementBt, AdminQueryBt, Attendance_log_bt);
        }

        private DataVisualization dataVisualization = new DataVisualization();


        private void LogOutBt_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(Admin_log_in));
        }

        private void AdminHomeLoad(object sender, EventArgs e)
        {
            // SQL query to get the count of people per space (for pie chart)
            string sqlQuery1 = "SELECT space_name, COUNT(*) FROM attendance_log GROUP BY space_name;";

            // SQL query to get the count of people per membership type (for bar chart)
            string sqlQuery2 = "SELECT membership_id, COUNT(*) FROM members GROUP BY membership_id;";

            // Generate the pie chart for space attendance
            bool success = dataVisualization.GenerateChart(DiagramA, sqlQuery1, SeriesChartType.Pie, "Space Attendance", "", "");

            // Generate the bar chart for membership types
            bool success2 = dataVisualization.GenerateChart(DiagramB, sqlQuery2, SeriesChartType.Pie, "Membership Types", "", "");

            // Check if pie chart generation was successful
            if (!success)
            {
                MessageBox.Show("Error generating the pie chart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Check if bar chart generation was successful
            if (!success2)
            {
                MessageBox.Show("Error generating the bar chart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DiagramA_Click(object sender, EventArgs e)
        {

        }
    }
}
