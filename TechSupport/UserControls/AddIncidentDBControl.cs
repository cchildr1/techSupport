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

namespace TechSupport.UserControls
{
    public partial class AddIncidentDBControl : UserControl
    {
        private IncidentController controller;

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
                controller.AddIncident((int)cbCustomer.SelectedValue, (string)cbProduct.SelectedValue, tbTitle.Text, tbDescription.Text);
            } else
            {
                MessageBox.Show("All fields are required.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDescription.Clear();
            tbTitle.Clear();
            cbCustomer.SelectedIndex = -1;
            cbProduct.SelectedIndex = -1;
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(cbCustomer) &&
                Validator.IsPresent(cbProduct) &&
                Validator.IsPresent(tbTitle) &&
                Validator.IsPresent(tbDescription);
        }
    }
}
