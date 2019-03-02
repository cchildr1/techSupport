using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// User Control to view incidents by technician
    /// </summary>
    public partial class ViewIncidentsByTechnician : UserControl
    {
        private IncidentController controller;
        private List<Technician> technicians;
        private List<Incident> incidents;

        public ViewIncidentsByTechnician()
        {
            InitializeComponent();
            this.controller = new IncidentController();
        }

        private void GetTechnicianList()
        {
            try
            {
                technicians = controller.GetTechniciansWithOpenIncidents();
                nameComboBox.DataSource = technicians;
                nameComboBox.ValueMember = "TechID";
                nameComboBox.DisplayMember = "Name";
                nameComboBox.SelectedIndex = 0;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void getTechnicianData()
        {
            
            try
            {
                int technicianIndex = (int)nameComboBox.SelectedIndex;
                Technician technician = technicians[technicianIndex];
                emailTextBox.Text = technician.Email;
                phoneTextBox.Text = technician.Phone;
                incidentDataGridView.DataSource = this.controller.getOpenIncidentsByTechnician(technician.TechID);

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ViewIncidentsByTechnician_Load(object sender, EventArgs e)
        {
            this.GetTechnicianList();
            this.getTechnicianData();
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.getTechnicianData();
        }

    }
}
