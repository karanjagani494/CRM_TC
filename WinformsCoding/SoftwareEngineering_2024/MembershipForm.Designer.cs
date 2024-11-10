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
            CommCb = new CheckBox();
            WorkspaceFtCb = new CheckBox();
            CommKeysCb = new CheckBox();
            WorkspacePtCb = new CheckBox();
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
            TCLogo.Location = new Point(100, 98);
            TCLogo.Name = "TCLogo";
            TCLogo.Size = new Size(558, 556);
            TCLogo.TabIndex = 3;
            TCLogo.TabStop = false;
            // 
            // MembershipPanel
            // 
            MembershipPanel.BackColor = Color.RosyBrown;
            MembershipPanel.BackgroundImageLayout = ImageLayout.Stretch;
            MembershipPanel.Controls.Add(CommCb);
            MembershipPanel.Controls.Add(WorkspaceFtCb);
            MembershipPanel.Controls.Add(CommKeysCb);
            MembershipPanel.Controls.Add(WorkspacePtCb);
            MembershipPanel.Controls.Add(IgLink);
            MembershipPanel.Controls.Add(GmapLink);
            MembershipPanel.Controls.Add(FbLink);
            MembershipPanel.Controls.Add(LogInLink);
            MembershipPanel.Controls.Add(ProceedIntBt);
            MembershipPanel.Controls.Add(WelcomeSignUp);
            MembershipPanel.Location = new Point(891, 98);
            MembershipPanel.Name = "MembershipPanel";
            MembershipPanel.Size = new Size(791, 556);
            MembershipPanel.TabIndex = 5;
            // 
            // CommCb
            // 
            CommCb.AllowDrop = true;
            CommCb.BackColor = Color.IndianRed;
            CommCb.FlatStyle = FlatStyle.Popup;
            CommCb.Location = new Point(407, 117);
            CommCb.Name = "CommCb";
            CommCb.Size = new Size(172, 228);
            CommCb.TabIndex = 14;
            CommCb.Text = "Community Membership\r\n£18.50/month\r\nAccess discounted events, creative workshops, and a City Centre base for work, socializing, and inspiration\r\n.";
            CommCb.UseVisualStyleBackColor = false;
            // 
            // WorkspaceFtCb
            // 
            WorkspaceFtCb.AllowDrop = true;
            WorkspaceFtCb.BackColor = Color.IndianRed;
            WorkspaceFtCb.FlatStyle = FlatStyle.Popup;
            WorkspaceFtCb.Location = new Point(223, 117);
            WorkspaceFtCb.Name = "WorkspaceFtCb";
            WorkspaceFtCb.Size = new Size(178, 228);
            WorkspaceFtCb.TabIndex = 12;
            WorkspaceFtCb.Text = "Full Time Workspace Membership\nFrom £100/month + £100 joining fee\nGain Full 24/7 access to a dedicated workspace, storage, and a network of like-minded collaborators.";
            WorkspaceFtCb.TextAlign = ContentAlignment.MiddleCenter;
            WorkspaceFtCb.UseVisualStyleBackColor = false;
            // 
            // CommKeysCb
            // 
            CommKeysCb.AllowDrop = true;
            CommKeysCb.BackColor = Color.IndianRed;
            CommKeysCb.FlatStyle = FlatStyle.Popup;
            CommKeysCb.Location = new Point(585, 117);
            CommKeysCb.Name = "CommKeysCb";
            CommKeysCb.Size = new Size(180, 228);
            CommKeysCb.TabIndex = 11;
            CommKeysCb.Text = "Community Membership\r\n£28.50/month\r\nAccess discounted events, creative workshops, and a City Centre base for work, socializing, and inspiration.WIth Key access to Spaces\r\n \r\n\r\n\r\n";
            CommKeysCb.TextAlign = ContentAlignment.MiddleCenter;
            CommKeysCb.UseVisualStyleBackColor = false;
            // 
            // WorkspacePtCb
            // 
            WorkspacePtCb.AllowDrop = true;
            WorkspacePtCb.BackColor = Color.IndianRed;
            WorkspacePtCb.FlatStyle = FlatStyle.Popup;
            WorkspacePtCb.Location = new Point(26, 117);
            WorkspacePtCb.Name = "WorkspacePtCb";
            WorkspacePtCb.Size = new Size(191, 225);
            WorkspacePtCb.TabIndex = 10;
            WorkspacePtCb.Text = "Part Time Workspace Membership\nFrom £70/month + £100 joining fee\nGain Partial 24/7 access to a dedicated workspace, storage, and a network of like-minded collaborators.";
            WorkspacePtCb.TextAlign = ContentAlignment.MiddleCenter;
            WorkspacePtCb.UseVisualStyleBackColor = false;
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
            // PreviousPageBt
            // 
            PreviousPageBt.BackColor = Color.IndianRed;
            PreviousPageBt.ForeColor = Color.Black;
            PreviousPageBt.Location = new Point(1554, 12);
            PreviousPageBt.Name = "PreviousPageBt";
            PreviousPageBt.Size = new Size(128, 29);
            PreviousPageBt.TabIndex = 12;
            PreviousPageBt.Text = "<- Previous Page";
            PreviousPageBt.UseVisualStyleBackColor = false;
            PreviousPageBt.Click += PreviousPageBt_Click;
            // 
            // MembershipForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1772, 748);
            Controls.Add(PreviousPageBt);
            Controls.Add(MembershipPanel);
            Controls.Add(TCLogo);
            DoubleBuffered = true;
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
        private CheckBox CommCb;
        private CheckBox WorkspaceFtCb;
        private CheckBox CommKeysCb;
        private CheckBox WorkspacePtCb;
        private PictureBox IgLink;
        private PictureBox GmapLink;
        private PictureBox FbLink;
        private LinkLabel LogInLink;
        private Button ProceedIntBt;
        private Label WelcomeSignUp;
        private Button PreviousPageBt;
    }
}