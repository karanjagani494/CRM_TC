namespace SoftwareEngineering_2024
{
    partial class UserQueriesFeedbackForm
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
            panel2 = new Panel();
            QueryBt = new Button();
            SpaceBt = new Button();
            MyBookingsBt = new Button();
            MembershipsBt = new Button();
            EventsBt = new Button();
            HomeBt = new Button();
            panel1 = new Panel();
            UserQueryFeedbackLb = new Label();
            QueryTypeCb = new ComboBox();
            QueryTb = new RichTextBox();
            QuerySubmitBt = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(QueryBt);
            panel2.Controls.Add(SpaceBt);
            panel2.Controls.Add(MyBookingsBt);
            panel2.Controls.Add(MembershipsBt);
            panel2.Controls.Add(EventsBt);
            panel2.Controls.Add(HomeBt);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 844);
            panel2.TabIndex = 19;
            // 
            // QueryBt
            // 
            QueryBt.BackColor = Color.LightCoral;
            QueryBt.Cursor = Cursors.Hand;
            QueryBt.Location = new Point(3, 560);
            QueryBt.Name = "QueryBt";
            QueryBt.Size = new Size(228, 52);
            QueryBt.TabIndex = 5;
            QueryBt.Text = "Queries/Feedback";
            QueryBt.UseVisualStyleBackColor = false;
            // 
            // SpaceBt
            // 
            SpaceBt.BackColor = Color.LightCoral;
            SpaceBt.Cursor = Cursors.Hand;
            SpaceBt.Location = new Point(3, 453);
            SpaceBt.Name = "SpaceBt";
            SpaceBt.Size = new Size(228, 52);
            SpaceBt.TabIndex = 4;
            SpaceBt.Text = "Workspaces";
            SpaceBt.UseVisualStyleBackColor = false;
            // 
            // MyBookingsBt
            // 
            MyBookingsBt.BackColor = Color.LightCoral;
            MyBookingsBt.Cursor = Cursors.Hand;
            MyBookingsBt.Location = new Point(3, 351);
            MyBookingsBt.Name = "MyBookingsBt";
            MyBookingsBt.Size = new Size(228, 52);
            MyBookingsBt.TabIndex = 3;
            MyBookingsBt.Text = "My Bookings/Payments";
            MyBookingsBt.UseVisualStyleBackColor = false;
            // 
            // MembershipsBt
            // 
            MembershipsBt.BackColor = Color.LightCoral;
            MembershipsBt.Cursor = Cursors.Hand;
            MembershipsBt.Location = new Point(3, 129);
            MembershipsBt.Name = "MembershipsBt";
            MembershipsBt.Size = new Size(228, 52);
            MembershipsBt.TabIndex = 2;
            MembershipsBt.Text = "Memberships";
            MembershipsBt.UseVisualStyleBackColor = false;
            // 
            // EventsBt
            // 
            EventsBt.BackColor = Color.LightCoral;
            EventsBt.Cursor = Cursors.Hand;
            EventsBt.Location = new Point(3, 241);
            EventsBt.Name = "EventsBt";
            EventsBt.Size = new Size(228, 52);
            EventsBt.TabIndex = 1;
            EventsBt.Text = "Events";
            EventsBt.UseVisualStyleBackColor = false;
            // 
            // HomeBt
            // 
            HomeBt.BackColor = Color.LightCoral;
            HomeBt.Cursor = Cursors.Hand;
            HomeBt.Location = new Point(3, 25);
            HomeBt.Name = "HomeBt";
            HomeBt.Size = new Size(228, 52);
            HomeBt.TabIndex = 0;
            HomeBt.Text = "Home";
            HomeBt.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(UserQueryFeedbackLb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1850, 49);
            panel1.TabIndex = 18;
            // 
            // UserQueryFeedbackLb
            // 
            UserQueryFeedbackLb.Anchor = AnchorStyles.Top;
            UserQueryFeedbackLb.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserQueryFeedbackLb.Location = new Point(800, 9);
            UserQueryFeedbackLb.Name = "UserQueryFeedbackLb";
            UserQueryFeedbackLb.Size = new Size(282, 25);
            UserQueryFeedbackLb.TabIndex = 3;
            UserQueryFeedbackLb.Text = "Queries/Feedback";
            // 
            // QueryTypeCb
            // 
            QueryTypeCb.FormattingEnabled = true;
            QueryTypeCb.Items.AddRange(new object[] { "General Query", "Membership Query", "Upgrade Membership Query", "Cancel Membership Query", "General Feedback" });
            QueryTypeCb.Location = new Point(284, 87);
            QueryTypeCb.Name = "QueryTypeCb";
            QueryTypeCb.Size = new Size(151, 28);
            QueryTypeCb.TabIndex = 20;
            QueryTypeCb.Text = "Query Type";
            // 
            // QueryTb
            // 
            QueryTb.Location = new Point(284, 178);
            QueryTb.Name = "QueryTb";
            QueryTb.Size = new Size(1257, 252);
            QueryTb.TabIndex = 21;
            QueryTb.Text = "";
            // 
            // QuerySubmitBt
            // 
            QuerySubmitBt.BackColor = Color.LightCoral;
            QuerySubmitBt.Cursor = Cursors.Hand;
            QuerySubmitBt.Location = new Point(284, 502);
            QuerySubmitBt.Name = "QuerySubmitBt";
            QuerySubmitBt.Size = new Size(228, 52);
            QuerySubmitBt.TabIndex = 22;
            QuerySubmitBt.Text = "Submit";
            QuerySubmitBt.UseVisualStyleBackColor = false;
            QuerySubmitBt.Click += QuerySubmitBt_Click;
            // 
            // UserQueriesFeedbackForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1850, 893);
            Controls.Add(QuerySubmitBt);
            Controls.Add(QueryTb);
            Controls.Add(QueryTypeCb);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "UserQueriesFeedbackForm";
            Text = "Queries/Feedback";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button QueryBt;
        private Button SpaceBt;
        private Button MyBookingsBt;
        private Button MembershipsBt;
        private Button EventsBt;
        private Button HomeBt;
        private Panel panel1;
        private Label UserQueryFeedbackLb;
        private ComboBox QueryTypeCb;
        private RichTextBox QueryTb;
        private Button QuerySubmitBt;
    }
}