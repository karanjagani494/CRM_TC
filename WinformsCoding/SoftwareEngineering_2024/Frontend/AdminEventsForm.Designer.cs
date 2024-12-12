namespace SoftwareEngineering_2024
{
    partial class AdminEventsForm
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
            Attendance_log_bt = new Button();
            AdminQueryBt = new Button();
            EngagementBt = new Button();
            AdminBookingsBt = new Button();
            MembersBt = new Button();
            StaffEventsBt = new Button();
            AdminHomeBt = new Button();
            panel1 = new Panel();
            LogOutBt = new Button();
            AdminEventsLb = new Label();
            EventsTableDg = new DataGridView();
            MemQuerySubmitBt = new Button();
            querytxt = new TextBox();
            MemQ1Bt = new Button();
            Q2 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EventsTableDg).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(Attendance_log_bt);
            panel2.Controls.Add(AdminQueryBt);
            panel2.Controls.Add(EngagementBt);
            panel2.Controls.Add(AdminBookingsBt);
            panel2.Controls.Add(MembersBt);
            panel2.Controls.Add(StaffEventsBt);
            panel2.Controls.Add(AdminHomeBt);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 856);
            panel2.TabIndex = 22;
            // 
            // Attendance_log_bt
            // 
            Attendance_log_bt.BackColor = Color.LightCoral;
            Attendance_log_bt.Cursor = Cursors.Hand;
            Attendance_log_bt.Location = new Point(3, 519);
            Attendance_log_bt.Name = "Attendance_log_bt";
            Attendance_log_bt.Size = new Size(228, 52);
            Attendance_log_bt.TabIndex = 7;
            Attendance_log_bt.Text = "Attendance Log";
            Attendance_log_bt.UseVisualStyleBackColor = false;
            // 
            // AdminQueryBt
            // 
            AdminQueryBt.BackColor = Color.LightCoral;
            AdminQueryBt.Cursor = Cursors.Hand;
            AdminQueryBt.Location = new Point(3, 434);
            AdminQueryBt.Name = "AdminQueryBt";
            AdminQueryBt.Size = new Size(228, 52);
            AdminQueryBt.TabIndex = 5;
            AdminQueryBt.Text = "User Queries/Feedback";
            AdminQueryBt.UseVisualStyleBackColor = false;
            // 
            // EngagementBt
            // 
            EngagementBt.BackColor = Color.LightCoral;
            EngagementBt.Cursor = Cursors.Hand;
            EngagementBt.Location = new Point(3, 350);
            EngagementBt.Name = "EngagementBt";
            EngagementBt.Size = new Size(228, 52);
            EngagementBt.TabIndex = 4;
            EngagementBt.Text = "Engagement Data";
            EngagementBt.UseVisualStyleBackColor = false;
            // 
            // AdminBookingsBt
            // 
            AdminBookingsBt.BackColor = Color.LightCoral;
            AdminBookingsBt.Cursor = Cursors.Hand;
            AdminBookingsBt.Location = new Point(3, 265);
            AdminBookingsBt.Name = "AdminBookingsBt";
            AdminBookingsBt.Size = new Size(228, 52);
            AdminBookingsBt.TabIndex = 3;
            AdminBookingsBt.Text = "User Bookings/Payments";
            AdminBookingsBt.UseVisualStyleBackColor = false;
            // 
            // MembersBt
            // 
            MembersBt.BackColor = Color.LightCoral;
            MembersBt.Cursor = Cursors.Hand;
            MembersBt.Location = new Point(3, 101);
            MembersBt.Name = "MembersBt";
            MembersBt.Size = new Size(228, 52);
            MembersBt.TabIndex = 2;
            MembersBt.Text = "Members";
            MembersBt.UseVisualStyleBackColor = false;
            // 
            // StaffEventsBt
            // 
            StaffEventsBt.BackColor = Color.LightCoral;
            StaffEventsBt.Cursor = Cursors.Hand;
            StaffEventsBt.Location = new Point(3, 182);
            StaffEventsBt.Name = "StaffEventsBt";
            StaffEventsBt.Size = new Size(228, 52);
            StaffEventsBt.TabIndex = 1;
            StaffEventsBt.Text = "Events";
            StaffEventsBt.UseVisualStyleBackColor = false;
            // 
            // AdminHomeBt
            // 
            AdminHomeBt.BackColor = Color.LightCoral;
            AdminHomeBt.Cursor = Cursors.Hand;
            AdminHomeBt.Location = new Point(3, 25);
            AdminHomeBt.Name = "AdminHomeBt";
            AdminHomeBt.Size = new Size(228, 52);
            AdminHomeBt.TabIndex = 0;
            AdminHomeBt.Text = "Home";
            AdminHomeBt.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(LogOutBt);
            panel1.Controls.Add(AdminEventsLb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1857, 49);
            panel1.TabIndex = 21;
            // 
            // LogOutBt
            // 
            LogOutBt.BackColor = Color.LightCoral;
            LogOutBt.Cursor = Cursors.Hand;
            LogOutBt.Location = new Point(1632, 9);
            LogOutBt.Name = "LogOutBt";
            LogOutBt.Size = new Size(182, 32);
            LogOutBt.TabIndex = 24;
            LogOutBt.Text = "Refresh";
            LogOutBt.UseVisualStyleBackColor = false;
            LogOutBt.Click += RefreshBt_Click;
            // 
            // AdminEventsLb
            // 
            AdminEventsLb.Anchor = AnchorStyles.Top;
            AdminEventsLb.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminEventsLb.Location = new Point(996, 9);
            AdminEventsLb.Name = "AdminEventsLb";
            AdminEventsLb.Size = new Size(147, 25);
            AdminEventsLb.TabIndex = 3;
            AdminEventsLb.Text = "Events";
            // 
            // EventsTableDg
            // 
            EventsTableDg.AllowUserToAddRows = false;
            EventsTableDg.BackgroundColor = Color.RosyBrown;
            EventsTableDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventsTableDg.GridColor = Color.IndianRed;
            EventsTableDg.Location = new Point(608, 93);
            EventsTableDg.Name = "EventsTableDg";
            EventsTableDg.RowHeadersWidth = 51;
            EventsTableDg.Size = new Size(821, 303);
            EventsTableDg.TabIndex = 23;
            // 
            // MemQuerySubmitBt
            // 
            MemQuerySubmitBt.BackColor = Color.LightCoral;
            MemQuerySubmitBt.Cursor = Cursors.Hand;
            MemQuerySubmitBt.Location = new Point(873, 784);
            MemQuerySubmitBt.Name = "MemQuerySubmitBt";
            MemQuerySubmitBt.Size = new Size(229, 52);
            MemQuerySubmitBt.TabIndex = 30;
            MemQuerySubmitBt.Text = "Enter";
            MemQuerySubmitBt.UseVisualStyleBackColor = false;
            MemQuerySubmitBt.Click += MemQuerySubmitBt_Click;
            // 
            // querytxt
            // 
            querytxt.Location = new Point(667, 722);
            querytxt.Name = "querytxt";
            querytxt.Size = new Size(642, 27);
            querytxt.TabIndex = 29;
            // 
            // MemQ1Bt
            // 
            MemQ1Bt.BackColor = Color.LightCoral;
            MemQ1Bt.Cursor = Cursors.Hand;
            MemQ1Bt.Location = new Point(448, 616);
            MemQ1Bt.Name = "MemQ1Bt";
            MemQ1Bt.Size = new Size(229, 52);
            MemQ1Bt.TabIndex = 28;
            MemQ1Bt.Text = "Q1";
            MemQ1Bt.UseVisualStyleBackColor = false;
            MemQ1Bt.Click += MemQ1Bt_Click;
            // 
            // Q2
            // 
            Q2.BackColor = Color.LightCoral;
            Q2.Cursor = Cursors.Hand;
            Q2.Location = new Point(1443, 616);
            Q2.Name = "Q2";
            Q2.Size = new Size(229, 52);
            Q2.TabIndex = 31;
            Q2.Text = "Q2";
            Q2.UseVisualStyleBackColor = false;
            Q2.Click += Q2_Click;
            // 
            // AdminEventsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1857, 905);
            Controls.Add(Q2);
            Controls.Add(MemQuerySubmitBt);
            Controls.Add(querytxt);
            Controls.Add(MemQ1Bt);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(EventsTableDg);
            DoubleBuffered = true;
            Name = "AdminEventsForm";
            Text = "AdminEventsForm";
            Load += AdminEventsForm_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EventsTableDg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button AdminQueryBt;
        private Button EngagementBt;
        private Button AdminBookingsBt;
        private Button MembersBt;
        private Button StaffEventsBt;
        private Button AdminHomeBt;
        private Panel panel1;
        private Label AdminEventsLb;
        private DataGridView EventsTableDg;
        private Button LogOutBt;
        private Button MemQuerySubmitBt;
        private TextBox querytxt;
        private Button MemQ1Bt;
        private Button MemQ2Bt;
        private Button Attendance_log_bt;
        private Button Q2;
    }
}