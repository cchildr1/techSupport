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
    public partial class SearchControl : UserControl
    {
        private readonly IncidentController incidentController;
        /// <summary>
        /// Constructor to initialize controller
        /// </summary>
        public SearchControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID = int.Parse(this.customerIDTextBox.Text);
                this.resultsDataGridView.DataSource = this.incidentController.Search(customerID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input!" + Environment.NewLine + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        
}
}
