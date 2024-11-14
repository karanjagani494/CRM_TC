namespace SoftwareEngineering_2024
{
    public partial class Payment : Form
    {

        public Payment()
        {
            InitializeComponent();
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);
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
