﻿using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// The controller class that mediates between the DAL and the view
    /// </summary>
    class IncidentController
    { 
        private readonly IncidentDAL incidentSource;

        /// <summary>
        /// Constructor that initializes the DAL
        /// </summary>
        public IncidentController()
        { 
            this.incidentSource = new IncidentDAL();
        }

        /// <summary>
        /// Returns list of open incidents from database connection
        /// </summary>
        /// <returns>List of incidents from database</returns>
        public List<Incident> GetOpenIncidents()
        {
            return this.incidentSource.GetOpenIncidents();
        }
        /// <summary>
        /// Returns a list of products from the database
        /// </summary>
        /// <returns>list of products</returns>
        public List<Product> GetProducts()
        {
            return this.incidentSource.GetProducts();
        }
        /// <summary>
        /// Returns a list of customers from the database
        /// </summary>
        /// <returns>list of customers</returns>
        public List<Customer> GetCustomers()
        {
            return this.incidentSource.GetCustomers();
        }

        /// <summary>
        /// Calls add incident from DAL that adds the incident to the DB
        /// </summary>
        /// <param name="incident">incident to add</param>
        /// <returns>int indicating success</returns>
        public int AddIncident(Incident incident)
        {
            return this.incidentSource.AddIncident(incident);
        }

        /// <summary>
        /// Gets the technicians from the DAL
        /// </summary>
        /// <returns>list of technicians</returns>
        public List<Technician> GetTechnicians()
        {
            return this.incidentSource.GetTechnicians();
        }

        /// <summary>
        /// Gets incident from DB
        /// </summary>
        /// <param name="incidentID">ID of incident</param>
        /// <returns>Incident</returns>
        public Incident GetIncident(int incidentID)
        {
            return this.incidentSource.GetIncident(incidentID);
        }

        /// <summary>
        /// Calls db method to update incident
        /// </summary>
        /// <param name="newIncident">new information</param>
        /// <param name="oldIncident">old information</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool UpdateIncident(Incident newIncident, Incident oldIncident)
        {
            return this.incidentSource.UpdateIncident(newIncident, oldIncident);
        }
        /// <summary>
        /// Returns list of technicians with open incidents
        /// </summary>
        /// <returns>Technicians with open incidents</returns>
        public List<Technician> GetTechniciansWithOpenIncidents()
        {
            return this.incidentSource.GetTechniciansWithOpenIncidents();
        }

        /// <summary>
        /// Gets open incidents for the specified technican
        /// </summary>
        /// <param name="TechnicianID">tech ID of technician</param>
        /// <returns>list of incidents</returns>
        public List<Incident> getOpenIncidentsByTechnician(int technicianID)
        {
            return this.incidentSource.GetOpenIncidentsForTechnician(technicianID);
        }
    }
}
