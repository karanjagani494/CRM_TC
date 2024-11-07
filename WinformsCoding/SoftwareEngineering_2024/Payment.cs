namespace SoftwareEngineering_2024
{
    public partial class Payment : Form
    {

        public Payment(string selectedMembership)
        {
            InitializeComponent();
            FbLink.Click += Opener.OpenFacebook;
            GmapLink.Click += Opener.OpenGoogleMaps;
            IgLink.Click += Opener.OpenInstagram;

            // Display the selected membership to the user
        }

       

        private void ProceedTqBt_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(ThankYouForm));
        }

        private void PreviousPageBt_Click(object sender, EventArgs e)
        {
            Opener.GoBack(this);
        }
    }
}
