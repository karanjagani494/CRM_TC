namespace SoftwareEngineering_2024
{
    partial class AdminBookingsForm
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
            AdminBookingsLb = new Label();
            BookingsTableDg = new DataGridView();
            Q2 = new Button();
            MemQuerySubmitBt = new Button();
            querytxt = new TextBox();
            MemQ1Bt = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookingsTableDg).BeginInit();
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
            panel2.Size = new Size(234, 734);
            panel2.TabIndex = 22;
            // 
            // Attendance_log_bt
            // 
            Attendance_log_bt.BackColor = Color.LightCoral;
            Attendance_log_bt.Cursor = Cursors.Hand;
            Attendance_log_bt.Location = new Point(3, 509);
            Attendance_log_bt.Name = "Attendance_log_bt";
            Attendance_log_bt.Size = new Size(228, 52);
            Attendance_log_bt.TabIndex = 24;
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
            panel1.Controls.Add(AdminBookingsLb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1782, 49);
            panel1.TabIndex = 21;
            // 
            // LogOutBt
            // 
            LogOutBt.BackColor = Color.LightCoral;
            LogOutBt.Cursor = Cursors.Hand;
            LogOutBt.Location = new Point(1622, 9);
            LogOutBt.Name = "LogOutBt";
            LogOutBt.Size = new Size(182, 32);
            LogOutBt.TabIndex = 6;
            LogOutBt.Text = "Refresh";
            LogOutBt.UseVisualStyleBackColor = false;
            LogOutBt.Click += LogOutBt_Click;
            // 
            // AdminBookingsLb
            // 
            AdminBookingsLb.Anchor = AnchorStyles.Top;
            AdminBookingsLb.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminBookingsLb.Location = new Point(893, 9);
            AdminBookingsLb.Name = "AdminBookingsLb";
            AdminBookingsLb.Size = new Size(147, 25);
            AdminBookingsLb.TabIndex = 3;
            AdminBookingsLb.Text = "Bookings";
            // 
            // BookingsTableDg
            // 
            BookingsTableDg.AllowUserToAddRows = false;
            BookingsTableDg.BackgroundColor = Color.RosyBrown;
            BookingsTableDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingsTableDg.GridColor = Color.IndianRed;
            BookingsTableDg.Location = new Point(609, 74);
            BookingsTableDg.Name = "BookingsTableDg";
            BookingsTableDg.RowHeadersWidth = 51;
            BookingsTableDg.Size = new Size(709, 342);
            BookingsTableDg.TabIndex = 23;
            // 
            // Q2
            // 
            Q2.BackColor = Color.LightCoral;
            Q2.Cursor = Cursors.Hand;
            Q2.Location = new Point(1298, 535);
            Q2.Name = "Q2";
            Q2.Size = new Size(229, 52);
            Q2.TabIndex = 35;
            Q2.Text = "Q2";
            Q2.UseVisualStyleBackColor = false;
            Q2.Click += Q2_Click;
            // 
            // MemQuerySubmitBt
            // 
            MemQuerySubmitBt.BackColor = Color.LightCoral;
            MemQuerySubmitBt.Cursor = Cursors.Hand;
            MemQuerySubmitBt.Location = new Point(879, 703);
            MemQuerySubmitBt.Name = "MemQuerySubmitBt";
            MemQuerySubmitBt.Size = new Size(229, 52);
            MemQuerySubmitBt.TabIndex = 34;
            MemQuerySubmitBt.Text = "Enter";
            MemQuerySubmitBt.UseVisualStyleBackColor = false;
            MemQuerySubmitBt.Click += MemQuerySubmitBt_Click;
            // 
            // querytxt
            // 
            querytxt.Location = new Point(673, 641);
            querytxt.Name = "querytxt";
            querytxt.Size = new Size(642, 27);
            querytxt.TabIndex = 33;
            // 
            // MemQ1Bt
            // 
            MemQ1Bt.BackColor = Color.LightCoral;
            MemQ1Bt.Cursor = Cursors.Hand;
            MemQ1Bt.Location = new Point(454, 535);
            MemQ1Bt.Name = "MemQ1Bt";
            MemQ1Bt.Size = new Size(229, 52);
            MemQ1Bt.TabIndex = 32;
            MemQ1Bt.Text = "Q1";
            MemQ1Bt.UseVisualStyleBackColor = false;
            MemQ1Bt.Click += MemQ1Bt_Click;
            // 
            // AdminBookingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1782, 783);
            Controls.Add(Q2);
            Controls.Add(MemQuerySubmitBt);
            Controls.Add(querytxt);
            Controls.Add(MemQ1Bt);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BookingsTableDg);
            DoubleBuffered = true;
            Name = "AdminBookingsForm";
            Text = "AdminBookingsForm";
            Load += AdminBookingForm_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BookingsTableDg).EndInit();
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
        private Label AdminBookingsLb;
        private DataGridView BookingsTableDg;
        private Button LogOutBt;
        private Button Attendance_log_bt;
        private Button Q2;
        private Button MemQuerySubmitBt;
        private TextBox querytxt;
        private Button MemQ1Bt;
    }
}