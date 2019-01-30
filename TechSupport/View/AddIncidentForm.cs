using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Form to add an incident to the list
    /// </summary>
    public partial class AddIncidentForm : Form
    {

        private readonly IncidentController incidentController;

        public AddIncidentForm()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void addIncidentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customerID = int.Parse(this.customerIDTextBox.Text);
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;

                this.incidentController.Add(new Incident(title, description, customerID));

                this.DialogResult = DialogResult.OK;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input!" + Environment.NewLine + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
