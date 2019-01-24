using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class AddIncidentControl : UserControl
    { 
    

        private readonly IncidentController incidentController;

        public AddIncidentControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customerID = int.Parse(this.customerIDTextBox.Text);
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;

                this.incidentController.Add(new Incident(title, description, customerID));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input!" + Environment.NewLine + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.customerIDTextBox.Text = "";
            this.titleTextBox.Text = "";
            this.descriptionTextBox.Text = "";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

