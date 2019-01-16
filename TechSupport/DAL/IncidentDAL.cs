using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// The Data Access Layer that interacts with a list for incidents
    /// </summary>
    class IncidentDAL
    {
        private static List<Incident> _incidents = new List<Incident>
        {
            new Incident("Test1", "this is a test", 1),
            new Incident("Test2", "this is also a test", 1)
        }; 

        /// <summary>
        /// Returns the list containing all the incidents
        /// </summary>
        /// <returns> a list of incident objects</returns>
        public List<Incident> GetIncidents()
        {
            return _incidents;
        }

        /// <summary>
        /// Adds an incident to the list
        /// </summary>
        /// <param name="incident">incident object to add</param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }
            _incidents.Add(incident);
        }
    }
}
