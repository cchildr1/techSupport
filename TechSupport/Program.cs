using System;
using System.Windows.Forms;
using TechSupport.View;

namespace TechSupport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create LoginForm and mainform here
            MainFormTabbed mainForm = new MainFormTabbed();
            LoginForm loginForm = new LoginForm(mainForm);
            mainForm.loginForm = loginForm;
            Application.Run(loginForm);
        }
    }
}
