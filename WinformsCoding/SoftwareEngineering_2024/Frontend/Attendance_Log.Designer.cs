namespace SoftwareEngineering_2024
{
    partial class Attendance_Log
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
            button2 = new Button();
            panel2 = new Panel();
            AdminQueryBt = new Button();
            EngagementBt = new Button();
            AdminBookingsBt = new Button();
            MembersBt = new Button();
            StaffEventsBt = new Button();
            AdminHomeBt = new Button();
            panel1 = new Panel();
            AdminMembersLb = new Label();
            AttendanceLogTableDg = new DataGridView();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AttendanceLogTableDg).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(232, 156);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(AdminQueryBt);
            panel2.Controls.Add(EngagementBt);
            panel2.Controls.Add(AdminBookingsBt);
            panel2.Controls.Add(MembersBt);
            panel2.Controls.Add(StaffEventsBt);
            panel2.Controls.Add(AdminHomeBt);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 625);
            panel2.TabIndex = 22;
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
            panel1.Controls.Add(AdminMembersLb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1779, 49);
            panel1.TabIndex = 21;
            // 
            // AdminMembersLb
            // 
            AdminMembersLb.Anchor = AnchorStyles.Top;
            AdminMembersLb.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminMembersLb.Location = new Point(820, 9);
            AdminMembersLb.Name = "AdminMembersLb";
            AdminMembersLb.Size = new Size(249, 25);
            AdminMembersLb.TabIndex = 3;
            AdminMembersLb.Text = "Attendance Log";
            AdminMembersLb.Click += AdminMembersLb_Click;
            // 
            // AttendanceLogTableDg
            // 
            AttendanceLogTableDg.AllowUserToAddRows = false;
            AttendanceLogTableDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendanceLogTableDg.Location = new Point(267, 95);
            AttendanceLogTableDg.Name = "AttendanceLogTableDg";
            AttendanceLogTableDg.RowHeadersWidth = 51;
            AttendanceLogTableDg.Size = new Size(1454, 303);
            AttendanceLogTableDg.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(3, 509);
            button1.Name = "button1";
            button1.Size = new Size(228, 52);
            button1.TabIndex = 6;
            button1.Text = "User Queries/Feedback";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Attendance_Log
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1779, 674);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(AttendanceLogTableDg);
            Controls.Add(button2);
            Name = "Attendance_Log";
            Text = "Attendance_Log";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AttendanceLogTableDg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Panel panel2;
        private Button AdminQueryBt;
        private Button EngagementBt;
        private Button AdminBookingsBt;
        private Button MembersBt;
        private Button StaffEventsBt;
        private Button AdminHomeBt;
        private Panel panel1;
        private Label AdminMembersLb;
        private DataGridView AttendanceLogTableDg;
        private Button button1;
    }
}