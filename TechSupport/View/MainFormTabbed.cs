using System;
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

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
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
    }
}
