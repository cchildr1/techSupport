using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Form to search the incidents for a specific customerID and display all incidents
    /// </summary>
    public partial class SearchIncidentsForm : Form
    {

        private readonly IncidentController incidentController;
        /// <summary>
        /// Constructor to initialize controller
        /// </summary>
        public SearchIncidentsForm()
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
