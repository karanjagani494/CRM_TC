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
            CityPayLb = new Label();
            CityPayTb = new MaskedTextBox();
            FlatNoPayLb = new Label();
            FlatnoPayTb = new MaskedTextBox();
            CardnumLb = new Label();
            CardnameLb = new Label();
            LastNameTb = new MaskedTextBox();
            CardNameTb = new MaskedTextBox();
            IgLink = new PictureBox();
            GmapLink = new PictureBox();
            FbLink = new PictureBox();
            LogInLink = new LinkLabel();
            ProceedIntBt = new Button();
            WelcomeSignUp = new Label();
            ExDateLb = new Label();
            ExDateTb = new MaskedTextBox();
            CityCodePayTb = new MaskedTextBox();
            CityCodePayLb = new Label();
            StreetPayTb = new MaskedTextBox();
            StreetPayLb = new Label();
            CountryPayTb = new MaskedTextBox();
            CountryPayLb = new Label();
            StatePayTb = new MaskedTextBox();
            StatePayLb = new Label();
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
            // 
            // TCLogo
            // 
            TCLogo.BackColor = Color.Transparent;
            TCLogo.BackgroundImage = (Image)resources.GetObject("TCLogo.BackgroundImage");
            TCLogo.BackgroundImageLayout = ImageLayout.Stretch;
            TCLogo.Location = new Point(76, 76);
            TCLogo.Name = "TCLogo";
            TCLogo.Size = new Size(558, 556);
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
            panel1.Controls.Add(ProceedIntBt);
            panel1.Controls.Add(ExDateTb);
            panel1.Controls.Add(WelcomeSignUp);
            panel1.Location = new Point(903, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 556);
            panel1.TabIndex = 14;
            // 
            // CvvLb
            // 
            CvvLb.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CvvLb.Location = new Point(506, 117);
            CvvLb.Name = "CvvLb";
            CvvLb.Size = new Size(76, 17);
            CvvLb.TabIndex = 29;
            CvvLb.Text = "CVV";
            // 
            // CvvTb
            // 
            CvvTb.Location = new Point(506, 137);
            CvvTb.Name = "CvvTb";
            CvvTb.Size = new Size(282, 27);
            CvvTb.TabIndex = 28;
            // 
            // CityPayLb
            // 
            CityPayLb.AutoSize = true;
            CityPayLb.Location = new Point(266, 173);
            CityPayLb.Name = "CityPayLb";
            CityPayLb.Size = new Size(34, 20);
            CityPayLb.TabIndex = 21;
            CityPayLb.Text = "City";
            // 
            // CityPayTb
            // 
            CityPayTb.Location = new Point(266, 196);
            CityPayTb.Name = "CityPayTb";
            CityPayTb.Size = new Size(242, 27);
            CityPayTb.TabIndex = 20;
            // 
            // FlatNoPayLb
            // 
            FlatNoPayLb.AutoSize = true;
            FlatNoPayLb.Location = new Point(5, 173);
            FlatNoPayLb.Name = "FlatNoPayLb";
            FlatNoPayLb.Size = new Size(139, 20);
            FlatNoPayLb.TabIndex = 16;
            FlatNoPayLb.Text = "Flat/House Number";
            // 
            // FlatnoPayTb
            // 
            FlatnoPayTb.Location = new Point(5, 196);
            FlatnoPayTb.Name = "FlatnoPayTb";
            FlatnoPayTb.Size = new Size(256, 27);
            FlatnoPayTb.TabIndex = 14;
            // 
            // CardnumLb
            // 
            CardnumLb.AutoSize = true;
            CardnumLb.Location = new Point(258, 114);
            CardnumLb.Name = "CardnumLb";
            CardnumLb.Size = new Size(98, 20);
            CardnumLb.TabIndex = 13;
            CardnumLb.Text = "Card Number";
            // 
            // CardnameLb
            // 
            CardnameLb.AutoSize = true;
            CardnameLb.Location = new Point(0, 114);
            CardnameLb.Name = "CardnameLb";
            CardnameLb.Size = new Size(127, 20);
            CardnameLb.TabIndex = 12;
            CardnameLb.Text = "Cardholder Name";
            // 
            // LastNameTb
            // 
            LastNameTb.Location = new Point(258, 137);
            LastNameTb.Name = "LastNameTb";
            LastNameTb.Size = new Size(242, 27);
            LastNameTb.TabIndex = 11;
            // 
            // CardNameTb
            // 
            CardNameTb.Location = new Point(0, 137);
            CardNameTb.Name = "CardNameTb";
            CardNameTb.Size = new Size(255, 27);
            CardNameTb.TabIndex = 10;
            // 
            // IgLink
            // 
            IgLink.BackgroundImage = (Image)resources.GetObject("IgLink.BackgroundImage");
            IgLink.BackgroundImageLayout = ImageLayout.Stretch;
            IgLink.Cursor = Cursors.Hand;
            IgLink.Location = new Point(557, 445);
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
            GmapLink.Location = new Point(385, 445);
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
            FbLink.Location = new Point(220, 445);
            FbLink.Name = "FbLink";
            FbLink.Size = new Size(43, 43);
            FbLink.TabIndex = 7;
            FbLink.TabStop = false;
            // 
            // LogInLink
            // 
            LogInLink.AutoSize = true;
            LogInLink.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInLink.Location = new Point(304, 512);
            LogInLink.Name = "LogInLink";
            LogInLink.Size = new Size(207, 23);
            LogInLink.TabIndex = 6;
            LogInLink.TabStop = true;
            LogInLink.Text = "Already a Member, Log In";
            // 
            // ProceedIntBt
            // 
            ProceedIntBt.BackColor = Color.IndianRed;
            ProceedIntBt.Location = new Point(303, 372);
            ProceedIntBt.Name = "ProceedIntBt";
            ProceedIntBt.Size = new Size(197, 57);
            ProceedIntBt.TabIndex = 3;
            ProceedIntBt.Text = "Proceed";
            ProceedIntBt.UseVisualStyleBackColor = false;
            ProceedIntBt.Click += ProceedIntBt_Click;
            // 
            // WelcomeSignUp
            // 
            WelcomeSignUp.AutoSize = true;
            WelcomeSignUp.BackColor = Color.RosyBrown;
            WelcomeSignUp.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeSignUp.Location = new Point(237, 29);
            WelcomeSignUp.Name = "WelcomeSignUp";
            WelcomeSignUp.Size = new Size(358, 32);
            WelcomeSignUp.TabIndex = 0;
            WelcomeSignUp.Text = "Welcome to Together Culture";
            WelcomeSignUp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ExDateLb
            // 
            ExDateLb.AutoSize = true;
            ExDateLb.Location = new Point(4, 300);
            ExDateLb.Name = "ExDateLb";
            ExDateLb.Size = new Size(208, 20);
            ExDateLb.TabIndex = 4;
            ExDateLb.Text = "Expiry date(MM/YYYY Format)";
            // 
            // ExDateTb
            // 
            ExDateTb.Location = new Point(5, 323);
            ExDateTb.Name = "ExDateTb";
            ExDateTb.Size = new Size(258, 27);
            ExDateTb.TabIndex = 1;
            // 
            // CityCodePayTb
            // 
            CityCodePayTb.Location = new Point(514, 261);
            CityCodePayTb.Name = "CityCodePayTb";
            CityCodePayTb.Size = new Size(269, 27);
            CityCodePayTb.TabIndex = 18;
            // 
            // CityCodePayLb
            // 
            CityCodePayLb.AutoSize = true;
            CityCodePayLb.Location = new Point(514, 238);
            CityCodePayLb.Name = "CityCodePayLb";
            CityCodePayLb.Size = new Size(73, 20);
            CityCodePayLb.TabIndex = 19;
            CityCodePayLb.Text = "City Code";
            // 
            // StreetPayTb
            // 
            StreetPayTb.Location = new Point(266, 261);
            StreetPayTb.Name = "StreetPayTb";
            StreetPayTb.Size = new Size(242, 27);
            StreetPayTb.TabIndex = 15;
            // 
            // StreetPayLb
            // 
            StreetPayLb.AutoSize = true;
            StreetPayLb.Location = new Point(266, 238);
            StreetPayLb.Name = "StreetPayLb";
            StreetPayLb.Size = new Size(48, 20);
            StreetPayLb.TabIndex = 17;
            StreetPayLb.Text = "Street";
            // 
            // CountryPayTb
            // 
            CountryPayTb.Location = new Point(5, 261);
            CountryPayTb.Name = "CountryPayTb";
            CountryPayTb.Size = new Size(256, 27);
            CountryPayTb.TabIndex = 26;
            // 
            // CountryPayLb
            // 
            CountryPayLb.AutoSize = true;
            CountryPayLb.Location = new Point(5, 238);
            CountryPayLb.Name = "CountryPayLb";
            CountryPayLb.Size = new Size(60, 20);
            CountryPayLb.TabIndex = 27;
            CountryPayLb.Text = "Country";
            // 
            // StatePayTb
            // 
            StatePayTb.Location = new Point(514, 196);
            StatePayTb.Name = "StatePayTb";
            StatePayTb.Size = new Size(269, 27);
            StatePayTb.TabIndex = 22;
            // 
            // StatePayLb
            // 
            StatePayLb.AutoSize = true;
            StatePayLb.Location = new Point(514, 173);
            StatePayLb.Name = "StatePayLb";
            StatePayLb.Size = new Size(95, 20);
            StatePayLb.TabIndex = 23;
            StatePayLb.Text = "State/County";
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
        private Button ProceedIntBt;
        private MaskedTextBox ExDateTb;
        private Label WelcomeSignUp;
    }
}