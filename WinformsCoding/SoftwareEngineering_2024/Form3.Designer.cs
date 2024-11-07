
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
            email_text = new TextBox();
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
            username_text = new MaskedTextBox();
            IgLink = new PictureBox();
            GmapLink = new PictureBox();
            FbLink = new PictureBox();
            LogInLink = new LinkLabel();
            PasswordSuLb = new Label();
            EmailSuLb = new Label();
            ProceedIntBt = new Button();
            password_text = new MaskedTextBox();
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
            TCLogo.Location = new Point(60, 94);
            TCLogo.Margin = new Padding(3, 2, 3, 2);
            TCLogo.Name = "TCLogo";
            TCLogo.Size = new Size(488, 417);
            TCLogo.TabIndex = 1;
            TCLogo.TabStop = false;
            TCLogo.Click += TCLogo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(email_text);
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
            panel1.Controls.Add(username_text);
            panel1.Controls.Add(IgLink);
            panel1.Controls.Add(GmapLink);
            panel1.Controls.Add(FbLink);
            panel1.Controls.Add(LogInLink);
            panel1.Controls.Add(PasswordSuLb);
            panel1.Controls.Add(EmailSuLb);
            panel1.Controls.Add(ProceedIntBt);
            panel1.Controls.Add(password_text);
            panel1.Controls.Add(WelcomeSignUp);
            panel1.Location = new Point(724, 94);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 417);
            panel1.TabIndex = 2;
            // 
            // email_text
            // 
            email_text.Location = new Point(4, 243);
            email_text.Name = "email_text";
            email_text.Size = new Size(220, 23);
            email_text.TabIndex = 30;
            email_text.TextChanged += email_text_TextChanged;
            // 
            // PhoneNoLb
            // 
            PhoneNoLb.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneNoLb.Location = new Point(435, 88);
            PhoneNoLb.Name = "PhoneNoLb";
            PhoneNoLb.Size = new Size(257, 13);
            PhoneNoLb.TabIndex = 29;
            PhoneNoLb.Text = "Phone Number{Add Country Code, ex: +44 788..}";
            // 
            // PhoneNoTb
            // 
            PhoneNoTb.Location = new Point(443, 103);
            PhoneNoTb.Margin = new Padding(3, 2, 3, 2);
            PhoneNoTb.Name = "PhoneNoTb";
            PhoneNoTb.Size = new Size(247, 23);
            PhoneNoTb.TabIndex = 28;
            // 
            // CountryLb
            // 
            CountryLb.AutoSize = true;
            CountryLb.Location = new Point(4, 178);
            CountryLb.Name = "CountryLb";
            CountryLb.Size = new Size(50, 15);
            CountryLb.TabIndex = 27;
            CountryLb.Text = "Country";
            // 
            // CountryTb
            // 
            CountryTb.Location = new Point(4, 196);
            CountryTb.Margin = new Padding(3, 2, 3, 2);
            CountryTb.Name = "CountryTb";
            CountryTb.Size = new Size(224, 23);
            CountryTb.TabIndex = 26;
            // 
            // RetypePasswordLb
            // 
            RetypePasswordLb.AutoSize = true;
            RetypePasswordLb.Location = new Point(450, 225);
            RetypePasswordLb.Name = "RetypePasswordLb";
            RetypePasswordLb.Size = new Size(96, 15);
            RetypePasswordLb.TabIndex = 25;
            RetypePasswordLb.Text = "Retype Password";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(450, 242);
            maskedTextBox3.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(236, 23);
            maskedTextBox3.TabIndex = 24;
            // 
            // StateLb
            // 
            StateLb.AutoSize = true;
            StateLb.Location = new Point(450, 130);
            StateLb.Name = "StateLb";
            StateLb.Size = new Size(77, 15);
            StateLb.TabIndex = 23;
            StateLb.Text = "State/County";
            // 
            // StateTb
            // 
            StateTb.Location = new Point(450, 147);
            StateTb.Margin = new Padding(3, 2, 3, 2);
            StateTb.Name = "StateTb";
            StateTb.Size = new Size(236, 23);
            StateTb.TabIndex = 22;
            // 
            // CityLb
            // 
            CityLb.AutoSize = true;
            CityLb.Location = new Point(233, 130);
            CityLb.Name = "CityLb";
            CityLb.Size = new Size(28, 15);
            CityLb.TabIndex = 21;
            CityLb.Text = "City";
            // 
            // CityTb
            // 
            CityTb.Location = new Point(233, 147);
            CityTb.Margin = new Padding(3, 2, 3, 2);
            CityTb.Name = "CityTb";
            CityTb.Size = new Size(212, 23);
            CityTb.TabIndex = 20;
            // 
            // CityCodeLb
            // 
            CityCodeLb.AutoSize = true;
            CityCodeLb.Location = new Point(450, 178);
            CityCodeLb.Name = "CityCodeLb";
            CityCodeLb.Size = new Size(59, 15);
            CityCodeLb.TabIndex = 19;
            CityCodeLb.Text = "City Code";
            // 
            // CityCodeTb
            // 
            CityCodeTb.Location = new Point(450, 196);
            CityCodeTb.Margin = new Padding(3, 2, 3, 2);
            CityCodeTb.Name = "CityCodeTb";
            CityCodeTb.Size = new Size(236, 23);
            CityCodeTb.TabIndex = 18;
            // 
            // StreetLb
            // 
            StreetLb.AutoSize = true;
            StreetLb.Location = new Point(233, 178);
            StreetLb.Name = "StreetLb";
            StreetLb.Size = new Size(37, 15);
            StreetLb.TabIndex = 17;
            StreetLb.Text = "Street";
            // 
            // FlatNoLb
            // 
            FlatNoLb.AutoSize = true;
            FlatNoLb.Location = new Point(4, 130);
            FlatNoLb.Name = "FlatNoLb";
            FlatNoLb.Size = new Size(112, 15);
            FlatNoLb.TabIndex = 16;
            FlatNoLb.Text = "Flat/House Number";
            // 
            // StreetTb
            // 
            StreetTb.Location = new Point(233, 196);
            StreetTb.Margin = new Padding(3, 2, 3, 2);
            StreetTb.Name = "StreetTb";
            StreetTb.Size = new Size(212, 23);
            StreetTb.TabIndex = 15;
            // 
            // FlatnoTb
            // 
            FlatnoTb.Location = new Point(4, 147);
            FlatnoTb.Margin = new Padding(3, 2, 3, 2);
            FlatnoTb.Name = "FlatnoTb";
            FlatnoTb.Size = new Size(224, 23);
            FlatnoTb.TabIndex = 14;
            // 
            // LnameLb
            // 
            LnameLb.AutoSize = true;
            LnameLb.Location = new Point(226, 86);
            LnameLb.Name = "LnameLb";
            LnameLb.Size = new Size(63, 15);
            LnameLb.TabIndex = 13;
            LnameLb.Text = "Last Name";
            // 
            // FnameLb
            // 
            FnameLb.AutoSize = true;
            FnameLb.Location = new Point(0, 86);
            FnameLb.Name = "FnameLb";
            FnameLb.Size = new Size(59, 15);
            FnameLb.TabIndex = 12;
            FnameLb.Text = "username";
            // 
            // LastNameTb
            // 
            LastNameTb.Location = new Point(226, 103);
            LastNameTb.Margin = new Padding(3, 2, 3, 2);
            LastNameTb.Name = "LastNameTb";
            LastNameTb.Size = new Size(212, 23);
            LastNameTb.TabIndex = 11;
            // 
            // username_text
            // 
            username_text.Location = new Point(0, 103);
            username_text.Margin = new Padding(3, 2, 3, 2);
            username_text.Name = "username_text";
            username_text.Size = new Size(224, 23);
            username_text.TabIndex = 10;
            // 
            // IgLink
            // 
            IgLink.BackgroundImage = (Image)resources.GetObject("IgLink.BackgroundImage");
            IgLink.BackgroundImageLayout = ImageLayout.Stretch;
            IgLink.Cursor = Cursors.Hand;
            IgLink.Location = new Point(487, 334);
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
            GmapLink.Location = new Point(337, 334);
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
            FbLink.Location = new Point(192, 334);
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
            LogInLink.Location = new Point(266, 384);
            LogInLink.Name = "LogInLink";
            LogInLink.Size = new Size(168, 19);
            LogInLink.TabIndex = 6;
            LogInLink.TabStop = true;
            LogInLink.Text = "Already a Member, Log In";
            LogInLink.LinkClicked += LogInLink_LinkClicked;
            // 
            // PasswordSuLb
            // 
            PasswordSuLb.AutoSize = true;
            PasswordSuLb.Location = new Point(233, 225);
            PasswordSuLb.Name = "PasswordSuLb";
            PasswordSuLb.Size = new Size(57, 15);
            PasswordSuLb.TabIndex = 5;
            PasswordSuLb.Text = "Password";
            // 
            // EmailSuLb
            // 
            EmailSuLb.AutoSize = true;
            EmailSuLb.Location = new Point(4, 225);
            EmailSuLb.Name = "EmailSuLb";
            EmailSuLb.Size = new Size(41, 15);
            EmailSuLb.TabIndex = 4;
            EmailSuLb.Text = "E-Mail";
            // 
            // ProceedIntBt
            // 
            ProceedIntBt.BackColor = Color.IndianRed;
            ProceedIntBt.Location = new Point(265, 279);
            ProceedIntBt.Margin = new Padding(3, 2, 3, 2);
            ProceedIntBt.Name = "ProceedIntBt";
            ProceedIntBt.Size = new Size(172, 43);
            ProceedIntBt.TabIndex = 3;
            ProceedIntBt.Text = "Proceed";
            ProceedIntBt.UseVisualStyleBackColor = false;
            ProceedIntBt.Click += ProceedIntBt_Click;
            // 
            // password_text
            // 
            password_text.Location = new Point(233, 242);
            password_text.Margin = new Padding(3, 2, 3, 2);
            password_text.Name = "password_text";
            password_text.Size = new Size(212, 23);
            password_text.TabIndex = 2;
            // 
            // WelcomeSignUp
            // 
            WelcomeSignUp.AutoSize = true;
            WelcomeSignUp.BackColor = Color.RosyBrown;
            WelcomeSignUp.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeSignUp.Location = new Point(207, 22);
            WelcomeSignUp.Name = "WelcomeSignUp";
            WelcomeSignUp.Size = new Size(289, 25);
            WelcomeSignUp.TabIndex = 0;
            WelcomeSignUp.Text = "Welcome to Together Culture";
            WelcomeSignUp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PreviousPageBt
            // 
            PreviousPageBt.BackColor = Color.IndianRed;
            PreviousPageBt.ForeColor = Color.Black;
            PreviousPageBt.Location = new Point(1390, 9);
            PreviousPageBt.Margin = new Padding(3, 2, 3, 2);
            PreviousPageBt.Name = "PreviousPageBt";
            PreviousPageBt.Size = new Size(112, 22);
            PreviousPageBt.TabIndex = 11;
            PreviousPageBt.Text = "<- Previous Page";
            PreviousPageBt.UseVisualStyleBackColor = false;
            PreviousPageBt.Click += PreviousPageBt_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 583);
            Controls.Add(PreviousPageBt);
            Controls.Add(panel1);
            Controls.Add(TCLogo);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
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
        private MaskedTextBox password_text;
        private Label WelcomeSignUp;
        private Label CityCodeLb;
        private Label FnameLb;
        private MaskedTextBox LastNameTb;
        private MaskedTextBox username_text;
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
        private TextBox email_text;
    }
}