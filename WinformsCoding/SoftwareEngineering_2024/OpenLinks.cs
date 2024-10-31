using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace SoftwareEngineering_2024
{
    public static class Opener
    {
        // Stack to track the navigation history
        private static Stack<Form> formStack = new Stack<Form>();

        // Method to open a new form and push the current one onto the stack
        public static void OpenForm(Form currentForm, Type newFormType)
        {
            formStack.Push(currentForm); // Store the current form
            Form newForm = (Form)Activator.CreateInstance(newFormType)!;
            newForm.Size = currentForm.Size;
            newForm.Location = currentForm.Location;
            currentForm.Hide();
            newForm.Show();
        }

        // Method to go back to the previous form
        public static void GoBack(Form currentForm)
        {
            if (formStack.Count > 0)
            {
                currentForm.Hide(); // Hide the current form
                Form previousForm = formStack.Pop(); // Get the previous form
                previousForm.Show(); // Show the previous form
            }
            else
            {
                MessageBox.Show("No previous form to return to.");
            }
        }

        // Method to open external links
        public static void OpenLink(string url)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link: " + ex.Message);
            }
        }

        // Specific methods for opening social media links
        public static void OpenFacebook(object sender, EventArgs e)
        {
            OpenLink("https://www.facebook.com/p/Together-Culture-CIC-100092890960501/");
        }

        public static void OpenGoogleMaps(object sender, EventArgs e)
        {
            OpenLink("https://maps.app.goo.gl/W6YYduRmSFShLCPu6");
        }

        public static void OpenInstagram(object sender, EventArgs e)
        {
            OpenLink("https://www.instagram.com/togetherculture.cambridge/");
        }

        
    }
}
