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
    /// Main form of application displayed on login
    /// </summary>
    public partial class MainForm : Form
    {

        private IncidentController incidentController;
        /// <summary>
        /// Constructor that adds the username to the form
        /// </summary>
        /// <param name="userName">Username passed from login page</param>
        public MainForm(String userName)
        {
            InitializeComponent();
            usernameLabel.Text = userName;
            this.incidentController = new IncidentController();
        }

        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            this.Hide();
            
            this.Close();
        }

        private void FormExit(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.incidentController.GetIncidents();
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            AddIncidentForm addIncidentForm = new AddIncidentForm();
            this.Hide();
            DialogResult result = addIncidentForm.ShowDialog();
            this.Show();
            if (result == DialogResult.OK)
            
                this.RefreshDataGrid();
            }

        private void searchIncidentButton_Click(object sender, EventArgs e)
        {
            SearchIncidentsForm searchIncidentsForm = new SearchIncidentsForm();
            this.Hide();
            searchIncidentsForm.ShowDialog();
            this.Show();
        }
    }
    }

