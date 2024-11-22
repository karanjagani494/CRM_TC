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
            AdminQueryBt = new Button();
            EngagementBt = new Button();
            AdminBookingsBt = new Button();
            MembersBt = new Button();
            StaffEventsBt = new Button();
            AdminHomeBt = new Button();
            panel1 = new Panel();
            AdminBookingsLb = new Label();
            BookingsTableDg = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookingsTableDg).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(AdminQueryBt);
            panel2.Controls.Add(EngagementBt);
            panel2.Controls.Add(AdminBookingsBt);
            panel2.Controls.Add(MembersBt);
            panel2.Controls.Add(StaffEventsBt);
            panel2.Controls.Add(AdminHomeBt);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 573);
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
            panel1.Controls.Add(AdminBookingsLb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1808, 49);
            panel1.TabIndex = 21;
            // 
            // AdminBookingsLb
            // 
            AdminBookingsLb.Anchor = AnchorStyles.Top;
            AdminBookingsLb.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminBookingsLb.Location = new Point(906, 9);
            AdminBookingsLb.Name = "AdminBookingsLb";
            AdminBookingsLb.Size = new Size(147, 25);
            AdminBookingsLb.TabIndex = 3;
            AdminBookingsLb.Text = "Bookings";
            // 
            // BookingsTableDg
            // 
            BookingsTableDg.AllowUserToAddRows = false;
            BookingsTableDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingsTableDg.Location = new Point(267, 95);
            BookingsTableDg.Name = "BookingsTableDg";
            BookingsTableDg.RowHeadersWidth = 51;
            BookingsTableDg.Size = new Size(1454, 303);
            BookingsTableDg.TabIndex = 23;
            // 
            // AdminBookingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1808, 622);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BookingsTableDg);
            DoubleBuffered = true;
            Name = "AdminBookingsForm";
            Text = "AdminBookingsForm";
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
    }
}