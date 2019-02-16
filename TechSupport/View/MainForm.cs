using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// Main form that holds tabs for user controls
    /// </summary>
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


        private void DisplayOpenIncidents(object sender, EventArgs e)
        {
            displayOpenIncidents1.GetOpenIncidents();
        }

        private void MainFormTabbed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Sets username label next to logout link
        /// </summary>
        /// <param name="userName">username to set</param>
        public void SetUserNameText(string userName)
        {
            usernameLabel.Text = userName;
        }
    }
}
