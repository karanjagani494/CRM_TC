
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
            RegisterPanel = new Panel();
            email = new TextBox();
            firstName = new TextBox();
            PhoneNoLb = new Label();
            phoneNumber = new MaskedTextBox();
            CountryLb = new Label();
            country = new MaskedTextBox();
            RetypePasswordLb = new Label();
            rePassTb = new MaskedTextBox();
            StateLb = new Label();
            state = new MaskedTextBox();
            CityLb = new Label();
            city = new MaskedTextBox();
            CityCodeLb = new Label();
            cityCode = new MaskedTextBox();
            StreetLb = new Label();
            FlatNoLb = new Label();
            street = new MaskedTextBox();
            houseNumber = new MaskedTextBox();
            LnameLb = new Label();
            FnameLb = new Label();
            lastName = new MaskedTextBox();
            IgLink = new PictureBox();
            GmapLink = new PictureBox();
            FbLink = new PictureBox();
            LogInLink = new LinkLabel();
            PasswordSuLb = new Label();
            EmailSuLb = new Label();
            ProceedIntBt = new Button();
            password = new MaskedTextBox();
            WelcomeSignUp = new Label();
            ((System.ComponentModel.ISupportInitialize)TCLogo).BeginInit();
            RegisterPanel.SuspendLayout();
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
            // 
            // RegisterPanel
            // 
            RegisterPanel.BackColor = Color.RosyBrown;
            RegisterPanel.BackgroundImageLayout = ImageLayout.Stretch;
            RegisterPanel.Controls.Add(email);
            RegisterPanel.Controls.Add(firstName);
            RegisterPanel.Controls.Add(PhoneNoLb);
            RegisterPanel.Controls.Add(phoneNumber);
            RegisterPanel.Controls.Add(CountryLb);
            RegisterPanel.Controls.Add(country);
            RegisterPanel.Controls.Add(RetypePasswordLb);
            RegisterPanel.Controls.Add(rePassTb);
            RegisterPanel.Controls.Add(StateLb);
            RegisterPanel.Controls.Add(state);
            RegisterPanel.Controls.Add(CityLb);
            RegisterPanel.Controls.Add(city);
            RegisterPanel.Controls.Add(CityCodeLb);
            RegisterPanel.Controls.Add(cityCode);
            RegisterPanel.Controls.Add(StreetLb);
            RegisterPanel.Controls.Add(FlatNoLb);
            RegisterPanel.Controls.Add(street);
            RegisterPanel.Controls.Add(houseNumber);
            RegisterPanel.Controls.Add(LnameLb);
            RegisterPanel.Controls.Add(FnameLb);
            RegisterPanel.Controls.Add(lastName);
            RegisterPanel.Controls.Add(IgLink);
            RegisterPanel.Controls.Add(GmapLink);
            RegisterPanel.Controls.Add(FbLink);
            RegisterPanel.Controls.Add(LogInLink);
            RegisterPanel.Controls.Add(PasswordSuLb);
            RegisterPanel.Controls.Add(EmailSuLb);
            RegisterPanel.Controls.Add(ProceedIntBt);
            RegisterPanel.Controls.Add(password);
            RegisterPanel.Controls.Add(WelcomeSignUp);
            RegisterPanel.Location = new Point(696, 125);
            RegisterPanel.Name = "RegisterPanel";
            RegisterPanel.Size = new Size(791, 556);
            RegisterPanel.TabIndex = 2;
            // 
            // email
            // 
            email.Location = new Point(5, 323);
            email.Margin = new Padding(3, 4, 3, 4);
            email.Name = "email";
            email.Size = new Size(254, 27);
            email.TabIndex = 31;
            // 
            // firstName
            // 
            firstName.Location = new Point(7, 137);
            firstName.Margin = new Padding(3, 4, 3, 4);
            firstName.Name = "firstName";
            firstName.Size = new Size(233, 27);
            firstName.TabIndex = 30;
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
            // phoneNumber
            // 
            phoneNumber.Location = new Point(506, 137);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(282, 27);
            phoneNumber.TabIndex = 28;
            
            // 
            // CountryLb
            // 
            CountryLb.AutoSize = true;
            CountryLb.Location = new Point(5, 237);
            CountryLb.Name = "CountryLb";
            CountryLb.Size = new Size(60, 20);
            CountryLb.TabIndex = 27;
            CountryLb.Text = "Country";
            // 
            // country
            // 
            country.Location = new Point(5, 261);
            country.Name = "country";
            country.Size = new Size(255, 27);
            country.TabIndex = 26;
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
            // rePassTb
            // 
            rePassTb.Location = new Point(514, 323);
            rePassTb.Name = "rePassTb";
            rePassTb.Size = new Size(269, 27);
            rePassTb.TabIndex = 24;
          
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
            // state
            // 
            state.Location = new Point(514, 196);
            state.Name = "state";
            state.Size = new Size(269, 27);
            state.TabIndex = 22;
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
            // city
            // 
            city.Location = new Point(266, 196);
            city.Name = "city";
            city.Size = new Size(242, 27);
            city.TabIndex = 20;
            // 
            // CityCodeLb
            // 
            CityCodeLb.AutoSize = true;
            CityCodeLb.Location = new Point(514, 237);
            CityCodeLb.Name = "CityCodeLb";
            CityCodeLb.Size = new Size(73, 20);
            CityCodeLb.TabIndex = 19;
            CityCodeLb.Text = "City Code";
            // 
            // cityCode
            // 
            cityCode.Location = new Point(514, 261);
            cityCode.Name = "cityCode";
            cityCode.Size = new Size(269, 27);
            cityCode.TabIndex = 18;
            // 
            // StreetLb
            // 
            StreetLb.AutoSize = true;
            StreetLb.Location = new Point(266, 237);
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
            // street
            // 
            street.Location = new Point(266, 261);
            street.Name = "street";
            street.Size = new Size(242, 27);
            street.TabIndex = 15;
            // 
            // houseNumber
            // 
            houseNumber.Location = new Point(5, 196);
            houseNumber.Name = "houseNumber";
            houseNumber.Size = new Size(255, 27);
            houseNumber.TabIndex = 14;
            // 
            // LnameLb
            // 
            LnameLb.AutoSize = true;
            LnameLb.Location = new Point(258, 115);
            LnameLb.Name = "LnameLb";
            LnameLb.Size = new Size(79, 20);
            LnameLb.TabIndex = 13;
            LnameLb.Text = "Last Name";
            // 
            // FnameLb
            // 
            FnameLb.AutoSize = true;
            FnameLb.Location = new Point(0, 115);
            FnameLb.Name = "FnameLb";
            FnameLb.Size = new Size(80, 20);
            FnameLb.TabIndex = 12;
            FnameLb.Text = "First Name";
            // 
            // lastName
            // 
            lastName.Location = new Point(258, 137);
            lastName.Name = "lastName";
            lastName.Size = new Size(242, 27);
            lastName.TabIndex = 11;
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
            FbLink.Location = new Point(219, 445);
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
            EmailSuLb.Location = new Point(5, 300);
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
            // password
            // 
            password.Location = new Point(266, 323);
            password.Name = "password";
            password.Size = new Size(242, 27);
            password.TabIndex = 2;
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
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1714, 777);
            Controls.Add(RegisterPanel);
            Controls.Add(TCLogo);
            DoubleBuffered = true;
            Name = "SignUpForm";
            Text = "TC_Dashboard";
            ((System.ComponentModel.ISupportInitialize)TCLogo).EndInit();
            RegisterPanel.ResumeLayout(false);
            RegisterPanel.PerformLayout();
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
        private Panel RegisterPanel;
        private PictureBox IgLink;
        private PictureBox GmapLink;
        private PictureBox FbLink;
        private LinkLabel LogInLink;
        private Label PasswordSuLb;
        private Label EmailSuLb;
        private Button ProceedIntBt;
        private MaskedTextBox password;
        private Label WelcomeSignUp;
        private Label CityCodeLb;
        private Label FnameLb;
        private MaskedTextBox lastName;
        private Label LnameLb;
        private Label StreetLb;
        private Label FlatNoLb;
        private MaskedTextBox street;
        private MaskedTextBox houseNumber;
        private MaskedTextBox cityCode;
        private Label StateLb;
        private MaskedTextBox state;
        private Label CityLb;
        private MaskedTextBox city;
        private Label RetypePasswordLb;
        private MaskedTextBox rePassTb;
        private Label CountryLb;
        private MaskedTextBox country;
        private Label PhoneNoLb;
        private MaskedTextBox phoneNumber;
        private TextBox firstName;
        private TextBox email;
    }
}