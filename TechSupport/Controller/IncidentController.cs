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
        private IncidentDAL incidentSource;
        private IncidentDBDAL incidentSourceDB;

        /// <summary>
        /// Constructor that initializes the DAL
        /// </summary>
        public IncidentController()
        {
            this.incidentSource = new IncidentDAL();
            this.incidentSourceDB = new IncidentDBDAL();
        }

        /// <summary>
        /// Returns the list of incidents stored in DAL
        /// </summary>
        /// <returns> list of incidents</returns>
        public List<Incident> GetIncidents()
        {
            return this.incidentSource.GetIncidents();
        }

        /// <summary>
        /// Adds a new incident to the list in the DAL
        /// </summary>
        /// <param name="incident">incident to add to the list</param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            this.incidentSource.Add(incident);
        }

        /// <summary>
        /// Searches the list for any incident with a matching customer id
        /// </summary>
        /// <param name="customerID"> customer ID that is being searched</param>
        /// <returns>list of all incidents with particular customer id</returns>
        public List<Incident> Search(int customerID)
        {
            return this.incidentSource.Search(customerID);
        }

        public List<IncidentFromDB> GetOpenIncidents()
        {
            return this.incidentSourceDB.GetOpenIncidents();
        }
    }
}
