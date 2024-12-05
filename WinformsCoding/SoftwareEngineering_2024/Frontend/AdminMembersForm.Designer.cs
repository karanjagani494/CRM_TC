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
            AdminQueryBt = new Button();
            EngagementBt = new Button();
            AdminBookingsBt = new Button();
            MembersBt = new Button();
            StaffEventsBt = new Button();
            AdminHomeBt = new Button();
            panel1 = new Panel();
            adminDALBindingSource = new BindingSource(components);
            MembersTableDg = new DataGridView();
            adminDALBindingSource2 = new BindingSource(components);
            adminDALBindingSource1 = new BindingSource(components);
            AdminMembersLb = new Label();
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
            panel2.Controls.Add(AdminQueryBt);
            panel2.Controls.Add(EngagementBt);
            panel2.Controls.Add(AdminBookingsBt);
            panel2.Controls.Add(MembersBt);
            panel2.Controls.Add(StaffEventsBt);
            panel2.Controls.Add(AdminHomeBt);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 558);
            panel2.TabIndex = 19;
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
            panel1.Controls.Add(AdminMembersLb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1817, 49);
            panel1.TabIndex = 18;
            // 
            // MembersTableDg
            // 
            MembersTableDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MembersTableDg.Location = new Point(258, 74);
            MembersTableDg.Margin = new Padding(3, 4, 3, 4);
            MembersTableDg.Name = "MembersTableDg";
            MembersTableDg.RowHeadersWidth = 51;
            MembersTableDg.Size = new Size(1485, 462);
            MembersTableDg.TabIndex = 22;
            // 
            // AdminMembersLb
            // 
            AdminMembersLb.Anchor = AnchorStyles.Top;
            AdminMembersLb.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminMembersLb.Location = new Point(905, 9);
            AdminMembersLb.Name = "AdminMembersLb";
            AdminMembersLb.Size = new Size(147, 25);
            AdminMembersLb.TabIndex = 4;
            AdminMembersLb.Text = "Members";
            // 
            // AdminMembersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1817, 607);
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
    }
}