﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class DisplayOpenIncidents : UserControl
    {

        private IncidentController incidentController;

        public DisplayOpenIncidents()
        {
            InitializeComponent();
            incidentController = new IncidentController();
        }

        public void getOpenIncidents()
        {
            if (lvOpenIncidents.Items.Count != 0)
            {
                lvOpenIncidents.Items.Clear();
            }

            List<IncidentFromDB> incidentList;
            try
            {
                incidentList = this.incidentController.GetOpenIncidents();

                if (incidentList.Count > 0)
                {
                    IncidentFromDB incident;
                    for (int i = 0; i < incidentList.Count; i++)
                    {
                        incident = incidentList[i];
                        lvOpenIncidents.Items.Add(incident.ProductCode);
                        lvOpenIncidents.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
                        lvOpenIncidents.Items[i].SubItems.Add(incident.Customer);
                        lvOpenIncidents.Items[i].SubItems.Add(incident.Technician);
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
    }
}