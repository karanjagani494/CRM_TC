namespace SoftwareEngineering_2024
{
    partial class UserEventsForm
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
            UserEventsLb = new Label();
            UpEventsDg = new DataGridView();
            ViewEventsLinkBt = new Button();
            EventsTodayLb = new Label();
            UpcomingEventsLb = new Label();
            TodayEventsDg = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpEventsDg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TodayEventsDg).BeginInit();
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
            panel2.Size = new Size(234, 806);
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
            QueryBt.Click += QueryBt_Click;
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
            panel1.Controls.Add(UserEventsLb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1851, 49);
            panel1.TabIndex = 18;
            // 
            // UserEventsLb
            // 
            UserEventsLb.Anchor = AnchorStyles.Top;
            UserEventsLb.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserEventsLb.Location = new Point(896, 9);
            UserEventsLb.Name = "UserEventsLb";
            UserEventsLb.Size = new Size(119, 25);
            UserEventsLb.TabIndex = 3;
            UserEventsLb.Text = "Events";
            // 
            // UpEventsDg
            // 
            UpEventsDg.Anchor = AnchorStyles.None;
            UpEventsDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UpEventsDg.Location = new Point(336, 502);
            UpEventsDg.Name = "UpEventsDg";
            UpEventsDg.RowHeadersWidth = 51;
            UpEventsDg.Size = new Size(739, 257);
            UpEventsDg.TabIndex = 23;
            // 
            // ViewEventsLinkBt
            // 
            ViewEventsLinkBt.BackColor = Color.LightCoral;
            ViewEventsLinkBt.Cursor = Cursors.Hand;
            ViewEventsLinkBt.Location = new Point(1534, 390);
            ViewEventsLinkBt.Name = "ViewEventsLinkBt";
            ViewEventsLinkBt.Size = new Size(228, 107);
            ViewEventsLinkBt.TabIndex = 24;
            ViewEventsLinkBt.Text = "View more Events";
            ViewEventsLinkBt.UseVisualStyleBackColor = false;
            ViewEventsLinkBt.Click += ViewEventsLinkBt_Click;
            // 
            // EventsTodayLb
            // 
            EventsTodayLb.Anchor = AnchorStyles.None;
            EventsTodayLb.AutoSize = true;
            EventsTodayLb.BackColor = Color.RosyBrown;
            EventsTodayLb.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            EventsTodayLb.Location = new Point(336, 99);
            EventsTodayLb.Name = "EventsTodayLb";
            EventsTodayLb.Size = new Size(184, 27);
            EventsTodayLb.TabIndex = 25;
            EventsTodayLb.Text = "Events Today";
            // 
            // UpcomingEventsLb
            // 
            UpcomingEventsLb.Anchor = AnchorStyles.None;
            UpcomingEventsLb.AutoSize = true;
            UpcomingEventsLb.BackColor = Color.RosyBrown;
            UpcomingEventsLb.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            UpcomingEventsLb.Location = new Point(336, 457);
            UpcomingEventsLb.Name = "UpcomingEventsLb";
            UpcomingEventsLb.Size = new Size(230, 27);
            UpcomingEventsLb.TabIndex = 26;
            UpcomingEventsLb.Text = "Upcoming Events";
            // 
            // TodayEventsDg
            // 
            TodayEventsDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TodayEventsDg.Location = new Point(336, 138);
            TodayEventsDg.Name = "TodayEventsDg";
            TodayEventsDg.RowHeadersWidth = 51;
            TodayEventsDg.Size = new Size(739, 257);
            TodayEventsDg.TabIndex = 27;
            // 
            // UserEventsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1851, 855);
            Controls.Add(TodayEventsDg);
            Controls.Add(UpcomingEventsLb);
            Controls.Add(EventsTodayLb);
            Controls.Add(ViewEventsLinkBt);
            Controls.Add(UpEventsDg);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "UserEventsForm";
            Text = "UserEventsForm";
            Load += UserEventsForm_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UpEventsDg).EndInit();
            ((System.ComponentModel.ISupportInitialize)TodayEventsDg).EndInit();
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
        private Label UserEventsLb;
        private Label UpcomingEventsLb;
        private Label EventsTodayLb;
        private DataGridView UpEventsDg;
        private Button ViewEventsLinkBt;
        private DataGridView TodayEventsDg;
    }
}