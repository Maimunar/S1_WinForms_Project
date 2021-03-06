﻿using System;
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
    public partial class Events : Form
    {
        User loggedInUser;
        public Events()
        {
            InitializeComponent();
            loggedInUser = new User(formLogin.userKey);
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            EventsPopup eventsPopupScreen = new EventsPopup();
            eventsPopupScreen.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(loggedInUser.IsUserAdmin())
            {
                AdminMain adminMainScreen = new AdminMain();
                adminMainScreen.Show();
                this.Close();
            } 
            else
            {
                TenantMain tenantMainScreen = new TenantMain();
                tenantMainScreen.Show();
                this.Close();
            }
        }
    }
}
