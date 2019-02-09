using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class AddIncidentDBControl : UserControl
    {
        private IncidentController controller;
        /// <summary>
        /// Constructor
        /// </summary>
        public AddIncidentDBControl()
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
                if (controller.AddIncident((int)cbCustomer.SelectedValue, (string)cbProduct.SelectedValue, tbTitle.Text, tbDescription.Text) > 0)
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
