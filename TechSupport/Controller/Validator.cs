using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.Controller
{
    /// <summary>
    /// Class to store validation of entries.
    /// </summary>
    class Validator
    {
        private static readonly string title = "Entry Error";

        /// <summary>
        /// Checks text box and combo box to make sure they aren't empty
        /// </summary>
        /// <param name="control">control to check</param>
        /// <returns>false if empty</returns>
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString().Equals("System.Windows.Forms.TextBox"))
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text.Equals(""))
                {
                    MessageBox.Show(textBox.Tag.ToString() + " is a required field.", title);
                    textBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }

            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(comboBox.Tag.ToString() + " is a required field.", title);
                    comboBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        /// <summary>
        /// Verifies if control contains an integer
        /// </summary>
        /// <param name="control">control to verify</param>
        /// <returns>true if contains an integer, false otherwise</returns>
        public static bool IsInteger(Control control)
        {
            if(control.GetType().ToString() == "System.Windows.Forms.TextBox") {
                TextBox textBox = (TextBox)control;
                if(int.TryParse(textBox.Text, out int result))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
