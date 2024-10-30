using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering_2024
{
    public static class Opener
    {
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

        public static void OpenDialog(Type formType, string formName, Form currentForm)
        {
            
            Form newForm = (Form)Activator.CreateInstance(formType);
            newForm.Name = formName;
            newForm.Size = currentForm.Size;
            newForm.Location = currentForm.Location;
            currentForm.Hide(); // Hide the current form
            newForm.ShowDialog(); // Show the new form as a dialog
        }
    }
}
