﻿using System;
using System.Windows.Forms;
using TechSupport.View;

namespace TechSupport
{

    /// <summary>
    /// Driver
    /// </summary>
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
            MainForm mainForm = new MainForm();
            LoginForm loginForm = new LoginForm(mainForm);
            mainForm.loginForm = loginForm;
            Application.Run(loginForm);
        }
    }
}
