namespace SoftwareEngineering_2024
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            PreviousPageBt = new Button();
            TCLogo = new PictureBox();
            panel1 = new Panel();
            CvvLb = new Label();
            Cvv_txt = new MaskedTextBox();
            CountryPayLb = new Label();
            Country_txt = new MaskedTextBox();
            StatePayLb = new Label();
            State_txt = new MaskedTextBox();
            CityPayLb = new Label();
            City_txt = new MaskedTextBox();
            CityCodePayLb = new Label();
            CityCode_txt = new MaskedTextBox();
            StreetPayLb = new Label();
            FlatNoPayLb = new Label();
            Street_txt = new MaskedTextBox();
            houseNo_txt = new MaskedTextBox();
            CardnumLb = new Label();
            CardnameLb = new Label();
            cardNo_txt = new MaskedTextBox();
            CardName_txt = new MaskedTextBox();
            IgLink = new PictureBox();
            GmapLink = new PictureBox();
            FbLink = new PictureBox();
            LogInLink = new LinkLabel();
            ExDateLb = new Label();
            ProceedTqBt = new Button();
            ExpDate_txt = new MaskedTextBox();
            WelcomeSignUp = new Label();
            ((System.ComponentModel.ISupportInitialize)TCLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).BeginInit();
            SuspendLayout();
            // 
            // PreviousPageBt
            // 
            PreviousPageBt.BackColor = Color.IndianRed;
            PreviousPageBt.ForeColor = Color.Black;
            PreviousPageBt.Location = new Point(1363, 9);
            PreviousPageBt.Margin = new Padding(3, 2, 3, 2);
            PreviousPageBt.Name = "PreviousPageBt";
            PreviousPageBt.Size = new Size(112, 22);
            PreviousPageBt.TabIndex = 13;
            PreviousPageBt.Text = "<- Previous Page";
            PreviousPageBt.UseVisualStyleBackColor = false;
            PreviousPageBt.Click += PreviousPageBt_Click;
            // 
            // TCLogo
            // 
            TCLogo.BackColor = Color.Transparent;
            TCLogo.BackgroundImage = (Image)resources.GetObject("TCLogo.BackgroundImage");
            TCLogo.BackgroundImageLayout = ImageLayout.Stretch;
            TCLogo.Location = new Point(66, 57);
            TCLogo.Margin = new Padding(3, 2, 3, 2);
            TCLogo.Name = "TCLogo";
            TCLogo.Size = new Size(416, 417);
            TCLogo.TabIndex = 12;
            TCLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(CvvLb);
            panel1.Controls.Add(Cvv_txt);
            panel1.Controls.Add(CountryPayLb);
            panel1.Controls.Add(Country_txt);
            panel1.Controls.Add(StatePayLb);
            panel1.Controls.Add(State_txt);
            panel1.Controls.Add(CityPayLb);
            panel1.Controls.Add(City_txt);
            panel1.Controls.Add(CityCodePayLb);
            panel1.Controls.Add(CityCode_txt);
            panel1.Controls.Add(StreetPayLb);
            panel1.Controls.Add(FlatNoPayLb);
            panel1.Controls.Add(Street_txt);
            panel1.Controls.Add(houseNo_txt);
            panel1.Controls.Add(CardnumLb);
            panel1.Controls.Add(CardnameLb);
            panel1.Controls.Add(cardNo_txt);
            panel1.Controls.Add(CardName_txt);
            panel1.Controls.Add(IgLink);
            panel1.Controls.Add(GmapLink);
            panel1.Controls.Add(FbLink);
            panel1.Controls.Add(LogInLink);
            panel1.Controls.Add(ExDateLb);
            panel1.Controls.Add(ProceedTqBt);
            panel1.Controls.Add(ExpDate_txt);
            panel1.Controls.Add(WelcomeSignUp);
            panel1.Location = new Point(805, 57);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 417);
            panel1.TabIndex = 14;
            // 
            // CvvLb
            // 
            CvvLb.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CvvLb.Location = new Point(462, 85);
            CvvLb.Name = "CvvLb";
            CvvLb.Size = new Size(66, 13);
            CvvLb.TabIndex = 29;
            CvvLb.Text = "CVV";
            // 
            // Cvv_txt
            // 
            Cvv_txt.Location = new Point(465, 100);
            Cvv_txt.Margin = new Padding(3, 2, 3, 2);
            Cvv_txt.Name = "Cvv_txt";
            Cvv_txt.Size = new Size(199, 23);
            Cvv_txt.TabIndex = 28;
            // 
            // CountryPayLb
            // 
            CountryPayLb.AutoSize = true;
            CountryPayLb.Location = new Point(19, 176);
            CountryPayLb.Name = "CountryPayLb";
            CountryPayLb.Size = new Size(50, 15);
            CountryPayLb.TabIndex = 27;
            CountryPayLb.Text = "Country";
            // 
            // Country_txt
            // 
            Country_txt.Location = new Point(19, 193);
            Country_txt.Margin = new Padding(3, 2, 3, 2);
            Country_txt.Name = "Country_txt";
            Country_txt.Size = new Size(198, 23);
            Country_txt.TabIndex = 26;
            // 
            // StatePayLb
            // 
            StatePayLb.AutoSize = true;
            StatePayLb.Location = new Point(465, 127);
            StatePayLb.Name = "StatePayLb";
            StatePayLb.Size = new Size(77, 15);
            StatePayLb.TabIndex = 23;
            StatePayLb.Text = "State/County";
            // 
            // State_txt
            // 
            State_txt.Location = new Point(465, 144);
            State_txt.Margin = new Padding(3, 2, 3, 2);
            State_txt.Name = "State_txt";
            State_txt.Size = new Size(199, 23);
            State_txt.TabIndex = 22;
            // 
            // CityPayLb
            // 
            CityPayLb.AutoSize = true;
            CityPayLb.Location = new Point(248, 127);
            CityPayLb.Name = "CityPayLb";
            CityPayLb.Size = new Size(28, 15);
            CityPayLb.TabIndex = 21;
            CityPayLb.Text = "City";
            // 
            // City_txt
            // 
            City_txt.Location = new Point(241, 144);
            City_txt.Margin = new Padding(3, 2, 3, 2);
            City_txt.Name = "City_txt";
            City_txt.Size = new Size(199, 23);
            City_txt.TabIndex = 20;
            // 
            // CityCodePayLb
            // 
            CityCodePayLb.AutoSize = true;
            CityCodePayLb.Location = new Point(465, 176);
            CityCodePayLb.Name = "CityCodePayLb";
            CityCodePayLb.Size = new Size(59, 15);
            CityCodePayLb.TabIndex = 19;
            CityCodePayLb.Text = "City Code";
            // 
            // CityCode_txt
            // 
            CityCode_txt.Location = new Point(465, 193);
            CityCode_txt.Margin = new Padding(3, 2, 3, 2);
            CityCode_txt.Name = "CityCode_txt";
            CityCode_txt.Size = new Size(199, 23);
            CityCode_txt.TabIndex = 18;
            // 
            // StreetPayLb
            // 
            StreetPayLb.AutoSize = true;
            StreetPayLb.Location = new Point(248, 176);
            StreetPayLb.Name = "StreetPayLb";
            StreetPayLb.Size = new Size(37, 15);
            StreetPayLb.TabIndex = 17;
            StreetPayLb.Text = "Street";
            // 
            // FlatNoPayLb
            // 
            FlatNoPayLb.AutoSize = true;
            FlatNoPayLb.Location = new Point(19, 127);
            FlatNoPayLb.Name = "FlatNoPayLb";
            FlatNoPayLb.Size = new Size(112, 15);
            FlatNoPayLb.TabIndex = 16;
            FlatNoPayLb.Text = "Flat/House Number";
            // 
            // Street_txt
            // 
            Street_txt.Location = new Point(241, 193);
            Street_txt.Margin = new Padding(3, 2, 3, 2);
            Street_txt.Name = "Street_txt";
            Street_txt.Size = new Size(199, 23);
            Street_txt.TabIndex = 15;
            // 
            // houseNo_txt
            // 
            houseNo_txt.Location = new Point(19, 144);
            houseNo_txt.Margin = new Padding(3, 2, 3, 2);
            houseNo_txt.Name = "houseNo_txt";
            houseNo_txt.Size = new Size(198, 23);
            houseNo_txt.TabIndex = 14;
            // 
            // CardnumLb
            // 
            CardnumLb.AutoSize = true;
            CardnumLb.Location = new Point(241, 82);
            CardnumLb.Name = "CardnumLb";
            CardnumLb.Size = new Size(79, 15);
            CardnumLb.TabIndex = 13;
            CardnumLb.Text = "Card Number";
            // 
            // CardnameLb
            // 
            CardnameLb.AutoSize = true;
            CardnameLb.Location = new Point(15, 82);
            CardnameLb.Name = "CardnameLb";
            CardnameLb.Size = new Size(101, 15);
            CardnameLb.TabIndex = 12;
            CardnameLb.Text = "Cardholder Name";
            // 
            // cardNo_txt
            // 
            cardNo_txt.Location = new Point(241, 100);
            cardNo_txt.Margin = new Padding(3, 2, 3, 2);
            cardNo_txt.Name = "cardNo_txt";
            cardNo_txt.Size = new Size(199, 23);
            cardNo_txt.TabIndex = 11;
            // 
            // CardName_txt
            // 
            CardName_txt.Location = new Point(19, 100);
            CardName_txt.Margin = new Padding(3, 2, 3, 2);
            CardName_txt.Name = "CardName_txt";
            CardName_txt.Size = new Size(200, 23);
            CardName_txt.TabIndex = 10;
            // 
            // IgLink
            // 
            IgLink.BackgroundImage = (Image)resources.GetObject("IgLink.BackgroundImage");
            IgLink.BackgroundImageLayout = ImageLayout.Stretch;
            IgLink.Cursor = Cursors.Hand;
            IgLink.Location = new Point(474, 342);
            IgLink.Margin = new Padding(3, 2, 3, 2);
            IgLink.Name = "IgLink";
            IgLink.Size = new Size(38, 32);
            IgLink.TabIndex = 9;
            IgLink.TabStop = false;
            // 
            // GmapLink
            // 
            GmapLink.BackgroundImage = Properties.Resources.Gmaps;
            GmapLink.BackgroundImageLayout = ImageLayout.Stretch;
            GmapLink.Cursor = Cursors.Hand;
            GmapLink.Location = new Point(324, 342);
            GmapLink.Margin = new Padding(3, 2, 3, 2);
            GmapLink.Name = "GmapLink";
            GmapLink.Size = new Size(38, 32);
            GmapLink.TabIndex = 8;
            GmapLink.TabStop = false;
            // 
            // FbLink
            // 
            FbLink.BackgroundImage = Properties.Resources.fb;
            FbLink.BackgroundImageLayout = ImageLayout.Stretch;
            FbLink.Cursor = Cursors.Hand;
            FbLink.Location = new Point(179, 342);
            FbLink.Margin = new Padding(3, 2, 3, 2);
            FbLink.Name = "FbLink";
            FbLink.Size = new Size(38, 32);
            FbLink.TabIndex = 7;
            FbLink.TabStop = false;
            // 
            // LogInLink
            // 
            LogInLink.AutoSize = true;
            LogInLink.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInLink.Location = new Point(253, 392);
            LogInLink.Name = "LogInLink";
            LogInLink.Size = new Size(168, 19);
            LogInLink.TabIndex = 6;
            LogInLink.TabStop = true;
            LogInLink.Text = "Already a Member, Log In";
            // 
            // ExDateLb
            // 
            ExDateLb.AutoSize = true;
            ExDateLb.Location = new Point(18, 222);
            ExDateLb.Name = "ExDateLb";
            ExDateLb.Size = new Size(168, 15);
            ExDateLb.TabIndex = 4;
            ExDateLb.Text = "Expiry date(MM/YYYY Format)";
            // 
            // ProceedTqBt
            // 
            ProceedTqBt.AllowDrop = true;
            ProceedTqBt.BackColor = Color.IndianRed;
            ProceedTqBt.Location = new Point(253, 283);
            ProceedTqBt.Margin = new Padding(3, 2, 3, 2);
            ProceedTqBt.Name = "ProceedTqBt";
            ProceedTqBt.Size = new Size(172, 43);
            ProceedTqBt.TabIndex = 3;
            ProceedTqBt.Text = "Proceed";
            ProceedTqBt.UseVisualStyleBackColor = false;
            ProceedTqBt.Click += ProceedTqBt_Click;
            // 
            // ExpDate_txt
            // 
            ExpDate_txt.Location = new Point(19, 239);
            ExpDate_txt.Margin = new Padding(3, 2, 3, 2);
            ExpDate_txt.Name = "ExpDate_txt";
            ExpDate_txt.Size = new Size(198, 23);
            ExpDate_txt.TabIndex = 1;
            // 
            // WelcomeSignUp
            // 
            WelcomeSignUp.AutoSize = true;
            WelcomeSignUp.BackColor = Color.RosyBrown;
            WelcomeSignUp.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeSignUp.Location = new Point(190, 22);
            WelcomeSignUp.Name = "WelcomeSignUp";
            WelcomeSignUp.Size = new Size(289, 25);
            WelcomeSignUp.TabIndex = 0;
            WelcomeSignUp.Text = "Welcome to Together Culture";
            WelcomeSignUp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 540);
            Controls.Add(panel1);
            Controls.Add(PreviousPageBt);
            Controls.Add(TCLogo);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Payment";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)TCLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button PreviousPageBt;
        private PictureBox TCLogo;
        private Panel panel1;
        private Label CvvLb;
        private MaskedTextBox Cvv_txt;
        private Label CountryPayLb;
        private MaskedTextBox Country_txt;
        private Label StatePayLb;
        private MaskedTextBox State_txt;
        private Label CityPayLb;
        private MaskedTextBox City_txt;
        private Label CityCodePayLb;
        private MaskedTextBox CityCode_txt;
        private Label StreetPayLb;
        private Label FlatNoPayLb;
        private MaskedTextBox Street_txt;
        private MaskedTextBox houseNo_txt;
        private Label CardnumLb;
        private Label CardnameLb;
        private MaskedTextBox cardNo_txt;
        private MaskedTextBox CardName_txt;
        private PictureBox IgLink;
        private PictureBox GmapLink;
        private PictureBox FbLink;
        private LinkLabel LogInLink;
        private Label ExDateLb;
        private Button ProceedTqBt;
        private MaskedTextBox ExpDate_txt;
        private Label WelcomeSignUp;
    }
}