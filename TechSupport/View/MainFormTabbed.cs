﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class MainFormTabbed : Form
    {
        public MainFormTabbed(String userName)
        {
            InitializeComponent();
            this.usernameLabel.Text = userName;
        }

        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            this.Close();
        }
    }
}