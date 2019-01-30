﻿using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class IncidentControl : UserControl
    {

        private IncidentController incidentController;
        public IncidentControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
            this.RefreshDataGrid();

        }
        /// <summary>
        /// Refreshes data grid display
        /// </summary>
        public void RefreshDataGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.incidentController.GetIncidents();
        }

    }
}

