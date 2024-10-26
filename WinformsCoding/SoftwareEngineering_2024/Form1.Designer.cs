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
            PasswordTb = new MaskedTextBox();
            EmailTb = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // WelcomeBackLogin
            // 
            WelcomeBackLogin.AutoSize = true;
            WelcomeBackLogin.BackColor = Color.RosyBrown;
            WelcomeBackLogin.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeBackLogin.Location = new Point(304, 33);
            WelcomeBackLogin.Name = "WelcomeBackLogin";
            WelcomeBackLogin.Size = new Size(197, 32);
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
            panel1.Controls.Add(PasswordTb);
            panel1.Controls.Add(EmailTb);
            panel1.Controls.Add(WelcomeBackLogin);
            panel1.Location = new Point(892, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 556);
            panel1.TabIndex = 1;
            // 
            // IgLink
            // 
            IgLink.BackgroundImage = (Image)resources.GetObject("IgLink.BackgroundImage");
            IgLink.BackgroundImageLayout = ImageLayout.Stretch;
            IgLink.Cursor = Cursors.Hand;
            IgLink.Location = new Point(552, 420);
            IgLink.Name = "IgLink";
            IgLink.Size = new Size(43, 43);
            IgLink.TabIndex = 9;
            IgLink.TabStop = false;
            IgLink.Click += Ig_Click;
            // 
            // GmapLink
            // 
            GmapLink.BackgroundImage = Properties.Resources.Gmaps;
            GmapLink.BackgroundImageLayout = ImageLayout.Stretch;
            GmapLink.Cursor = Cursors.Hand;
            GmapLink.Location = new Point(380, 420);
            GmapLink.Name = "GmapLink";
            GmapLink.Size = new Size(43, 43);
            GmapLink.TabIndex = 8;
            GmapLink.TabStop = false;
            GmapLink.Click += Gmaps_Click;
            // 
            // FbLink
            // 
            FbLink.BackgroundImage = Properties.Resources.fb;
            FbLink.BackgroundImageLayout = ImageLayout.Stretch;
            FbLink.Cursor = Cursors.Hand;
            FbLink.Location = new Point(215, 420);
            FbLink.Name = "FbLink";
            FbLink.Size = new Size(43, 43);
            FbLink.TabIndex = 7;
            FbLink.TabStop = false;
            FbLink.Click += Fb_Click;
            // 
            // AccountCreateLink
            // 
            AccountCreateLink.AutoSize = true;
            AccountCreateLink.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountCreateLink.Location = new Point(305, 498);
            AccountCreateLink.Name = "AccountCreateLink";
            AccountCreateLink.Size = new Size(196, 23);
            AccountCreateLink.TabIndex = 6;
            AccountCreateLink.TabStop = true;
            AccountCreateLink.Text = "Not a Member, Sign Up!";
            AccountCreateLink.LinkClicked += SignUpLinkClicked;
            // 
            // PasswordLb
            // 
            PasswordLb.AutoSize = true;
            PasswordLb.Location = new Point(112, 218);
            PasswordLb.Name = "PasswordLb";
            PasswordLb.Size = new Size(70, 20);
            PasswordLb.TabIndex = 5;
            PasswordLb.Text = "Password";
            // 
            // EmailLb
            // 
            EmailLb.AutoSize = true;
            EmailLb.Location = new Point(112, 130);
            EmailLb.Name = "EmailLb";
            EmailLb.Size = new Size(52, 20);
            EmailLb.TabIndex = 4;
            EmailLb.Text = "E-Mail";
            // 
            // LoginBt
            // 
            LoginBt.BackColor = Color.IndianRed;
            LoginBt.Location = new Point(304, 324);
            LoginBt.Name = "LoginBt";
            LoginBt.Size = new Size(197, 57);
            LoginBt.TabIndex = 3;
            LoginBt.Text = "Login";
            LoginBt.UseVisualStyleBackColor = false;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(112, 241);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(563, 27);
            PasswordTb.TabIndex = 2;
            // 
            // EmailTb
            // 
            EmailTb.Location = new Point(112, 153);
            EmailTb.Name = "EmailTb";
            EmailTb.Size = new Size(563, 27);
            EmailTb.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(111, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(558, 556);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1768, 763);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "LoginForm";
            Text = "TC_Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label WelcomeBackLogin;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label PasswordLb;
        private Label EmailLb;
        private Button LoginBt;
        private MaskedTextBox PasswordTb;
        private MaskedTextBox EmailTb;
        private LinkLabel AccountCreateLink;
        private PictureBox IgLink;
        private PictureBox GmapLink;
        private PictureBox FbLink;
    }
}
