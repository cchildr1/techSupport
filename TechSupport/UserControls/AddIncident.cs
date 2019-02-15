using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// user control to add incident
    /// </summary>
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
            try
            {
                cbCustomer.DataSource = this.controller.GetCustomers();
                cbCustomer.DisplayMember = "Name";
                cbCustomer.ValueMember = "CustomerID";
            } 
            catch (Exception ex)
            {
                MessageBox.Show("There is an issue with the Database.");
            }
            try
            {
                cbProduct.DataSource = this.controller.GetProducts();
                cbProduct.DisplayMember = "Name";
                cbProduct.ValueMember = "ProductCode";
            } 
            catch (Exception ex)
            {
                MessageBox.Show("There is an issue with the database.");
            }
        }

        private void BtnAddIncident_Click(object sender, EventArgs e)
        {
            if(this.IsValidData())
            {
                Incident incident = new Incident
                {
                    CustomerID = (int)this.cbCustomer.SelectedValue,
                    CustomerName = this.cbCustomer.SelectedText,
                    Title = this.tbTitle.Text,
                    Description = this.tbDescription.Text,
                    ProductCode = (string)this.cbProduct.SelectedValue
                };
                try
                {
                    if (controller.AddIncident(incident) > 0)
                    {
                        MessageBox.Show("Added Incident.", "Success!");
                        this.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There is an issue with the database. Incident not added.");
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(cbCustomer) &&
                Validator.IsPresent(cbProduct) &&
                Validator.IsPresent(tbTitle) &&
                Validator.IsPresent(tbDescription);
        }

        private void Clear()
        {
            tbDescription.Clear();
            tbTitle.Clear();
            cbCustomer.SelectedIndex = -1;
            cbProduct.SelectedIndex = -1;
        }
    }
}
