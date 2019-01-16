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

        /// <summary>
        /// Constructor that initializes the DAL
        /// </summary>
        public IncidentController()
        {
            this.incidentSource = new IncidentDAL();
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

        public List<Incident> SearchIncidents(int customerID)
        { 
            IEnumerable<Incident> queryIncidents = this.incidentSource.GetIncidents().Where(incident => incident.CustomerID == customerID);
            List<Incident> outputList = new List<Incident>();
            foreach(Incident incident in queryIncidents)
            {
                outputList.Add(incident);
            }

            return outputList;
        }
    }
}
