using System;
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
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid Input for Customer ID!" + Environment.NewLine + ex.Message + Environment.NewLine + "Customer ID must be a whole number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

