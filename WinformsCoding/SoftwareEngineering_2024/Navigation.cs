using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering_2024
{
    public static class FormOpener
    {
        public static void OpenUserDashboardPages(Button Home, Button Membership, Button Events, Button Bookings, Button Workspaces, Button Queries) 
        {
            Home.Click += (sender, e) => OpenUserForm((Form)((Control)sender).FindForm(), typeof(UserHomeForm1));
            Membership.Click += (sender, e) => OpenUserForm((Form)((Control)sender).FindForm(), typeof(UserMembershipsForm));
            Events.Click += (sender, e) => OpenUserForm((Form)((Control)sender).FindForm(), typeof(UserEventsForm));
            Bookings.Click += (sender, e) => OpenUserForm((Form)((Control)sender).FindForm(), typeof(UserBookingsForm));
            Workspaces.Click += (sender, e) => OpenUserForm((Form)((Control)sender).FindForm(), typeof(UserWorkspacesForm));
            Queries.Click += (sender, e) => OpenUserForm((Form)((Control)sender).FindForm(), typeof(UserQueriesFeedbackForm));
        }

        public static void OpenAdminDashboardPages(Button Home, Button Members, Button Events, Button Bookings, Button Engagement, Button Queries, Button Attendance)
        {
            Home.Click += (sender, e) => OpenUserForm((Form)((Control)sender).FindForm(), typeof(AdminHomeForm));
            Members.Click += (sender, e) => OpenUserForm((Form)((Control)sender).FindForm(), typeof(AdminMembersForm));
            Events.Click += (sender, e) => OpenUserForm((Form)((Control)sender).FindForm(), typeof(AdminEventsForm));
            Bookings.Click += (sender, e) => OpenUserForm((Form)((Control)sender).FindForm(), typeof(AdminBookingsForm));
            Engagement.Click += (sender, e) => OpenUserForm((Form)((Control)sender).FindForm(), typeof(AdminEngagementForm));
            Queries.Click += (sender, e) => OpenUserForm((Form)((Control)sender).FindForm(), typeof(AdminQueriesFeedbackForm));
            Attendance.Click += (sender, e) => OpenUserForm((Form)((Control)sender).FindForm(), typeof(Attendance_Log));
        }




        public static void OpenUserForm(Form currentForm, Type newFormType)
        {
            Form newForm = (Form)Activator.CreateInstance(newFormType)!;
            newForm.Size = currentForm.Size;
            newForm.Location = currentForm.Location;
            currentForm.Hide(); // Hide the current form
            newForm.Show(); // Show the new form
        }
    }

}
