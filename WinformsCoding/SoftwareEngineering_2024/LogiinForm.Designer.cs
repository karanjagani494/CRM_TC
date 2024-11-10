namespace SoftwareEngineering_2024
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            WelcomeBackLogin = new Label();
            panel1 = new Panel();
            IgLink = new PictureBox();
            GmapLink = new PictureBox();
            FbLink = new PictureBox();
            AccountCreateLink = new LinkLabel();
            PasswordLb = new Label();
            EmailLb = new Label();
            LoginBt = new Button();
            password_txt = new MaskedTextBox();
            email_txt = new MaskedTextBox();
            TCLogo = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TCLogo).BeginInit();
            SuspendLayout();
            // 
            // WelcomeBackLogin
            // 
            WelcomeBackLogin.AutoSize = true;
            WelcomeBackLogin.BackColor = Color.RosyBrown;
            WelcomeBackLogin.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeBackLogin.Location = new Point(266, 25);
            WelcomeBackLogin.Name = "WelcomeBackLogin";
            WelcomeBackLogin.Size = new Size(159, 25);
            WelcomeBackLogin.TabIndex = 0;
            WelcomeBackLogin.Text = "Welcome Back!";
            WelcomeBackLogin.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(IgLink);
            panel1.Controls.Add(GmapLink);
            panel1.Controls.Add(FbLink);
            panel1.Controls.Add(AccountCreateLink);
            panel1.Controls.Add(PasswordLb);
            panel1.Controls.Add(EmailLb);
            panel1.Controls.Add(LoginBt);
            panel1.Controls.Add(password_txt);
            panel1.Controls.Add(email_txt);
            panel1.Controls.Add(WelcomeBackLogin);
            panel1.Location = new Point(766, 82);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 417);
            panel1.TabIndex = 1;
            // 
            // IgLink
            // 
            IgLink.BackgroundImage = (Image)resources.GetObject("IgLink.BackgroundImage");
            IgLink.BackgroundImageLayout = ImageLayout.Stretch;
            IgLink.Cursor = Cursors.Hand;
            IgLink.Location = new Point(483, 315);
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
            GmapLink.Location = new Point(332, 315);
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
            FbLink.Location = new Point(188, 315);
            FbLink.Margin = new Padding(3, 2, 3, 2);
            FbLink.Name = "FbLink";
            FbLink.Size = new Size(38, 32);
            FbLink.TabIndex = 7;
            FbLink.TabStop = false;
            // 
            // AccountCreateLink
            // 
            AccountCreateLink.AutoSize = true;
            AccountCreateLink.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountCreateLink.Location = new Point(267, 374);
            AccountCreateLink.Name = "AccountCreateLink";
            AccountCreateLink.Size = new Size(158, 19);
            AccountCreateLink.TabIndex = 6;
            AccountCreateLink.TabStop = true;
            AccountCreateLink.Text = "Not a Member, Sign Up!";
            // 
            // PasswordLb
            // 
            PasswordLb.AutoSize = true;
            PasswordLb.Location = new Point(98, 164);
            PasswordLb.Name = "PasswordLb";
            PasswordLb.Size = new Size(57, 15);
            PasswordLb.TabIndex = 5;
            PasswordLb.Text = "Password";
            // 
            // EmailLb
            // 
            EmailLb.AutoSize = true;
            EmailLb.Location = new Point(98, 98);
            EmailLb.Name = "EmailLb";
            EmailLb.Size = new Size(41, 15);
            EmailLb.TabIndex = 4;
            EmailLb.Text = "E-Mail";
            // 
            // LoginBt
            // 
            LoginBt.BackColor = Color.IndianRed;
            LoginBt.Location = new Point(266, 243);
            LoginBt.Margin = new Padding(3, 2, 3, 2);
            LoginBt.Name = "LoginBt";
            LoginBt.Size = new Size(172, 43);
            LoginBt.TabIndex = 3;
            LoginBt.Text = "Login";
            LoginBt.TextImageRelation = TextImageRelation.TextAboveImage;
            LoginBt.UseVisualStyleBackColor = false;
            LoginBt.Click += LoginBt_Click;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(98, 181);
            password_txt.Margin = new Padding(3, 2, 3, 2);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(493, 23);
            password_txt.TabIndex = 2;
            // 
            // email_txt
            // 
            email_txt.Location = new Point(98, 115);
            email_txt.Margin = new Padding(3, 2, 3, 2);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(493, 23);
            email_txt.TabIndex = 1;
            // 
            // TCLogo
            // 
            TCLogo.BackColor = Color.Transparent;
            TCLogo.BackgroundImage = (Image)resources.GetObject("TCLogo.BackgroundImage");
            TCLogo.BackgroundImageLayout = ImageLayout.Stretch;
            TCLogo.Location = new Point(97, 75);
            TCLogo.Margin = new Padding(3, 2, 3, 2);
            TCLogo.Name = "TCLogo";
            TCLogo.Size = new Size(488, 417);
            TCLogo.TabIndex = 0;
            TCLogo.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 572);
            Controls.Add(TCLogo);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "TC_Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)TCLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label WelcomeBackLogin;
        private Panel panel1;
        private PictureBox TCLogo;
        private Label PasswordLb;
        private Label EmailLb;
        private Button LoginBt;
        private MaskedTextBox password_txt;
        private MaskedTextBox email_txt;
        private LinkLabel AccountCreateLink;
        private PictureBox IgLink;
        private PictureBox GmapLink;
        private PictureBox FbLink;
    }
}
