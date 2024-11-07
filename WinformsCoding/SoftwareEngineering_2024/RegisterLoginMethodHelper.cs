using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace SoftwareEngineering_2024
{
    public static class Opener
    {
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




        public static bool AreTextBoxesFilledAndCheckboxesChecked(Control parent)
        {
            bool isAnyCheckboxChecked = false; // Track if at least one checkbox is checked
            bool areTextBoxesFilled = true; // Track if all textboxes are filled
            bool hasTextBoxes = false; // Track if there are any textboxes
            bool hasCheckBoxes = false; // Track if there are any checkboxes

            foreach (Control control in parent.Controls)
            {
                // Check for TextBox and MaskedTextBox
                if (control is TextBox textBox)
                {
                    hasTextBoxes = true; // Mark that there are textboxes
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        areTextBoxesFilled = false; // At least one textbox is not filled
                    }
                }
                else if (control is MaskedTextBox maskedTextBox)
                {
                    hasTextBoxes = true; // Mark that there are textboxes
                    if (string.IsNullOrWhiteSpace(maskedTextBox.Text))
                    {
                        areTextBoxesFilled = false; // At least one masked textbox is not filled
                    }
                }

                // Check for CheckBox
                if (control is CheckBox checkBox)
                {
                    hasCheckBoxes = true; // Mark that there are checkboxes
                    if (checkBox.Checked)
                    {
                        isAnyCheckboxChecked = true; // At least one checkbox is checked
                    }
                }

                // Recursive call for nested controls
                if (control.HasChildren)
                {
                    if (!AreTextBoxesFilledAndCheckboxesChecked(control)) // Check nested controls
                        return false;
                }
            }

            // Verify if all textboxes are filled and at least one checkbox is checked
            if (hasTextBoxes && !areTextBoxesFilled)
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (hasCheckBoxes && !isAnyCheckboxChecked)
            {
                MessageBox.Show("Please check at least one checkbox before proceeding.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // All checks passed
        }        

        
    }
}
