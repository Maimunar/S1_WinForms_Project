﻿namespace AdvancedProject1._0
{
    partial class AdminMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            this.tbAnnouncement = new System.Windows.Forms.TextBox();
            this.cbAnnouncementUnits = new System.Windows.Forms.ComboBox();
            this.panelComboBorder = new System.Windows.Forms.Panel();
            this.panelTextBorder = new System.Windows.Forms.Panel();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnHouseRules = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.lblUserSettingTag = new System.Windows.Forms.Label();
            this.lblCalendarTag = new System.Windows.Forms.Label();
            this.lblReportsTag = new System.Windows.Forms.Label();
            this.lblRulesTag = new System.Windows.Forms.Label();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.panelComboBorder.SuspendLayout();
            this.panelTextBorder.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAnnouncement
            // 
            this.tbAnnouncement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbAnnouncement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnnouncement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAnnouncement.Location = new System.Drawing.Point(2, 2);
            this.tbAnnouncement.Multiline = true;
            this.tbAnnouncement.Name = "tbAnnouncement";
            this.tbAnnouncement.Size = new System.Drawing.Size(184, 48);
            this.tbAnnouncement.TabIndex = 21;
            this.tbAnnouncement.Visible = false;
            // 
            // cbAnnouncementUnits
            // 
            this.cbAnnouncementUnits.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbAnnouncementUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnnouncementUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAnnouncementUnits.FormattingEnabled = true;
            this.cbAnnouncementUnits.Location = new System.Drawing.Point(2, 2);
            this.cbAnnouncementUnits.Name = "cbAnnouncementUnits";
            this.cbAnnouncementUnits.Size = new System.Drawing.Size(184, 21);
            this.cbAnnouncementUnits.TabIndex = 22;
            this.cbAnnouncementUnits.Visible = false;
            this.cbAnnouncementUnits.SelectedIndexChanged += new System.EventHandler(this.CbAnnouncementUnits_SelectedIndexChanged);
            // 
            // panelComboBorder
            // 
            this.panelComboBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panelComboBorder.Controls.Add(this.cbAnnouncementUnits);
            this.panelComboBorder.Location = new System.Drawing.Point(75, 436);
            this.panelComboBorder.Name = "panelComboBorder";
            this.panelComboBorder.Size = new System.Drawing.Size(188, 25);
            this.panelComboBorder.TabIndex = 23;
            this.panelComboBorder.Visible = false;
            // 
            // panelTextBorder
            // 
            this.panelTextBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panelTextBorder.Controls.Add(this.tbAnnouncement);
            this.panelTextBorder.Location = new System.Drawing.Point(75, 465);
            this.panelTextBorder.Name = "panelTextBorder";
            this.panelTextBorder.Size = new System.Drawing.Size(188, 52);
            this.panelTextBorder.TabIndex = 24;
            this.panelTextBorder.Visible = false;
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.BackgroundImage = global::AdvancedProject1._0.Properties.Resources.Megaphone;
            this.btnAnnouncements.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnouncements.FlatAppearance.BorderSize = 0;
            this.btnAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnouncements.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnnouncements.ForeColor = System.Drawing.Color.Transparent;
            this.btnAnnouncements.Location = new System.Drawing.Point(12, 465);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(50, 50);
            this.btnAnnouncements.TabIndex = 20;
            this.btnAnnouncements.Tag = "Announce";
            this.toolTips.SetToolTip(this.btnAnnouncements, "Announce");
            this.btnAnnouncements.UseVisualStyleBackColor = true;
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 174);
            this.panel1.TabIndex = 19;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWelcome.Location = new System.Drawing.Point(195, 55);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(576, 65);
            this.lblWelcome.TabIndex = 18;
            this.lblWelcome.Text = "Welcome, Administrator!\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(58, 29);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(84)))), ((int)(((byte)(151)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(795, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(40, 40);
            this.btnLogout.TabIndex = 12;
            this.toolTips.SetToolTip(this.btnLogout, "Logout");
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNew.BackgroundImage")));
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Location = new System.Drawing.Point(91, 252);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(120, 120);
            this.btnAddNew.TabIndex = 15;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnHouseRules
            // 
            this.btnHouseRules.BackColor = System.Drawing.Color.Transparent;
            this.btnHouseRules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHouseRules.BackgroundImage")));
            this.btnHouseRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHouseRules.FlatAppearance.BorderSize = 0;
            this.btnHouseRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHouseRules.Location = new System.Drawing.Point(631, 252);
            this.btnHouseRules.Name = "btnHouseRules";
            this.btnHouseRules.Size = new System.Drawing.Size(120, 120);
            this.btnHouseRules.TabIndex = 13;
            this.btnHouseRules.UseVisualStyleBackColor = false;
            this.btnHouseRules.Click += new System.EventHandler(this.btnHouseRules_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalendar.BackgroundImage")));
            this.btnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Location = new System.Drawing.Point(271, 252);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(120, 120);
            this.btnCalendar.TabIndex = 10;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReports.BackgroundImage")));
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Location = new System.Drawing.Point(451, 252);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(120, 120);
            this.btnReports.TabIndex = 8;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // lblUserSettingTag
            // 
            this.lblUserSettingTag.AutoSize = true;
            this.lblUserSettingTag.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserSettingTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.lblUserSettingTag.Location = new System.Drawing.Point(86, 370);
            this.lblUserSettingTag.Name = "lblUserSettingTag";
            this.lblUserSettingTag.Size = new System.Drawing.Size(134, 25);
            this.lblUserSettingTag.TabIndex = 25;
            this.lblUserSettingTag.Text = "User settings";
            // 
            // lblCalendarTag
            // 
            this.lblCalendarTag.AutoSize = true;
            this.lblCalendarTag.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalendarTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.lblCalendarTag.Location = new System.Drawing.Point(283, 370);
            this.lblCalendarTag.Name = "lblCalendarTag";
            this.lblCalendarTag.Size = new System.Drawing.Size(95, 25);
            this.lblCalendarTag.TabIndex = 26;
            this.lblCalendarTag.Text = "Calendar";
            // 
            // lblReportsTag
            // 
            this.lblReportsTag.AutoSize = true;
            this.lblReportsTag.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReportsTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.lblReportsTag.Location = new System.Drawing.Point(466, 370);
            this.lblReportsTag.Name = "lblReportsTag";
            this.lblReportsTag.Size = new System.Drawing.Size(85, 25);
            this.lblReportsTag.TabIndex = 27;
            this.lblReportsTag.Text = "Reports";
            // 
            // lblRulesTag
            // 
            this.lblRulesTag.AutoSize = true;
            this.lblRulesTag.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRulesTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.lblRulesTag.Location = new System.Drawing.Point(629, 370);
            this.lblRulesTag.Name = "lblRulesTag";
            this.lblRulesTag.Size = new System.Drawing.Size(122, 25);
            this.lblRulesTag.TabIndex = 28;
            this.lblRulesTag.Text = "House rules";
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(846, 523);
            this.Controls.Add(this.panelTextBorder);
            this.Controls.Add(this.panelComboBorder);
            this.Controls.Add(this.btnAnnouncements);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnHouseRules);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.lblCalendarTag);
            this.Controls.Add(this.lblReportsTag);
            this.Controls.Add(this.lblRulesTag);
            this.Controls.Add(this.lblUserSettingTag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(861, 561);
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMain_FormClosing);
            this.Click += new System.EventHandler(this.AdminMain_Click);
            this.panelComboBorder.ResumeLayout(false);
            this.panelTextBorder.ResumeLayout(false);
            this.panelTextBorder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHouseRules;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAnnouncements;
        private System.Windows.Forms.TextBox tbAnnouncement;
        private System.Windows.Forms.ComboBox cbAnnouncementUnits;
        private System.Windows.Forms.Panel panelComboBorder;
        private System.Windows.Forms.Panel panelTextBorder;
        private System.Windows.Forms.Label lblUserSettingTag;
        private System.Windows.Forms.Label lblCalendarTag;
        private System.Windows.Forms.Label lblReportsTag;
        private System.Windows.Forms.Label lblRulesTag;
        private System.Windows.Forms.ToolTip toolTips;
    }
}