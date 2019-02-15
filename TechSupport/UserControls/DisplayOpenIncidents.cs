using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// User Control to display the open incidents
    /// </summary>
    public partial class DisplayOpenIncidents : UserControl
    {

        private IncidentController incidentController;

        public DisplayOpenIncidents()
        {
            InitializeComponent();
            incidentController = new IncidentController();
        }
        /// <summary>
        /// populates list
        /// </summary>
        public void GetOpenIncidents()
        {
            if (lvOpenIncidents.Items.Count != 0)
            {
                lvOpenIncidents.Items.Clear();
            }

            List<Incident> incidentList;
            try
            {
                incidentList = this.incidentController.GetOpenIncidents();

                if (incidentList.Count > 0)
                {
                    Incident incident;
                    for (int i = 0; i < incidentList.Count; i++)
                    {
                        incident = incidentList[i];
                        lvOpenIncidents.Items.Add(incident.ProductCode);
                        lvOpenIncidents.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
                        lvOpenIncidents.Items[i].SubItems.Add(incident.CustomerName);
                        lvOpenIncidents.Items[i].SubItems.Add(incident.TechnicianName);
                        lvOpenIncidents.Items[i].SubItems.Add(incident.Title);
                    }
                } else
                {
                    MessageBox.Show("There are no open incidents.", "No Open Incidents");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            this.GetOpenIncidents();
        }
    }
}
