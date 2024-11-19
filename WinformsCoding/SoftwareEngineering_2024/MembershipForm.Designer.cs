namespace SoftwareEngineering_2024
{
    partial class MembershipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembershipForm));
            TCLogo = new PictureBox();
            MembershipPanel = new Panel();
            Community_cb = new CheckBox();
            fullTime_cb = new CheckBox();
            Community02_cb = new CheckBox();
            partTime_cb = new CheckBox();
            IgLink = new PictureBox();
            GmapLink = new PictureBox();
            FbLink = new PictureBox();
            LogInLink = new LinkLabel();
            ProceedIntBt = new Button();
            WelcomeSignUp = new Label();
            PreviousPageBt = new Button();
            ((System.ComponentModel.ISupportInitialize)TCLogo).BeginInit();
            MembershipPanel.SuspendLayout();
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
            TCLogo.Location = new Point(88, 74);
            TCLogo.Margin = new Padding(3, 2, 3, 2);
            TCLogo.Name = "TCLogo";
            TCLogo.Size = new Size(488, 417);
            TCLogo.TabIndex = 3;
            TCLogo.TabStop = false;
            TCLogo.Click += TCLogo_Click;
            // 
            // MembershipPanel
            // 
            MembershipPanel.BackColor = Color.RosyBrown;
            MembershipPanel.BackgroundImageLayout = ImageLayout.Stretch;
            MembershipPanel.Controls.Add(Community_cb);
            MembershipPanel.Controls.Add(fullTime_cb);
            MembershipPanel.Controls.Add(Community02_cb);
            MembershipPanel.Controls.Add(partTime_cb);
            MembershipPanel.Controls.Add(IgLink);
            MembershipPanel.Controls.Add(GmapLink);
            MembershipPanel.Controls.Add(FbLink);
            MembershipPanel.Controls.Add(LogInLink);
            MembershipPanel.Controls.Add(ProceedIntBt);
            MembershipPanel.Controls.Add(WelcomeSignUp);
            MembershipPanel.Location = new Point(780, 74);
            MembershipPanel.Margin = new Padding(3, 2, 3, 2);
            MembershipPanel.Name = "MembershipPanel";
            MembershipPanel.Size = new Size(692, 417);
            MembershipPanel.TabIndex = 5;
            // 
            // Community_cb
            // 
            Community_cb.AllowDrop = true;
            Community_cb.BackColor = Color.IndianRed;
            Community_cb.FlatStyle = FlatStyle.Popup;
            Community_cb.Location = new Point(356, 88);
            Community_cb.Margin = new Padding(3, 2, 3, 2);
            Community_cb.Name = "Community_cb";
            Community_cb.Size = new Size(150, 171);
            Community_cb.TabIndex = 14;
            Community_cb.Text = "Community Membership\r\n£18.50/month\r\nAccess discounted events, creative workshops, and a City Centre base for work, socializing, and inspiration\r\n.";
            Community_cb.UseVisualStyleBackColor = false;
            // 
            // fullTime_cb
            // 
            fullTime_cb.AllowDrop = true;
            fullTime_cb.BackColor = Color.IndianRed;
            fullTime_cb.FlatStyle = FlatStyle.Popup;
            fullTime_cb.Location = new Point(195, 88);
            fullTime_cb.Margin = new Padding(3, 2, 3, 2);
            fullTime_cb.Name = "fullTime_cb";
            fullTime_cb.Size = new Size(156, 171);
            fullTime_cb.TabIndex = 12;
            fullTime_cb.Text = "Full Time Workspace Membership\nFrom £100/month + £100 joining fee\nGain Full 24/7 access to a dedicated workspace, storage, and a network of like-minded collaborators.";
            fullTime_cb.TextAlign = ContentAlignment.MiddleCenter;
            fullTime_cb.UseVisualStyleBackColor = false;
            // 
            // Community02_cb
            // 
            Community02_cb.AllowDrop = true;
            Community02_cb.BackColor = Color.IndianRed;
            Community02_cb.FlatStyle = FlatStyle.Popup;
            Community02_cb.Location = new Point(512, 88);
            Community02_cb.Margin = new Padding(3, 2, 3, 2);
            Community02_cb.Name = "Community02_cb";
            Community02_cb.Size = new Size(158, 171);
            Community02_cb.TabIndex = 11;
            Community02_cb.Text = "Community Membership\r\n£28.50/month\r\nAccess discounted events, creative workshops, and a City Centre base for work, socializing, and inspiration.WIth Key access to Spaces\r\n \r\n\r\n\r\n";
            Community02_cb.TextAlign = ContentAlignment.MiddleCenter;
            Community02_cb.UseVisualStyleBackColor = false;
            // 
            // partTime_cb
            // 
            partTime_cb.AllowDrop = true;
            partTime_cb.BackColor = Color.IndianRed;
            partTime_cb.FlatStyle = FlatStyle.Popup;
            partTime_cb.Location = new Point(23, 88);
            partTime_cb.Margin = new Padding(3, 2, 3, 2);
            partTime_cb.Name = "partTime_cb";
            partTime_cb.Size = new Size(167, 169);
            partTime_cb.TabIndex = 10;
            partTime_cb.Text = "Part Time Workspace Membership\nFrom £70/month + £100 joining fee\nGain Partial 24/7 access to a dedicated workspace, storage, and a network of like-minded collaborators.";
            partTime_cb.TextAlign = ContentAlignment.MiddleCenter;
            partTime_cb.UseVisualStyleBackColor = false;
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
            PreviousPageBt.Location = new Point(1360, 9);
            PreviousPageBt.Margin = new Padding(3, 2, 3, 2);
            PreviousPageBt.Name = "PreviousPageBt";
            PreviousPageBt.Size = new Size(112, 22);
            PreviousPageBt.TabIndex = 12;
            PreviousPageBt.Text = "<- Previous Page";
            PreviousPageBt.UseVisualStyleBackColor = false;
            PreviousPageBt.Click += PreviousPageBt_Click;
            // 
            // MembershipForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 561);
            Controls.Add(PreviousPageBt);
            Controls.Add(MembershipPanel);
            Controls.Add(TCLogo);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MembershipForm";
            Text = "MembershipForm";
            ((System.ComponentModel.ISupportInitialize)TCLogo).EndInit();
            MembershipPanel.ResumeLayout(false);
            MembershipPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox TCLogo;
        private Panel MembershipPanel;
        private CheckBox Community_cb;
        private CheckBox fullTime_cb;
        private CheckBox Community02_cb;
        private CheckBox partTime_cb;
        private PictureBox IgLink;
        private PictureBox GmapLink;
        private PictureBox FbLink;
        private LinkLabel LogInLink;
        private Button ProceedIntBt;
        private Label WelcomeSignUp;
        private Button PreviousPageBt;
    }
}