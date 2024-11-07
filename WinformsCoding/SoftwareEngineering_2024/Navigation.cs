using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering_2024
{
    public static class FormOpener
    {
        public static void OpenUserHomeForm(object sender, EventArgs e)
        {
            OpenUserForm((Form)((Control)sender).FindForm(), typeof(UserHomeForm1));
        }

        public static void OpenUserMembershipForm(object sender, EventArgs e)
        {
            OpenUserForm((Form)((Control)sender).FindForm(), typeof(UserMembershipsForm));
        }


        // You can add more methods for each form type
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
