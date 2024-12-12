namespace SoftwareEngineering_2024
{
    partial class InterestDptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterestDptForm));
            panel1 = new Panel();
            Sharing = new CheckBox();
            Helping = new CheckBox();
            Working = new CheckBox();
            Happening = new CheckBox();
            Learning = new CheckBox();
            IgLink = new PictureBox();
            GmapLink = new PictureBox();
            FbLink = new PictureBox();
            ProceedTagBt = new Button();
            WelcomeSignUp = new Label();
            TCLogo = new PictureBox();
            PreviousPageBt = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TCLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(Sharing);
            panel1.Controls.Add(Helping);
            panel1.Controls.Add(Working);
            panel1.Controls.Add(Happening);
            panel1.Controls.Add(Learning);
            panel1.Controls.Add(IgLink);
            panel1.Controls.Add(GmapLink);
            panel1.Controls.Add(FbLink);
            panel1.Controls.Add(ProceedTagBt);
            panel1.Controls.Add(WelcomeSignUp);
            panel1.Location = new Point(936, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 556);
            panel1.TabIndex = 4;
            // 
            // Sharing
            // 
            Sharing.AllowDrop = true;
            Sharing.BackColor = Color.IndianRed;
            Sharing.FlatStyle = FlatStyle.Popup;
            Sharing.Location = new Point(474, 253);
            Sharing.Name = "Sharing";
            Sharing.Size = new Size(126, 87);
            Sharing.TabIndex = 14;
            Sharing.Text = "Sharing";
            Sharing.UseVisualStyleBackColor = false;
            // 
            // Helping
            // 
            Helping.AllowDrop = true;
            Helping.BackColor = Color.IndianRed;
            Helping.FlatStyle = FlatStyle.Popup;
            Helping.Location = new Point(557, 123);
            Helping.Name = "Helping";
            Helping.Size = new Size(126, 81);
            Helping.TabIndex = 13;
            Helping.Text = "Helping";
            Helping.UseVisualStyleBackColor = false;
            // 
            // Working
            // 
            Working.AllowDrop = true;
            Working.BackColor = Color.IndianRed;
            Working.FlatStyle = FlatStyle.Popup;
            Working.Location = new Point(237, 253);
            Working.Name = "Working";
            Working.Size = new Size(126, 87);
            Working.TabIndex = 12;
            Working.Text = "Working";
            Working.UseVisualStyleBackColor = false;
            // 
            // Happening
            // 
            Happening.AllowDrop = true;
            Happening.BackColor = Color.IndianRed;
            Happening.FlatStyle = FlatStyle.Popup;
            Happening.Location = new Point(347, 117);
            Happening.Name = "Happening";
            Happening.Size = new Size(126, 87);
            Happening.TabIndex = 11;
            Happening.Text = "Happening";
            Happening.UseVisualStyleBackColor = false;
            // 
            // Learning
            // 
            Learning.AllowDrop = true;
            Learning.BackColor = Color.IndianRed;
            Learning.FlatStyle = FlatStyle.Popup;
            Learning.Location = new Point(123, 120);
            Learning.Name = "Learning";
            Learning.Size = new Size(126, 87);
            Learning.TabIndex = 10;
            Learning.Text = "Learning";
            Learning.UseVisualStyleBackColor = false;
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
            // ProceedTagBt
            // 
            ProceedTagBt.BackColor = Color.IndianRed;
            ProceedTagBt.Location = new Point(303, 372);
            ProceedTagBt.Name = "ProceedTagBt";
            ProceedTagBt.Size = new Size(197, 57);
            ProceedTagBt.TabIndex = 3;
            ProceedTagBt.Text = "Proceed";
            ProceedTagBt.UseVisualStyleBackColor = false;
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
            // TCLogo
            // 
            TCLogo.BackColor = Color.Transparent;
            TCLogo.BackgroundImage = (Image)resources.GetObject("TCLogo.BackgroundImage");
            TCLogo.BackgroundImageLayout = ImageLayout.Stretch;
            TCLogo.Location = new Point(79, 96);
            TCLogo.Name = "TCLogo";
            TCLogo.Size = new Size(558, 556);
            TCLogo.TabIndex = 3;
            TCLogo.TabStop = false;
            // 
            // PreviousPageBt
            // 
            PreviousPageBt.BackColor = Color.IndianRed;
            PreviousPageBt.ForeColor = Color.Black;
            PreviousPageBt.Location = new Point(1599, 12);
            PreviousPageBt.Name = "PreviousPageBt";
            PreviousPageBt.Size = new Size(128, 29);
            PreviousPageBt.TabIndex = 12;
            PreviousPageBt.Text = "<- Previous Page";
            PreviousPageBt.UseVisualStyleBackColor = false;
            PreviousPageBt.Click += PreviousPageBt_Click;
            // 
            // InterestDptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1839, 802);
            Controls.Add(PreviousPageBt);
            Controls.Add(panel1);
            Controls.Add(TCLogo);
            DoubleBuffered = true;
            Name = "InterestDptForm";
            Text = "InterestDpt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)TCLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox IgLink;
        private PictureBox GmapLink;
        private PictureBox FbLink;
        private Button ProceedTagBt;
        private Label WelcomeSignUp;
        private PictureBox TCLogo;
        private CheckBox Sharing;
        private CheckBox Helping;
        private CheckBox Working;
        private CheckBox Happening;
        private CheckBox Learning;
        private Button PreviousPageBt;
    }
}