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
            CvvTb = new MaskedTextBox();
            CountryPayLb = new Label();
            CountryPayTb = new MaskedTextBox();
            StatePayLb = new Label();
            StatePayTb = new MaskedTextBox();
            CityPayLb = new Label();
            CityPayTb = new MaskedTextBox();
            CityCodePayLb = new Label();
            CityCodePayTb = new MaskedTextBox();
            StreetPayLb = new Label();
            FlatNoPayLb = new Label();
            StreetPayTb = new MaskedTextBox();
            FlatnoPayTb = new MaskedTextBox();
            CardnumLb = new Label();
            CardnameLb = new Label();
            LastNameTb = new MaskedTextBox();
            CardNameTb = new MaskedTextBox();
            IgLink = new PictureBox();
            GmapLink = new PictureBox();
            FbLink = new PictureBox();
            LogInLink = new LinkLabel();
            ExDateLb = new Label();
            ProceedTqBt = new Button();
            ExDateTb = new MaskedTextBox();
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
            PreviousPageBt.Location = new Point(1558, 12);
            PreviousPageBt.Name = "PreviousPageBt";
            PreviousPageBt.Size = new Size(128, 29);
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
            TCLogo.Location = new Point(76, 76);
            TCLogo.Name = "TCLogo";
            TCLogo.Size = new Size(589, 556);
            TCLogo.TabIndex = 12;
            TCLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(CvvLb);
            panel1.Controls.Add(CvvTb);
            panel1.Controls.Add(CountryPayLb);
            panel1.Controls.Add(CountryPayTb);
            panel1.Controls.Add(StatePayLb);
            panel1.Controls.Add(StatePayTb);
            panel1.Controls.Add(CityPayLb);
            panel1.Controls.Add(CityPayTb);
            panel1.Controls.Add(CityCodePayLb);
            panel1.Controls.Add(CityCodePayTb);
            panel1.Controls.Add(StreetPayLb);
            panel1.Controls.Add(FlatNoPayLb);
            panel1.Controls.Add(StreetPayTb);
            panel1.Controls.Add(FlatnoPayTb);
            panel1.Controls.Add(CardnumLb);
            panel1.Controls.Add(CardnameLb);
            panel1.Controls.Add(LastNameTb);
            panel1.Controls.Add(CardNameTb);
            panel1.Controls.Add(IgLink);
            panel1.Controls.Add(GmapLink);
            panel1.Controls.Add(FbLink);
            panel1.Controls.Add(LogInLink);
            panel1.Controls.Add(ExDateLb);
            panel1.Controls.Add(ProceedTqBt);
            panel1.Controls.Add(ExDateTb);
            panel1.Controls.Add(WelcomeSignUp);
            panel1.Location = new Point(920, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 556);
            panel1.TabIndex = 14;
            // 
            // CvvLb
            // 
            CvvLb.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CvvLb.Location = new Point(528, 113);
            CvvLb.Name = "CvvLb";
            CvvLb.Size = new Size(76, 17);
            CvvLb.TabIndex = 29;
            CvvLb.Text = "CVV";
            // 
            // CvvTb
            // 
            CvvTb.Location = new Point(531, 133);
            CvvTb.Name = "CvvTb";
            CvvTb.Size = new Size(227, 27);
            CvvTb.TabIndex = 28;
            // 
            // CountryPayLb
            // 
            CountryPayLb.AutoSize = true;
            CountryPayLb.Location = new Point(22, 234);
            CountryPayLb.Name = "CountryPayLb";
            CountryPayLb.Size = new Size(60, 20);
            CountryPayLb.TabIndex = 27;
            CountryPayLb.Text = "Country";
            // 
            // CountryPayTb
            // 
            CountryPayTb.Location = new Point(22, 257);
            CountryPayTb.Name = "CountryPayTb";
            CountryPayTb.Size = new Size(226, 27);
            CountryPayTb.TabIndex = 26;
            // 
            // StatePayLb
            // 
            StatePayLb.AutoSize = true;
            StatePayLb.Location = new Point(531, 169);
            StatePayLb.Name = "StatePayLb";
            StatePayLb.Size = new Size(95, 20);
            StatePayLb.TabIndex = 23;
            StatePayLb.Text = "State/County";
            // 
            // StatePayTb
            // 
            StatePayTb.Location = new Point(531, 192);
            StatePayTb.Name = "StatePayTb";
            StatePayTb.Size = new Size(227, 27);
            StatePayTb.TabIndex = 22;
            // 
            // CityPayLb
            // 
            CityPayLb.AutoSize = true;
            CityPayLb.Location = new Point(283, 169);
            CityPayLb.Name = "CityPayLb";
            CityPayLb.Size = new Size(34, 20);
            CityPayLb.TabIndex = 21;
            CityPayLb.Text = "City";
            // 
            // CityPayTb
            // 
            CityPayTb.Location = new Point(275, 192);
            CityPayTb.Name = "CityPayTb";
            CityPayTb.Size = new Size(227, 27);
            CityPayTb.TabIndex = 20;
            // 
            // CityCodePayLb
            // 
            CityCodePayLb.AutoSize = true;
            CityCodePayLb.Location = new Point(531, 234);
            CityCodePayLb.Name = "CityCodePayLb";
            CityCodePayLb.Size = new Size(73, 20);
            CityCodePayLb.TabIndex = 19;
            CityCodePayLb.Text = "City Code";
            // 
            // CityCodePayTb
            // 
            CityCodePayTb.Location = new Point(531, 257);
            CityCodePayTb.Name = "CityCodePayTb";
            CityCodePayTb.Size = new Size(227, 27);
            CityCodePayTb.TabIndex = 18;
            // 
            // StreetPayLb
            // 
            StreetPayLb.AutoSize = true;
            StreetPayLb.Location = new Point(283, 234);
            StreetPayLb.Name = "StreetPayLb";
            StreetPayLb.Size = new Size(48, 20);
            StreetPayLb.TabIndex = 17;
            StreetPayLb.Text = "Street";
            // 
            // FlatNoPayLb
            // 
            FlatNoPayLb.AutoSize = true;
            FlatNoPayLb.Location = new Point(22, 169);
            FlatNoPayLb.Name = "FlatNoPayLb";
            FlatNoPayLb.Size = new Size(139, 20);
            FlatNoPayLb.TabIndex = 16;
            FlatNoPayLb.Text = "Flat/House Number";
            // 
            // StreetPayTb
            // 
            StreetPayTb.Location = new Point(275, 257);
            StreetPayTb.Name = "StreetPayTb";
            StreetPayTb.Size = new Size(227, 27);
            StreetPayTb.TabIndex = 15;
            // 
            // FlatnoPayTb
            // 
            FlatnoPayTb.Location = new Point(22, 192);
            FlatnoPayTb.Name = "FlatnoPayTb";
            FlatnoPayTb.Size = new Size(226, 27);
            FlatnoPayTb.TabIndex = 14;
            // 
            // CardnumLb
            // 
            CardnumLb.AutoSize = true;
            CardnumLb.Location = new Point(275, 110);
            CardnumLb.Name = "CardnumLb";
            CardnumLb.Size = new Size(98, 20);
            CardnumLb.TabIndex = 13;
            CardnumLb.Text = "Card Number";
            // 
            // CardnameLb
            // 
            CardnameLb.AutoSize = true;
            CardnameLb.Location = new Point(17, 110);
            CardnameLb.Name = "CardnameLb";
            CardnameLb.Size = new Size(127, 20);
            CardnameLb.TabIndex = 12;
            CardnameLb.Text = "Cardholder Name";
            // 
            // LastNameTb
            // 
            LastNameTb.Location = new Point(275, 133);
            LastNameTb.Name = "LastNameTb";
            LastNameTb.Size = new Size(227, 27);
            LastNameTb.TabIndex = 11;
            // 
            // CardNameTb
            // 
            CardNameTb.Location = new Point(22, 133);
            CardNameTb.Name = "CardNameTb";
            CardNameTb.Size = new Size(228, 27);
            CardNameTb.TabIndex = 10;
            // 
            // IgLink
            // 
            IgLink.BackgroundImage = (Image)resources.GetObject("IgLink.BackgroundImage");
            IgLink.BackgroundImageLayout = ImageLayout.Stretch;
            IgLink.Cursor = Cursors.Hand;
            IgLink.Location = new Point(542, 456);
            IgLink.Name = "IgLink";
            IgLink.Size = new Size(43, 43);
            IgLink.TabIndex = 9;
            IgLink.TabStop = false;
            // 
            // GmapLink
            // 
            GmapLink.BackgroundImage = Properties.Resources.Gmaps;
            GmapLink.BackgroundImageLayout = ImageLayout.Stretch;
            GmapLink.Cursor = Cursors.Hand;
            GmapLink.Location = new Point(370, 456);
            GmapLink.Name = "GmapLink";
            GmapLink.Size = new Size(43, 43);
            GmapLink.TabIndex = 8;
            GmapLink.TabStop = false;
            // 
            // FbLink
            // 
            FbLink.BackgroundImage = Properties.Resources.fb;
            FbLink.BackgroundImageLayout = ImageLayout.Stretch;
            FbLink.Cursor = Cursors.Hand;
            FbLink.Location = new Point(205, 456);
            FbLink.Name = "FbLink";
            FbLink.Size = new Size(43, 43);
            FbLink.TabIndex = 7;
            FbLink.TabStop = false;
            // 
            // LogInLink
            // 
            LogInLink.AutoSize = true;
            LogInLink.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInLink.Location = new Point(289, 523);
            LogInLink.Name = "LogInLink";
            LogInLink.Size = new Size(207, 23);
            LogInLink.TabIndex = 6;
            LogInLink.TabStop = true;
            LogInLink.Text = "Already a Member, Log In";
            // 
            // ExDateLb
            // 
            ExDateLb.AutoSize = true;
            ExDateLb.Location = new Point(21, 296);
            ExDateLb.Name = "ExDateLb";
            ExDateLb.Size = new Size(208, 20);
            ExDateLb.TabIndex = 4;
            ExDateLb.Text = "Expiry date(MM/YYYY Format)";
            // 
            // ProceedTqBt
            // 
            ProceedTqBt.AllowDrop = true;
            ProceedTqBt.BackColor = Color.IndianRed;
            ProceedTqBt.Location = new Point(289, 377);
            ProceedTqBt.Name = "ProceedTqBt";
            ProceedTqBt.Size = new Size(197, 57);
            ProceedTqBt.TabIndex = 3;
            ProceedTqBt.Text = "Proceed";
            ProceedTqBt.UseVisualStyleBackColor = false;
            ProceedTqBt.Click += ProceedTqBt_Click;
            // 
            // ExDateTb
            // 
            ExDateTb.Location = new Point(22, 319);
            ExDateTb.Name = "ExDateTb";
            ExDateTb.Size = new Size(226, 27);
            ExDateTb.TabIndex = 1;
            // 
            // WelcomeSignUp
            // 
            WelcomeSignUp.AutoSize = true;
            WelcomeSignUp.BackColor = Color.RosyBrown;
            WelcomeSignUp.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeSignUp.Location = new Point(217, 29);
            WelcomeSignUp.Name = "WelcomeSignUp";
            WelcomeSignUp.Size = new Size(358, 32);
            WelcomeSignUp.TabIndex = 0;
            WelcomeSignUp.Text = "Welcome to Together Culture";
            WelcomeSignUp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1777, 720);
            Controls.Add(panel1);
            Controls.Add(PreviousPageBt);
            Controls.Add(TCLogo);
            DoubleBuffered = true;
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
        private MaskedTextBox CvvTb;
        private Label CountryPayLb;
        private MaskedTextBox CountryPayTb;
        private Label StatePayLb;
        private MaskedTextBox StatePayTb;
        private Label CityPayLb;
        private MaskedTextBox CityPayTb;
        private Label CityCodePayLb;
        private MaskedTextBox CityCodePayTb;
        private Label StreetPayLb;
        private Label FlatNoPayLb;
        private MaskedTextBox StreetPayTb;
        private MaskedTextBox FlatnoPayTb;
        private Label CardnumLb;
        private Label CardnameLb;
        private MaskedTextBox LastNameTb;
        private MaskedTextBox CardNameTb;
        private PictureBox IgLink;
        private PictureBox GmapLink;
        private PictureBox FbLink;
        private LinkLabel LogInLink;
        private Label ExDateLb;
        private Button ProceedTqBt;
        private MaskedTextBox ExDateTb;
        private Label WelcomeSignUp;
    }
}