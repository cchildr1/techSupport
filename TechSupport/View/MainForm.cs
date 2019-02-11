﻿using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class MainForm : Form
    {

        public LoginForm loginForm { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            this.loginForm.Show();
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayOpenIncidents1.getOpenIncidents();
        }

        private void DisplayOpenIncidents(object sender, EventArgs e)
        {
            displayOpenIncidents1.getOpenIncidents();
        }

        private void MainFormTabbed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addIncidentDBControl1_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Sets username label next to logout link
        /// </summary>
        /// <param name="userName">username to set</param>
        public void setUserNameText(string userName)
        {
            usernameLabel.Text = userName;
        }
    }
}
