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
using MySql.Data.MySqlClient;


namespace SoftwareEngineering_2024
{
    public partial class UserBookingsForm : Form
    {
        private showTables showTables = new showTables();
        private LoginForm loginForm = new LoginForm();

        public UserBookingsForm()
        {
            InitializeComponent();
            FormOpener.OpenUserDashboardPages(HomeBt, MembershipsBt, EventsBt, MyBookingsBt, SpaceBt, QueryBt);
        }



        private void UserBookingsForm_Load(object sender, EventArgs e)
        {
            // Get the Member ID from the login form
            int? id = loginForm.Give_Id();

            // Check if the ID is null or not
            if (!id.HasValue)
            {
                MessageBox.Show("Unable to retrieve the Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // If no valid ID is found, exit the method
            }

            // Define the queries and add the @id placeholder
            string TodayBookingsQuery = @"
        SELECT 
            b.Booking_id AS `Booking ID`,
            e.event_date AS `Event Date`,
            e.event_name AS `Event Name`,
            e.space AS `Space`

        FROM 
            bookings AS b
        JOIN 
            events AS e ON b.event_id = e.event_id
        WHERE 
            b.member_id = @id
            AND e.event_date = CURDATE();";

            // Replace @id placeholder with actual Member ID in query
            TodayBookingsQuery = TodayBookingsQuery.Replace("@id", id.Value.ToString());

            // Execute the query and bind to the DataGridView
            showTables.GRIDVIEW(TodayBookingDg, TodayBookingsQuery);

            // Define and execute the future bookings query
            string FutureBookingsQuery = @"
        SELECT 
            b.Booking_id AS `Booking ID`,
            e.event_date AS `Event Date`,
            e.event_name AS `Event Name`,
            e.space AS `Space`
        FROM 
            bookings AS b
        JOIN 
            events AS e ON b.event_id = e.event_id
        WHERE 
            b.member_id = @id
            AND e.event_date > CURDATE();";

            // Replace @id with the actual Member ID
            FutureBookingsQuery = FutureBookingsQuery.Replace("@id", id.Value.ToString());
            showTables.GRIDVIEW(UpcomingBookingDg, FutureBookingsQuery);

            // Define and execute the past bookings query
            string PastBookingsQuery = @"
        SELECT 
            b.Booking_id AS `Booking ID`,
            e.event_date AS `Event Date`,
            e.event_name AS `Event Name`,
            e.space AS `Space`

        FROM 
            bookings AS b
        JOIN 
            events AS e ON b.event_id = e.event_id
        WHERE 
            b.member_id = @id
            AND e.event_date < CURDATE();";

            // Replace @id with the actual Member ID
            PastBookingsQuery = PastBookingsQuery.Replace("@id", id.Value.ToString());
            showTables.GRIDVIEW(PastBookingDg, PastBookingsQuery);
        }

        
    }
}
