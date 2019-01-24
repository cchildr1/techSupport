using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;
using TechSupport.DAL;

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
            IEnumerable<Incident> queryIncidents = this.incidentSource.GetIncidents().Where(incident => incident.CustomerID == customerID);
            List<Incident> outputList = new List<Incident>();
            foreach(Incident incident in queryIncidents)
            {
                outputList.Add(incident);
            }

            return outputList;
        }

        public List<IncidentFromDB> GetOpenIncidents()
        {
            return this.incidentSourceDB.GetOpenIncidents();
        }
    }
}
