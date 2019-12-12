﻿namespace AdvancedProject1._0
{
    partial class AdminAdd
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.cmbHouseUnits = new System.Windows.Forms.ComboBox();
            this.cmbUserList = new System.Windows.Forms.ComboBox();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.cbShowHide = new System.Windows.Forms.CheckBox();
            this.btnAddNewTenant = new System.Windows.Forms.Button();
            this.lblHouseUnit = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tabHouseUnit = new System.Windows.Forms.TabPage();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.tbUnitID = new System.Windows.Forms.TextBox();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabHouseUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Controls.Add(this.tabHouseUnit);
            this.tabControl1.Location = new System.Drawing.Point(11, 52);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 290);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.cmbHouseUnits);
            this.tabUser.Controls.Add(this.cmbUserList);
            this.tabUser.Controls.Add(this.btnRemoveUser);
            this.tabUser.Controls.Add(this.cbAdmin);
            this.tabUser.Controls.Add(this.cbShowHide);
            this.tabUser.Controls.Add(this.btnAddNewTenant);
            this.tabUser.Controls.Add(this.lblHouseUnit);
            this.tabUser.Controls.Add(this.tbLastName);
            this.tabUser.Controls.Add(this.lblLastName);
            this.tabUser.Controls.Add(this.tbFirstName);
            this.tabUser.Controls.Add(this.lblFirstName);
            this.tabUser.Controls.Add(this.tbPassword);
            this.tabUser.Controls.Add(this.lblPassword);
            this.tabUser.Controls.Add(this.tbUsername);
            this.tabUser.Controls.Add(this.lblUsername);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUser.Size = new System.Drawing.Size(553, 264);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User Controls";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // cmbHouseUnits
            // 
            this.cmbHouseUnits.FormattingEnabled = true;
            this.cmbHouseUnits.Location = new System.Drawing.Point(117, 158);
            this.cmbHouseUnits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbHouseUnits.Name = "cmbHouseUnits";
            this.cmbHouseUnits.Size = new System.Drawing.Size(114, 21);
            this.cmbHouseUnits.TabIndex = 15;
            this.cmbHouseUnits.DropDown += new System.EventHandler(this.cmbHouseUnits_DropDown);
            // 
            // cmbUserList
            // 
            this.cmbUserList.FormattingEnabled = true;
            this.cmbUserList.Location = new System.Drawing.Point(397, 17);
            this.cmbUserList.Name = "cmbUserList";
            this.cmbUserList.Size = new System.Drawing.Size(144, 21);
            this.cmbUserList.TabIndex = 14;
            this.cmbUserList.DropDown += new System.EventHandler(this.cmbUserList_DropDown);
            this.cmbUserList.SelectedIndexChanged += new System.EventHandler(this.CmbUserList_SelectedIndexChanged);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(397, 57);
            this.btnRemoveUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(143, 39);
            this.btnRemoveUser.TabIndex = 13;
            this.btnRemoveUser.Text = "Remove";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(117, 13);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(86, 17);
            this.cbAdmin.TabIndex = 12;
            this.cbAdmin.Text = "Administrator";
            this.cbAdmin.UseVisualStyleBackColor = true;
            this.cbAdmin.CheckedChanged += new System.EventHandler(this.cbAdmin_CheckedChanged);
            // 
            // cbShowHide
            // 
            this.cbShowHide.AutoSize = true;
            this.cbShowHide.Location = new System.Drawing.Point(243, 58);
            this.cbShowHide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbShowHide.Name = "cbShowHide";
            this.cbShowHide.Size = new System.Drawing.Size(53, 17);
            this.cbShowHide.TabIndex = 11;
            this.cbShowHide.Text = "Show";
            this.cbShowHide.UseVisualStyleBackColor = true;
            this.cbShowHide.CheckedChanged += new System.EventHandler(this.cbShowHide_CheckedChanged);
            // 
            // btnAddNewTenant
            // 
            this.btnAddNewTenant.Location = new System.Drawing.Point(117, 204);
            this.btnAddNewTenant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewTenant.Name = "btnAddNewTenant";
            this.btnAddNewTenant.Size = new System.Drawing.Size(113, 32);
            this.btnAddNewTenant.TabIndex = 10;
            this.btnAddNewTenant.Text = "Add";
            this.btnAddNewTenant.UseVisualStyleBackColor = true;
            this.btnAddNewTenant.Click += new System.EventHandler(this.btnAddNewTenant_Click);
            // 
            // lblHouseUnit
            // 
            this.lblHouseUnit.AutoSize = true;
            this.lblHouseUnit.Location = new System.Drawing.Point(44, 161);
            this.lblHouseUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHouseUnit.Name = "lblHouseUnit";
            this.lblHouseUnit.Size = new System.Drawing.Size(63, 13);
            this.lblHouseUnit.TabIndex = 8;
            this.lblHouseUnit.Text = "House Unit:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(117, 121);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(114, 20);
            this.tbLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(44, 121);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(117, 99);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(114, 20);
            this.tbFirstName.TabIndex = 5;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(44, 99);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(117, 58);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(114, 20);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(44, 58);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(117, 35);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(114, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(44, 35);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // tabHouseUnit
            // 
            this.tabHouseUnit.Controls.Add(this.tbCapacity);
            this.tabHouseUnit.Controls.Add(this.label2);
            this.tabHouseUnit.Controls.Add(this.tbAddress);
            this.tabHouseUnit.Controls.Add(this.label1);
            this.tabHouseUnit.Controls.Add(this.btnAddUnit);
            this.tabHouseUnit.Controls.Add(this.tbUnitID);
            this.tabHouseUnit.Controls.Add(this.lblUnitID);
            this.tabHouseUnit.Location = new System.Drawing.Point(4, 22);
            this.tabHouseUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHouseUnit.Name = "tabHouseUnit";
            this.tabHouseUnit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabHouseUnit.Size = new System.Drawing.Size(553, 264);
            this.tabHouseUnit.TabIndex = 1;
            this.tabHouseUnit.Text = "Add House Unit";
            this.tabHouseUnit.UseVisualStyleBackColor = true;
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(117, 136);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(100, 20);
            this.tbCapacity.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Capacity:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(117, 93);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address:";
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Location = new System.Drawing.Point(117, 202);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(104, 40);
            this.btnAddUnit.TabIndex = 2;
            this.btnAddUnit.Text = "Add";
            this.btnAddUnit.UseVisualStyleBackColor = true;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // tbUnitID
            // 
            this.tbUnitID.Location = new System.Drawing.Point(117, 46);
            this.tbUnitID.Name = "tbUnitID";
            this.tbUnitID.Size = new System.Drawing.Size(100, 20);
            this.tbUnitID.TabIndex = 1;
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Location = new System.Drawing.Point(47, 50);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(43, 13);
            this.lblUnitID.TabIndex = 0;
            this.lblUnitID.Text = "Unit ID:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // AdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 362);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminAdd";
            this.Text = "AdminAdd";
            this.tabControl1.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.tabHouseUnit.ResumeLayout(false);
            this.tabHouseUnit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabHouseUnit;
        private System.Windows.Forms.Label lblHouseUnit;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnAddNewTenant;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox cbShowHide;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.ComboBox cmbUserList;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.TextBox tbUnitID;
        private System.Windows.Forms.Label lblUnitID;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHouseUnits;
    }
}