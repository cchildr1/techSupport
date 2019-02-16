using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// Login form
    /// </summary>
    public partial class LoginForm : Form
    {

        private MainForm mainFormTabbed;
        /// <summary>
        /// Constructor that adds a main form to the login form.
        /// </summary>
        /// <param name="mainForm"></param>
        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainFormTabbed = mainForm;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals("Jane") && passwordTextBox.Text.Equals("test1234"))
            {
                messageLabel.Text = "";
                this.mainFormTabbed.SetUserNameText(usernameTextBox.Text);
                this.Hide();
                this.mainFormTabbed.Show();
                this.usernameTextBox.Clear();
                this.passwordTextBox.Clear();
                
            }
            else
            {
                messageLabel.Text = "invalid username/password";
                messageLabel.ForeColor = Color.Red;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void FormExit(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void removeErrorMessage(object sender, EventArgs e)
        {
            if (messageLabel.Text != "")
            {
                messageLabel.Text = "";
                messageLabel.ForeColor = Color.Black;
            }
        }
    }
}
