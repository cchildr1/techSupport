using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals("Jane") && passwordTextBox.Text.Equals("test1234"))
            {
                messageLabel.Text = "";
                
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
    }
}
