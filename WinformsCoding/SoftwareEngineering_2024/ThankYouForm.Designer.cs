namespace SoftwareEngineering_2024
{
    partial class ThankYouForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThankYouForm));
            TCLogo = new PictureBox();
            ThankyouPanel = new Panel();
            IgLink = new PictureBox();
            GmapLink = new PictureBox();
            FbLink = new PictureBox();
            ThankyouLoginBt = new Button();
            ThankyouLb = new Label();
            ((System.ComponentModel.ISupportInitialize)TCLogo).BeginInit();
            ThankyouPanel.SuspendLayout();
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
            TCLogo.Location = new Point(128, 65);
            TCLogo.Name = "TCLogo";
            TCLogo.Size = new Size(558, 556);
            TCLogo.TabIndex = 2;
            TCLogo.TabStop = false;
            // 
            // ThankyouPanel
            // 
            ThankyouPanel.BackColor = Color.RosyBrown;
            ThankyouPanel.BackgroundImageLayout = ImageLayout.Stretch;
            ThankyouPanel.Controls.Add(IgLink);
            ThankyouPanel.Controls.Add(GmapLink);
            ThankyouPanel.Controls.Add(FbLink);
            ThankyouPanel.Controls.Add(ThankyouLoginBt);
            ThankyouPanel.Controls.Add(ThankyouLb);
            ThankyouPanel.Location = new Point(893, 74);
            ThankyouPanel.Name = "ThankyouPanel";
            ThankyouPanel.Size = new Size(791, 556);
            ThankyouPanel.TabIndex = 3;
            // 
            // IgLink
            // 
            IgLink.BackgroundImage = (Image)resources.GetObject("IgLink.BackgroundImage");
            IgLink.BackgroundImageLayout = ImageLayout.Stretch;
            IgLink.Cursor = Cursors.Hand;
            IgLink.Location = new Point(545, 384);
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
            GmapLink.Location = new Point(373, 384);
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
            FbLink.Location = new Point(208, 384);
            FbLink.Name = "FbLink";
            FbLink.Size = new Size(43, 43);
            FbLink.TabIndex = 7;
            FbLink.TabStop = false;
            // 
            // ThankyouLoginBt
            // 
            ThankyouLoginBt.BackColor = Color.IndianRed;
            ThankyouLoginBt.Location = new Point(181, 157);
            ThankyouLoginBt.Name = "ThankyouLoginBt";
            ThankyouLoginBt.Size = new Size(433, 151);
            ThankyouLoginBt.TabIndex = 3;
            ThankyouLoginBt.Text = "Proceed to Login";
            ThankyouLoginBt.UseVisualStyleBackColor = false;
            ThankyouLoginBt.Click += ThankyouLoginBt_Click;
            // 
            // ThankyouLb
            // 
            ThankyouLb.AutoSize = true;
            ThankyouLb.BackColor = Color.RosyBrown;
            ThankyouLb.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThankyouLb.Location = new Point(233, 36);
            ThankyouLb.Name = "ThankyouLb";
            ThankyouLb.Size = new Size(346, 32);
            ThankyouLb.TabIndex = 0;
            ThankyouLb.Text = "Thank you For Registering!";
            ThankyouLb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ThankYouForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1813, 694);
            Controls.Add(TCLogo);
            Controls.Add(ThankyouPanel);
            DoubleBuffered = true;
            Name = "ThankYouForm";
            Text = "ThankYouForm";
            ((System.ComponentModel.ISupportInitialize)TCLogo).EndInit();
            ThankyouPanel.ResumeLayout(false);
            ThankyouPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox TCLogo;
        private Panel ThankyouPanel;
        private PictureBox IgLink;
        private PictureBox GmapLink;
        private PictureBox FbLink;
        private Button ThankyouLoginBt;
        private Label ThankyouLb;
    }
}