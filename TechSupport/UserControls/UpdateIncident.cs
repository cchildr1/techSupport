using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// User control to update incidents
    /// </summary>
    public partial class UpdateIncident : UserControl
    {

        private IncidentController controller;
        public UpdateIncident()
        {
            InitializeComponent();
            this.controller = new IncidentController();
            try
            {
                cbTechnician.DataSource = controller.GetTechnicians();
                cbTechnician.DisplayMember = "Name";
                cbTechnician.ValueMember = "TechID";
                cbTechnician.SelectedIndex = -1;
            } catch (Exception ex)
            {
                MessageBox.Show("There is an issue with the database.", "Database Error!");
            }
        }

        private void BtGetIncident_Click(object sender, EventArgs e)
        {
            if(!Validator.IsInteger(tbIncidentID))
            {
                MessageBox.Show("You must enter an integer incident id.", "Incident ID Error");
                return;
            }
            Incident incident = controller.GetIncident(int.Parse(tbIncidentID.Text));
            if (incident == null)
            {
                MessageBox.Show("Record not found.", "No Record");
            }
            else
            {

                tbCustomer.Text = incident.CustomerName;
                tbDateOpened.Text = incident.DateOpened.ToShortDateString();
                tbDescription.Text = incident.Description;
                tbProduct.Text = incident.ProductCode;
                tbTitle.Text = incident.Title;

                btUpdate.Enabled = true;
                btClose.Enabled = true;
            }
        }

        private void Clear()
        {
            tbCustomer.Clear();
            tbDateOpened.Clear();
            cbTechnician.SelectedIndex = -1;
            tbDescription.Clear();
            tbProduct.Clear();
            tbTitle.Clear();

            btUpdate.Enabled = false;
            btClose.Enabled = false;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
