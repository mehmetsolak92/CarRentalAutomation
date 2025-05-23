﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalAutomation.Class;

namespace CarRentalAutomation
{
    public partial class Settings : BaseForm
    {
        public Settings()
        {
            InitializeComponent();
        }


        private void Settings_Load(object sender, EventArgs e)
        {
            FormStyle.changeFormStyle(this);
        }

        private void btnPersonelSettings_Click(object sender, EventArgs e)
        {
            SettingsUsers settingsUsers = new SettingsUsers();
            settingsUsers.ShowDialog();
        }
    }
}
