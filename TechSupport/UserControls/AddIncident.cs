using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class AddIncident : UserControl
    {
        private IncidentController controller;
        /// <summary>
        /// Constructor
        /// </summary>
        public AddIncident()
        {
            InitializeComponent();
            this.controller = new IncidentController();
            cbCustomer.DataSource = this.controller.GetCustomers();
            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "CustomerID";
            cbProduct.DataSource = this.controller.GetProducts();
            cbProduct.DisplayMember = "Name";
            cbProduct.ValueMember = "ProductCode";
        }

        private void btnAddIncident_Click(object sender, EventArgs e)
        {
            if(this.IsValidData())
            {
                Incident incident = new Incident();
                incident.CustomerID = (int)this.cbCustomer.SelectedValue;
                incident.CustomerName = this.cbCustomer.SelectedText;
                incident.Title = this.tbTitle.Text;
                incident.Description = this.tbDescription.Text;
                incident.ProductCode = (string)this.cbProduct.SelectedValue;
                
                if (controller.AddIncident(incident) > 0)
                {
                    MessageBox.Show("Added Incident.", "Success!");
                    this.clear();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(cbCustomer) &&
                Validator.IsPresent(cbProduct) &&
                Validator.IsPresent(tbTitle) &&
                Validator.IsPresent(tbDescription);
        }

        private void clear()
        {
            tbDescription.Clear();
            tbTitle.Clear();
            cbCustomer.SelectedIndex = -1;
            cbProduct.SelectedIndex = -1;
        }
    }
}
