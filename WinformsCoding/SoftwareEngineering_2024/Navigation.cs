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
       


  
        private static void OpenUserForm(Form currentForm, Type newFormType)
        {
            Form newForm = (Form)Activator.CreateInstance(newFormType)!;
            newForm.Size = currentForm.Size;
            newForm.Location = currentForm.Location;
            currentForm.Hide(); // Hide the current form
            newForm.Show(); // Show the new form
        }
    }

}
