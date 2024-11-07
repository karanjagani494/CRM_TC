
namespace SoftwareEngineering_2024
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            TCLogo = new PictureBox();
            panel1 = new Panel();
            PhoneNoLb = new Label();
            PhoneNoTb = new MaskedTextBox();
            CountryLb = new Label();
            CountryTb = new MaskedTextBox();
            RetypePasswordLb = new Label();
            maskedTextBox3 = new MaskedTextBox();
            StateLb = new Label();
            StateTb = new MaskedTextBox();
            CityLb = new Label();
            CityTb = new MaskedTextBox();
            CityCodeLb = new Label();
            CityCodeTb = new MaskedTextBox();
            StreetLb = new Label();
            FlatNoLb = new Label();
            StreetTb = new MaskedTextBox();
            FlatnoTb = new MaskedTextBox();
            LnameLb = new Label();
            FnameLb = new Label();
            LastNameTb = new MaskedTextBox();
            FirstNameTb = new MaskedTextBox();
            IgLink = new PictureBox();
            GmapLink = new PictureBox();
            FbLink = new PictureBox();
            LogInLink = new LinkLabel();
            PasswordSuLb = new Label();
            EmailSuLb = new Label();
            ProceedIntBt = new Button();
            PasswordSuTb = new MaskedTextBox();
            EmailSuTb = new MaskedTextBox();
            WelcomeSignUp = new Label();
            PreviousPageBt = new Button();
            ((System.ComponentModel.ISupportInitialize)TCLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).BeginInit();
            SuspendLayout();
            // 
            // TCLogo
            // 
            TCLogo.BackColor = Color.Transparent;
            TCLogo.BackgroundImage = (Image)resources.GetObject("TCLogo.BackgroundImage");
            TCLogo.BackgroundImageLayout = ImageLayout.Stretch;
            TCLogo.Location = new Point(69, 125);
            TCLogo.Name = "TCLogo";
            TCLogo.Size = new Size(558, 556);
            TCLogo.TabIndex = 1;
            TCLogo.TabStop = false;
            TCLogo.Click += TCLogo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(PhoneNoLb);
            panel1.Controls.Add(PhoneNoTb);
            panel1.Controls.Add(CountryLb);
            panel1.Controls.Add(CountryTb);
            panel1.Controls.Add(RetypePasswordLb);
            panel1.Controls.Add(maskedTextBox3);
            panel1.Controls.Add(StateLb);
            panel1.Controls.Add(StateTb);
            panel1.Controls.Add(CityLb);
            panel1.Controls.Add(CityTb);
            panel1.Controls.Add(CityCodeLb);
            panel1.Controls.Add(CityCodeTb);
            panel1.Controls.Add(StreetLb);
            panel1.Controls.Add(FlatNoLb);
            panel1.Controls.Add(StreetTb);
            panel1.Controls.Add(FlatnoTb);
            panel1.Controls.Add(LnameLb);
            panel1.Controls.Add(FnameLb);
            panel1.Controls.Add(LastNameTb);
            panel1.Controls.Add(FirstNameTb);
            panel1.Controls.Add(IgLink);
            panel1.Controls.Add(GmapLink);
            panel1.Controls.Add(FbLink);
            panel1.Controls.Add(LogInLink);
            panel1.Controls.Add(PasswordSuLb);
            panel1.Controls.Add(EmailSuLb);
            panel1.Controls.Add(ProceedIntBt);
            panel1.Controls.Add(PasswordSuTb);
            panel1.Controls.Add(EmailSuTb);
            panel1.Controls.Add(WelcomeSignUp);
            panel1.Location = new Point(926, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 556);
            panel1.TabIndex = 2;
            // 
            // PhoneNoLb
            // 
            PhoneNoLb.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneNoLb.Location = new Point(497, 117);
            PhoneNoLb.Name = "PhoneNoLb";
            PhoneNoLb.Size = new Size(294, 17);
            PhoneNoLb.TabIndex = 29;
            PhoneNoLb.Text = "Phone Number{Add Country Code, ex: +44 788..}";
            // 
            // PhoneNoTb
            // 
            PhoneNoTb.Location = new Point(506, 137);
            PhoneNoTb.Name = "PhoneNoTb";
            PhoneNoTb.Size = new Size(282, 27);
            PhoneNoTb.TabIndex = 28;
            // 
            // CountryLb
            // 
            CountryLb.AutoSize = true;
            CountryLb.Location = new Point(5, 238);
            CountryLb.Name = "CountryLb";
            CountryLb.Size = new Size(60, 20);
            CountryLb.TabIndex = 27;
            CountryLb.Text = "Country";
            // 
            // CountryTb
            // 
            CountryTb.Location = new Point(5, 261);
            CountryTb.Name = "CountryTb";
            CountryTb.Size = new Size(256, 27);
            CountryTb.TabIndex = 26;
            // 
            // RetypePasswordLb
            // 
            RetypePasswordLb.AutoSize = true;
            RetypePasswordLb.Location = new Point(514, 300);
            RetypePasswordLb.Name = "RetypePasswordLb";
            RetypePasswordLb.Size = new Size(120, 20);
            RetypePasswordLb.TabIndex = 25;
            RetypePasswordLb.Text = "Retype Password";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(514, 323);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(269, 27);
            maskedTextBox3.TabIndex = 24;
            // 
            // StateLb
            // 
            StateLb.AutoSize = true;
            StateLb.Location = new Point(514, 173);
            StateLb.Name = "StateLb";
            StateLb.Size = new Size(95, 20);
            StateLb.TabIndex = 23;
            StateLb.Text = "State/County";
            // 
            // StateTb
            // 
            StateTb.Location = new Point(514, 196);
            StateTb.Name = "StateTb";
            StateTb.Size = new Size(269, 27);
            StateTb.TabIndex = 22;
            // 
            // CityLb
            // 
            CityLb.AutoSize = true;
            CityLb.Location = new Point(266, 173);
            CityLb.Name = "CityLb";
            CityLb.Size = new Size(34, 20);
            CityLb.TabIndex = 21;
            CityLb.Text = "City";
            // 
            // CityTb
            // 
            CityTb.Location = new Point(266, 196);
            CityTb.Name = "CityTb";
            CityTb.Size = new Size(242, 27);
            CityTb.TabIndex = 20;
            // 
            // CityCodeLb
            // 
            CityCodeLb.AutoSize = true;
            CityCodeLb.Location = new Point(514, 238);
            CityCodeLb.Name = "CityCodeLb";
            CityCodeLb.Size = new Size(73, 20);
            CityCodeLb.TabIndex = 19;
            CityCodeLb.Text = "City Code";
            // 
            // CityCodeTb
            // 
            CityCodeTb.Location = new Point(514, 261);
            CityCodeTb.Name = "CityCodeTb";
            CityCodeTb.Size = new Size(269, 27);
            CityCodeTb.TabIndex = 18;
            // 
            // StreetLb
            // 
            StreetLb.AutoSize = true;
            StreetLb.Location = new Point(266, 238);
            StreetLb.Name = "StreetLb";
            StreetLb.Size = new Size(48, 20);
            StreetLb.TabIndex = 17;
            StreetLb.Text = "Street";
            // 
            // FlatNoLb
            // 
            FlatNoLb.AutoSize = true;
            FlatNoLb.Location = new Point(5, 173);
            FlatNoLb.Name = "FlatNoLb";
            FlatNoLb.Size = new Size(139, 20);
            FlatNoLb.TabIndex = 16;
            FlatNoLb.Text = "Flat/House Number";
            // 
            // StreetTb
            // 
            StreetTb.Location = new Point(266, 261);
            StreetTb.Name = "StreetTb";
            StreetTb.Size = new Size(242, 27);
            StreetTb.TabIndex = 15;
            // 
            // FlatnoTb
            // 
            FlatnoTb.Location = new Point(5, 196);
            FlatnoTb.Name = "FlatnoTb";
            FlatnoTb.Size = new Size(256, 27);
            FlatnoTb.TabIndex = 14;
            // 
            // LnameLb
            // 
            LnameLb.AutoSize = true;
            LnameLb.Location = new Point(258, 114);
            LnameLb.Name = "LnameLb";
            LnameLb.Size = new Size(79, 20);
            LnameLb.TabIndex = 13;
            LnameLb.Text = "Last Name";
            // 
            // FnameLb
            // 
            FnameLb.AutoSize = true;
            FnameLb.Location = new Point(0, 114);
            FnameLb.Name = "FnameLb";
            FnameLb.Size = new Size(80, 20);
            FnameLb.TabIndex = 12;
            FnameLb.Text = "First Name";
            // 
            // LastNameTb
            // 
            LastNameTb.Location = new Point(258, 137);
            LastNameTb.Name = "LastNameTb";
            LastNameTb.Size = new Size(242, 27);
            LastNameTb.TabIndex = 11;
            // 
            // FirstNameTb
            // 
            FirstNameTb.Location = new Point(0, 137);
            FirstNameTb.Name = "FirstNameTb";
            FirstNameTb.Size = new Size(255, 27);
            FirstNameTb.TabIndex = 10;
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
            // PasswordSuLb
            // 
            PasswordSuLb.AutoSize = true;
            PasswordSuLb.Location = new Point(266, 300);
            PasswordSuLb.Name = "PasswordSuLb";
            PasswordSuLb.Size = new Size(70, 20);
            PasswordSuLb.TabIndex = 5;
            PasswordSuLb.Text = "Password";
            // 
            // EmailSuLb
            // 
            EmailSuLb.AutoSize = true;
            EmailSuLb.Location = new Point(4, 300);
            EmailSuLb.Name = "EmailSuLb";
            EmailSuLb.Size = new Size(52, 20);
            EmailSuLb.TabIndex = 4;
            EmailSuLb.Text = "E-Mail";
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
            // PasswordSuTb
            // 
            PasswordSuTb.Location = new Point(266, 323);
            PasswordSuTb.Name = "PasswordSuTb";
            PasswordSuTb.Size = new Size(242, 27);
            PasswordSuTb.TabIndex = 2;
            // 
            // EmailSuTb
            // 
            EmailSuTb.Location = new Point(4, 323);
            EmailSuTb.Name = "EmailSuTb";
            EmailSuTb.Size = new Size(258, 27);
            EmailSuTb.TabIndex = 1;
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
            // PreviousPageBt
            // 
            PreviousPageBt.BackColor = Color.IndianRed;
            PreviousPageBt.ForeColor = Color.Black;
            PreviousPageBt.Location = new Point(1589, 12);
            PreviousPageBt.Name = "PreviousPageBt";
            PreviousPageBt.Size = new Size(128, 29);
            PreviousPageBt.TabIndex = 11;
            PreviousPageBt.Text = "<- Previous Page";
            PreviousPageBt.UseVisualStyleBackColor = false;
            PreviousPageBt.Click += PreviousPageBt_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1812, 777);
            Controls.Add(PreviousPageBt);
            Controls.Add(panel1);
            Controls.Add(TCLogo);
            DoubleBuffered = true;
            Name = "SignUpForm";
            Text = "TC_Dashboard";
            ((System.ComponentModel.ISupportInitialize)TCLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).EndInit();
            ResumeLayout(false);
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox TCLogo;
        private Panel panel1;
        private PictureBox IgLink;
        private PictureBox GmapLink;
        private PictureBox FbLink;
        private LinkLabel LogInLink;
        private Label PasswordSuLb;
        private Label EmailSuLb;
        private Button ProceedIntBt;
        private MaskedTextBox PasswordSuTb;
        private MaskedTextBox EmailSuTb;
        private Label WelcomeSignUp;
        private Label CityCodeLb;
        private Label FnameLb;
        private MaskedTextBox LastNameTb;
        private MaskedTextBox FirstNameTb;
        private Label LnameLb;
        private Label StreetLb;
        private Label FlatNoLb;
        private MaskedTextBox StreetTb;
        private MaskedTextBox FlatnoTb;
        private MaskedTextBox CityCodeTb;
        private Label StateLb;
        private MaskedTextBox StateTb;
        private Label CityLb;
        private MaskedTextBox CityTb;
        private Label RetypePasswordLb;
        private MaskedTextBox maskedTextBox3;
        private Label CountryLb;
        private MaskedTextBox CountryTb;
        private Label PhoneNoLb;
        private MaskedTextBox PhoneNoTb;
        private Button PreviousPageBt;
    }
}