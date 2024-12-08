namespace SoftwareEngineering_2024
{
    partial class UserWorkspacesForm
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
            AvailiblityBt = new Button();
            WsDateDtp = new DateTimePicker();
            CafeBt = new Button();
            ArtRoomBt = new Button();
            LivingRoomBt = new Button();
            TogetherHallBt = new Button();
            TechRoomBt = new Button();
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
            panel2.Size = new Size(234, 618);
            panel2.TabIndex = 21;
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
            panel1.Controls.Add(UserEventsLb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1793, 49);
            panel1.TabIndex = 20;
            // 
            // UserEventsLb
            // 
            UserEventsLb.Anchor = AnchorStyles.Top;
            UserEventsLb.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserEventsLb.Location = new Point(897, 9);
            UserEventsLb.Name = "UserEventsLb";
            UserEventsLb.Size = new Size(198, 25);
            UserEventsLb.TabIndex = 3;
            UserEventsLb.Text = "Workspaces";
            // 
            // AvailiblityBt
            // 
            AvailiblityBt.BackColor = Color.LightCoral;
            AvailiblityBt.Cursor = Cursors.Hand;
            AvailiblityBt.Location = new Point(817, 349);
            AvailiblityBt.Name = "AvailiblityBt";
            AvailiblityBt.Size = new Size(358, 52);
            AvailiblityBt.TabIndex = 6;
            AvailiblityBt.Text = "Show Availability";
            AvailiblityBt.UseVisualStyleBackColor = false;
            AvailiblityBt.Click += btnCheckAvailability_Click;
            // 
            // WsDateDtp
            // 
            WsDateDtp.CalendarMonthBackground = Color.IndianRed;
            WsDateDtp.Location = new Point(880, 257);
            WsDateDtp.Name = "WsDateDtp";
            WsDateDtp.Size = new Size(228, 27);
            WsDateDtp.TabIndex = 27;
            // 
            // CafeBt
            // 
            CafeBt.BackColor = Color.LightCoral;
            CafeBt.Cursor = Cursors.Hand;
            CafeBt.Location = new Point(282, 123);
            CafeBt.Name = "CafeBt";
            CafeBt.Size = new Size(228, 52);
            CafeBt.TabIndex = 28;
            CafeBt.Text = "CAFE";
            CafeBt.UseVisualStyleBackColor = false;
            // 
            // ArtRoomBt
            // 
            ArtRoomBt.BackColor = Color.LightCoral;
            ArtRoomBt.Cursor = Cursors.Hand;
            ArtRoomBt.Location = new Point(1166, 123);
            ArtRoomBt.Name = "ArtRoomBt";
            ArtRoomBt.Size = new Size(228, 52);
            ArtRoomBt.TabIndex = 29;
            ArtRoomBt.Text = "ART ROOM";
            ArtRoomBt.UseVisualStyleBackColor = false;
            // 
            // LivingRoomBt
            // 
            LivingRoomBt.BackColor = Color.LightCoral;
            LivingRoomBt.Cursor = Cursors.Hand;
            LivingRoomBt.Location = new Point(591, 123);
            LivingRoomBt.Name = "LivingRoomBt";
            LivingRoomBt.Size = new Size(228, 52);
            LivingRoomBt.TabIndex = 31;
            LivingRoomBt.Text = "LIVING ROOM";
            LivingRoomBt.UseVisualStyleBackColor = false;
            // 
            // TogetherHallBt
            // 
            TogetherHallBt.BackColor = Color.LightCoral;
            TogetherHallBt.Cursor = Cursors.Hand;
            TogetherHallBt.Location = new Point(1456, 123);
            TogetherHallBt.Name = "TogetherHallBt";
            TogetherHallBt.Size = new Size(228, 52);
            TogetherHallBt.TabIndex = 32;
            TogetherHallBt.Text = "TOGETHER HALL";
            TogetherHallBt.UseVisualStyleBackColor = false;
            // 
            // TechRoomBt
            // 
            TechRoomBt.BackColor = Color.LightCoral;
            TechRoomBt.Cursor = Cursors.Hand;
            TechRoomBt.Location = new Point(880, 123);
            TechRoomBt.Name = "TechRoomBt";
            TechRoomBt.Size = new Size(228, 52);
            TechRoomBt.TabIndex = 33;
            TechRoomBt.Text = "TECH ROOM";
            TechRoomBt.UseVisualStyleBackColor = false;
            // 
            // UserWorkspacesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1793, 667);
            Controls.Add(TechRoomBt);
            Controls.Add(TogetherHallBt);
            Controls.Add(LivingRoomBt);
            Controls.Add(ArtRoomBt);
            Controls.Add(CafeBt);
            Controls.Add(WsDateDtp);
            Controls.Add(AvailiblityBt);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "UserWorkspacesForm";
            Text = "UserWorkspacesForm";
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
        private Label UserEventsLb;
        private Label TogetherHallWsLb;
        private Button AvailiblityBt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker WsDateDtp;
        private Button CafeBt;
        private Button ArtRoomBt;
        private Button button2;
        private Button LivingRoomBt;
        private Button TogetherHallBt;
        private Button TechRoomBt;
    }
}