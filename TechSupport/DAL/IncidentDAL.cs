using System;
using System.Collections.Generic;
using System.Linq;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// The Data Access Layer that interacts with a list for incidents
    /// </summary>
    class IncidentDAL
    {
        private static List<IncidentInMemory> _incidents = new List<IncidentInMemory>
        {
            new IncidentInMemory("Test1", "this is a test", 1),
            new IncidentInMemory("Test2", "this is also a test", 1)
        }; 

        /// <summary>
        /// Returns the list containing all the incidents
        /// </summary>
        /// <returns> a list of incident objects</returns>
        public List<IncidentInMemory> GetIncidents()
        {
            return _incidents;
        }

        /// <summary>
        /// Adds an incident to the list
        /// </summary>
        /// <param name="incident">incident object to add</param>
        public void Add(IncidentInMemory incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }
            _incidents.Add(incident);
        }

        public List<IncidentInMemory> Search(int customerID)
        {
            return _incidents.Where(incident => incident.CustomerID == customerID).ToList();
        }
    }
}
