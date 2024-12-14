using MySql.Data.MySqlClient;
using SoftwareEngineering_2024.DB_connect;
using SoftwareEngineering_2024.utilities;
using System.Data;
using System.Windows.Forms;


namespace SoftwareEngineering_2024
{
    public partial class UserBookingsForm : Form
    {
     

        public UserBookingsForm()
        {
            InitializeComponent();
            FormOpener.OpenUserDashboardPages(HomeBt, MembershipsBt, EventsBt, MyBookingsBt, SpaceBt, QueryBt);
        }

        LoginForm loginForm = new LoginForm();
        showTables showTables   = new showTables();


        private void UserBookingsForm_Load(object sender, EventArgs e)
        {
            int? id = loginForm.Give_Id();



            // Check if the ID is null or not
            if (!id.HasValue)
            {
                MessageBox.Show("Unable to retrieve the Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // If no valid ID is found, exit the method
            }

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
            TodayBookingsQuery = TodayBookingsQuery.Replace("@id", id.ToString());

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
            FutureBookingsQuery = FutureBookingsQuery.Replace("@id", id.ToString());
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

    //    // Queries with parameter placeholders
    //    string todayBookingsQuery = @"
    //SELECT 
    //    b.Booking_id AS `Booking ID`,
    //    e.event_date AS `Event Date`,
    //    e.event_name AS `Event Name`,
    //    e.space AS `Space`
    //FROM 
    //    bookings AS b
    //JOIN 
    //    events AS e ON b.event_id = e.event_id
    //WHERE 
    //    b.member_id = @id
    //    AND e.event_date = CURDATE();";

    //    string futureBookingsQuery = @"
    //SELECT 
    //    b.Booking_id AS `Booking ID`,
    //    e.event_date AS `Event Date`,
    //    e.event_name AS `Event Name`,
    //    e.space AS `Space`
    //FROM 
    //    bookings AS b
    //JOIN 
    //    events AS e ON b.event_id = e.event_id
    //WHERE 
    //    b.member_id = @id
    //    AND e.event_date > CURDATE();";

    //    string pastBookingsQuery = @"
    //SELECT 
    //    b.Booking_id AS `Booking ID`,
    //    e.event_date AS `Event Date`,
    //    e.event_name AS `Event Name`,
    //    e.space AS `Space`
    //FROM 
    //    bookings AS b
    //JOIN 
    //    events AS e ON b.event_id = e.event_id
    //WHERE 
    //    b.member_id = @id
    //    AND e.event_date < CURDATE();";

    //    // Execute queries and bind results
    //    ExecuteQuery(todayBookingsQuery, TodayBookingDg);
    //    ExecuteQuery(futureBookingsQuery, UpcomingBookingDg);
    //    ExecuteQuery(pastBookingsQuery, PastBookingDg);
}

//private void ExecuteQuery(string query, DataGridView dataGridView)
//{

//        using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
//        {
//            // Add parameter for @id
//            cmd.Parameters.AddWithValue("@id", id);

//            try
//            {
//            db.OpenConnection();

//            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
//                {
//                    DataTable dataTable = new DataTable();
//                    adapter.Fill(dataTable);

//                    // Bind the data to the DataGridView
//                    dataGridView.DataSource = dataTable;
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error executing query: {ex.Message}");
//                MessageBox.Show($"Error executing query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            finally
//            {
//            db.CloseConnection();
//        }

//    }
//}


























































































