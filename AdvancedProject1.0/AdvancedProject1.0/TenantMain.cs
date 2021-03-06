﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedProject1._0
{
    public partial class TenantMain : Form
    {

        HouseRulesInfo houseRules;
        User loggedInUser;
        NotificationsGatherer gath;
        public TenantMain()
        {
            InitializeComponent();
            houseRules = new HouseRulesInfo();
            loggedInUser = new User(formLogin.userKey);
            lblWelcome.Text = $"Welcome, {loggedInUser.FirstName}!";
            gath = new NotificationsGatherer(loggedInUser.UserID);
            NotificationBtnUpdate();
            RefreshPanel();
            /* (Example) How to use the HouseUnit class to iterate through tenants
            HouseUnit newUnit = new HouseUnit(loggedInUser.UnitID);
            string test = "";
            foreach(User tenant in newUnit.Tenants)
            {
                test += $"{tenant.FirstName},";
            }
            MessageBox.Show(test);
            */

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NotificationsGatherer.DeleteAllCompleted() ;
            formLogin loginScreen = new formLogin();
            loginScreen.Show();
            this.Close();
        }

        private void btnCleaning_Click(object sender, EventArgs e)
        {
            CleaningSchedule cleaningScheduleScreen = new CleaningSchedule();
            cleaningScheduleScreen.Show();
            this.Close();
        }

        private void btnGroceries_Click(object sender, EventArgs e)
        {
            Groceries groceriesScreen = new Groceries();
            groceriesScreen.Show();
            this.Close();
        }


        private void btnSocial_Click(object sender, EventArgs e)
        {
            Social socialScreen = new Social(this);
            socialScreen.Show();
            this.Close();
        }

        private void btnHouseRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(houseRules.GetRules());
        }

        private void TenantMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")) { }
            else Application.Exit();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            ReportPopup reportPopupScreen = new ReportPopup();
            reportPopupScreen.Show();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            if (panelBorderNotifications.Visible == false)
            {
                panelBorderNotifications.Visible = true;
                panelNotifications.Visible = true;
                if (panelNotifications.Controls.Count < 4)
                {
                    panelNotifications.Size = new Size(173, (65 * panelNotifications.Controls.Count + 20));
                    panelBorderNotifications.Size = new Size(177, (65 * panelNotifications.Controls.Count + 24));
                }
            }
            else if (panelBorderNotifications.Visible == true)
            {
                panelBorderNotifications.Visible = false;
                panelNotifications.Visible = false;
                NotificationBtnUpdate();
            }
        }
        public void NotificationBtnUpdate()
        {
            if (gath.GetAllIncompleteNotifications().Count > 0) { btnNotification.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Notifcation)); }
            else { btnNotification.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NoNotification)); }
        }
        public void RefreshPanel()
        {
            panelNotifications.Controls.Clear();
            gath = new NotificationsGatherer(loggedInUser.UserID);
            List<Notifications> myNotifications = new List<Notifications>();
            myNotifications = gath.GetAllIncompleteNotifications();
            NotificationSmallLabel[] notifications = new NotificationSmallLabel[myNotifications.Count];
            for (int i = 0; i < myNotifications.Count; i++)
            {
                notifications[i] = new NotificationSmallLabel(myNotifications[i]);
                panelNotifications.Controls.Add(notifications[i]);
            }
        }

        private void TenantMain_Click(object sender, EventArgs e)
        {
            if (panelBorderNotifications.Visible == true)
            {
                panelBorderNotifications.Visible = false;
                panelNotifications.Visible = false;
                NotificationBtnUpdate();
            }
        }
    }
}
