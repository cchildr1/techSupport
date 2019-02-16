using System;
using System.Collections.Generic;
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
    }
}
