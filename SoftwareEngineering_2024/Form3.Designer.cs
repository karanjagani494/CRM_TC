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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            IgLink = new PictureBox();
            GmapLink = new PictureBox();
            FbLink = new PictureBox();
            AccountCreateLink = new LinkLabel();
            PasswordLb = new Label();
            EmailLb = new Label();
            SignUpBt = new Button();
            PasswordTb = new MaskedTextBox();
            EmailTb = new MaskedTextBox();
            WelcomeSignUp = new Label();
            LnameLb = new Label();
            FnameLb = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(69, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(558, 556);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(LnameLb);
            panel1.Controls.Add(FnameLb);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(IgLink);
            panel1.Controls.Add(GmapLink);
            panel1.Controls.Add(FbLink);
            panel1.Controls.Add(AccountCreateLink);
            panel1.Controls.Add(PasswordLb);
            panel1.Controls.Add(EmailLb);
            panel1.Controls.Add(SignUpBt);
            panel1.Controls.Add(PasswordTb);
            panel1.Controls.Add(EmailTb);
            panel1.Controls.Add(WelcomeSignUp);
            panel1.Location = new Point(926, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 556);
            panel1.TabIndex = 2;
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
            // 
            // PasswordLb
            // 
            PasswordLb.AutoSize = true;
            PasswordLb.Location = new Point(261, 268);
            PasswordLb.Name = "PasswordLb";
            PasswordLb.Size = new Size(70, 20);
            PasswordLb.TabIndex = 5;
            PasswordLb.Text = "Password";
            // 
            // EmailLb
            // 
            EmailLb.AutoSize = true;
            EmailLb.Location = new Point(38, 268);
            EmailLb.Name = "EmailLb";
            EmailLb.Size = new Size(52, 20);
            EmailLb.TabIndex = 4;
            EmailLb.Text = "E-Mail";
            // 
            // SignUpBt
            // 
            SignUpBt.BackColor = Color.IndianRed;
            SignUpBt.Location = new Point(304, 324);
            SignUpBt.Name = "SignUpBt";
            SignUpBt.Size = new Size(197, 57);
            SignUpBt.TabIndex = 3;
            SignUpBt.Text = "Sign Up!";
            SignUpBt.UseVisualStyleBackColor = false;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(261, 291);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(220, 27);
            PasswordTb.TabIndex = 2;
            // 
            // EmailTb
            // 
            EmailTb.Location = new Point(38, 291);
            EmailTb.Name = "EmailTb";
            EmailTb.Size = new Size(217, 27);
            EmailTb.TabIndex = 1;
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
            // LnameLb
            // 
            LnameLb.AutoSize = true;
            LnameLb.Location = new Point(261, 117);
            LnameLb.Name = "LnameLb";
            LnameLb.Size = new Size(79, 20);
            LnameLb.TabIndex = 13;
            LnameLb.Text = "Last Name";
            // 
            // FnameLb
            // 
            FnameLb.AutoSize = true;
            FnameLb.Location = new Point(38, 117);
            FnameLb.Name = "FnameLb";
            FnameLb.Size = new Size(80, 20);
            FnameLb.TabIndex = 12;
            FnameLb.Text = "First Name";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(261, 140);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(220, 27);
            maskedTextBox1.TabIndex = 11;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(38, 140);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(217, 27);
            maskedTextBox2.TabIndex = 10;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1812, 777);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "SignUpForm";
            Text = "TC_Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox IgLink;
        private PictureBox GmapLink;
        private PictureBox FbLink;
        private LinkLabel AccountCreateLink;
        private Label PasswordLb;
        private Label EmailLb;
        private Button SignUpBt;
        private MaskedTextBox PasswordTb;
        private MaskedTextBox EmailTb;
        private Label WelcomeSignUp;
        private Label label1;
        private Label FnameLb;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label LnameLb;
    }
}