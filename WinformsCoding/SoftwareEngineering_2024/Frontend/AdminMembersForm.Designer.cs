namespace SoftwareEngineering_2024
{
    partial class AdminMembersForm
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
            components = new System.ComponentModel.Container();
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
            AdminMembersLb = new Label();
            adminDALBindingSource = new BindingSource(components);
            MembersTableDg = new DataGridView();
            adminDALBindingSource2 = new BindingSource(components);
            adminDALBindingSource1 = new BindingSource(components);
            MemQ2Bt = new Button();
            MemQ1Bt = new Button();
            querytxt = new TextBox();
            DeleteRecordBt = new Button();
            DeleteRecordLb = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminDALBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MembersTableDg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminDALBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminDALBindingSource1).BeginInit();
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
            panel2.Size = new Size(235, 738);
            panel2.TabIndex = 19;
            // 
            // Attendance_log_bt
            // 
            Attendance_log_bt.BackColor = Color.LightCoral;
            Attendance_log_bt.Cursor = Cursors.Hand;
            Attendance_log_bt.Location = new Point(0, 512);
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
            AdminQueryBt.Location = new Point(3, 435);
            AdminQueryBt.Name = "AdminQueryBt";
            AdminQueryBt.Size = new Size(229, 52);
            AdminQueryBt.TabIndex = 5;
            AdminQueryBt.Text = "User Queries/Feedback";
            AdminQueryBt.UseVisualStyleBackColor = false;
            // 
            // EngagementBt
            // 
            EngagementBt.BackColor = Color.LightCoral;
            EngagementBt.Cursor = Cursors.Hand;
            EngagementBt.Location = new Point(3, 349);
            EngagementBt.Name = "EngagementBt";
            EngagementBt.Size = new Size(229, 52);
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
            AdminBookingsBt.Size = new Size(229, 52);
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
            MembersBt.Size = new Size(229, 52);
            MembersBt.TabIndex = 2;
            MembersBt.Text = "Members";
            MembersBt.UseVisualStyleBackColor = false;
            // 
            // StaffEventsBt
            // 
            StaffEventsBt.BackColor = Color.LightCoral;
            StaffEventsBt.Cursor = Cursors.Hand;
            StaffEventsBt.Location = new Point(3, 181);
            StaffEventsBt.Name = "StaffEventsBt";
            StaffEventsBt.Size = new Size(229, 52);
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
            AdminHomeBt.Size = new Size(229, 52);
            AdminHomeBt.TabIndex = 0;
            AdminHomeBt.Text = "Home";
            AdminHomeBt.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(LogOutBt);
            panel1.Controls.Add(AdminMembersLb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1815, 49);
            panel1.TabIndex = 18;
            // 
            // LogOutBt
            // 
            LogOutBt.BackColor = Color.LightCoral;
            LogOutBt.Cursor = Cursors.Hand;
            LogOutBt.Location = new Point(1623, 9);
            LogOutBt.Name = "LogOutBt";
            LogOutBt.Size = new Size(182, 32);
            LogOutBt.TabIndex = 27;
            LogOutBt.Text = "Refresh";
            LogOutBt.UseVisualStyleBackColor = false;
            LogOutBt.Click += RefreshBt_Click;
            // 
            // AdminMembersLb
            // 
            AdminMembersLb.Anchor = AnchorStyles.Top;
            AdminMembersLb.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminMembersLb.Location = new Point(904, 9);
            AdminMembersLb.Name = "AdminMembersLb";
            AdminMembersLb.Size = new Size(147, 25);
            AdminMembersLb.TabIndex = 4;
            AdminMembersLb.Text = "Members";
            // 
            // MembersTableDg
            // 
            MembersTableDg.AllowUserToOrderColumns = true;
            MembersTableDg.BackgroundColor = Color.RosyBrown;
            MembersTableDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MembersTableDg.ImeMode = ImeMode.Disable;
            MembersTableDg.Location = new Point(469, 74);
            MembersTableDg.Margin = new Padding(3, 4, 3, 4);
            MembersTableDg.Name = "MembersTableDg";
            MembersTableDg.RowHeadersWidth = 51;
            MembersTableDg.Size = new Size(1088, 331);
            MembersTableDg.TabIndex = 22;
            // 
            // MemQ2Bt
            // 
            MemQ2Bt.BackColor = Color.LightCoral;
            MemQ2Bt.Cursor = Cursors.Hand;
            MemQ2Bt.Location = new Point(1328, 500);
            MemQ2Bt.Name = "MemQ2Bt";
            MemQ2Bt.Size = new Size(229, 52);
            MemQ2Bt.TabIndex = 23;
            MemQ2Bt.Text = "q2";
            MemQ2Bt.UseVisualStyleBackColor = false;
            MemQ2Bt.Click += MemQ2Bt_Click;
            // 
            // MemQ1Bt
            // 
            MemQ1Bt.BackColor = Color.LightCoral;
            MemQ1Bt.Cursor = Cursors.Hand;
            MemQ1Bt.Location = new Point(483, 500);
            MemQ1Bt.Name = "MemQ1Bt";
            MemQ1Bt.Size = new Size(229, 52);
            MemQ1Bt.TabIndex = 24;
            MemQ1Bt.Text = "Q1";
            MemQ1Bt.UseVisualStyleBackColor = false;
            MemQ1Bt.Click += MemQ1Bt_Click;
            // 
            // querytxt
            // 
            querytxt.Location = new Point(698, 629);
            querytxt.Name = "querytxt";
            querytxt.Size = new Size(642, 27);
            querytxt.TabIndex = 25;
            // 
            // DeleteRecordBt
            // 
            DeleteRecordBt.BackColor = Color.LightCoral;
            DeleteRecordBt.Cursor = Cursors.Hand;
            DeleteRecordBt.Location = new Point(904, 683);
            DeleteRecordBt.Name = "DeleteRecordBt";
            DeleteRecordBt.Size = new Size(229, 52);
            DeleteRecordBt.TabIndex = 27;
            DeleteRecordBt.Text = "Delete Record";
            DeleteRecordBt.UseVisualStyleBackColor = false;
            DeleteRecordBt.Click += button3_Click;
            // 
            // DeleteRecordLb
            // 
            DeleteRecordLb.AutoSize = true;
            DeleteRecordLb.BackColor = Color.RosyBrown;
            DeleteRecordLb.Location = new Point(813, 606);
            DeleteRecordLb.Name = "DeleteRecordLb";
            DeleteRecordLb.Size = new Size(390, 20);
            DeleteRecordLb.TabIndex = 28;
            DeleteRecordLb.Text = "Submit the member_id whose record needs to be deleted";
            // 
            // AdminMembersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1815, 787);
            Controls.Add(DeleteRecordLb);
            Controls.Add(DeleteRecordBt);
            Controls.Add(querytxt);
            Controls.Add(MemQ1Bt);
            Controls.Add(MemQ2Bt);
            Controls.Add(MembersTableDg);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            HelpButton = true;
            Name = "AdminMembersForm";
            Text = "Form1";
            Load += AdminMembersForm_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)adminDALBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)MembersTableDg).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminDALBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminDALBindingSource1).EndInit();
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
        private BindingSource adminDALBindingSource;
        private Button button1;
        private DataGridView MembersTableDg;
        private BindingSource adminDALBindingSource1;
        private BindingSource adminDALBindingSource2;
        private Label AdminMembersLb;
        private Button MemQ2Bt;
        private Button MemQ1Bt;
        private TextBox querytxt;
        private Button LogOutBt;
        private Button Attendance_log_bt;
        private Button DeleteRecordBt;
        private Label DeleteRecordLb;
    }
}