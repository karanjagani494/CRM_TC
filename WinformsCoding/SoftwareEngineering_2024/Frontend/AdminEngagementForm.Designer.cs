namespace SoftwareEngineering_2024
{
    partial class AdminEngagementForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel2 = new Panel();
            AdminQueryBt = new Button();
            EngagementBt = new Button();
            AdminBookingsBt = new Button();
            MembersBt = new Button();
            StaffEventsBt = new Button();
            AdminHomeBt = new Button();
            panel1 = new Panel();
            LogOutBt = new Button();
            AdminEngagementLb = new Label();
            EngagementsTableDg = new DataGridView();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Attendance_log_bt = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EngagementsTableDg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
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
            panel2.Size = new Size(234, 685);
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
            panel1.Controls.Add(LogOutBt);
            panel1.Controls.Add(AdminEngagementLb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1815, 49);
            panel1.TabIndex = 21;
            // 
            // LogOutBt
            // 
            LogOutBt.BackColor = Color.LightCoral;
            LogOutBt.Cursor = Cursors.Hand;
            LogOutBt.Location = new Point(1660, 9);
            LogOutBt.Name = "LogOutBt";
            LogOutBt.Size = new Size(182, 32);
            LogOutBt.TabIndex = 25;
            LogOutBt.Text = "Refresh";
            LogOutBt.UseVisualStyleBackColor = false;
            LogOutBt.Click += RefreshBt_Click;
            // 
            // AdminEngagementLb
            // 
            AdminEngagementLb.Anchor = AnchorStyles.Top;
            AdminEngagementLb.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminEngagementLb.Location = new Point(909, 9);
            AdminEngagementLb.Name = "AdminEngagementLb";
            AdminEngagementLb.Size = new Size(271, 25);
            AdminEngagementLb.TabIndex = 3;
            AdminEngagementLb.Text = "Engagement Data";
            // 
            // EngagementsTableDg
            // 
            EngagementsTableDg.AllowUserToAddRows = false;
            EngagementsTableDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EngagementsTableDg.Location = new Point(280, 55);
            EngagementsTableDg.Name = "EngagementsTableDg";
            EngagementsTableDg.RowHeadersWidth = 51;
            EngagementsTableDg.Size = new Size(1454, 303);
            EngagementsTableDg.TabIndex = 23;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(412, 364);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(375, 375);
            chart1.TabIndex = 24;
            chart1.Text = "chart1";
            // 
            // Attendance_log_bt
            // 
            Attendance_log_bt.BackColor = Color.LightCoral;
            Attendance_log_bt.Cursor = Cursors.Hand;
            Attendance_log_bt.Location = new Point(0, 504);
            Attendance_log_bt.Name = "Attendance_log_bt";
            Attendance_log_bt.Size = new Size(228, 52);
            Attendance_log_bt.TabIndex = 26;
            Attendance_log_bt.Text = "Attendance Log";
            Attendance_log_bt.UseVisualStyleBackColor = false;
            // 
            // AdminEngagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_1036481;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1815, 734);
            Controls.Add(chart1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(EngagementsTableDg);
            DoubleBuffered = true;
            Name = "AdminEngagementForm";
            Text = "AdminEngagementForm";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EngagementsTableDg).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
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
        private Label AdminEngagementLb;
        private DataGridView EngagementsTableDg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button LogOutBt;
        private Button Attendance_log_bt;
    }
}