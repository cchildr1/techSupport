using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This is the DAL that deals with incidents. 
    /// </summary>
    public class IncidentDBDAL
    {
        /// <summary>
        /// Returns the list of incidents with no close date
        /// </summary>
        /// <returns>List of open incidents</returns>
        internal List<IncidentFromDB> GetOpenIncidents()
        {
            List<IncidentFromDB> incidentList = new List<IncidentFromDB>();

            string selectStatement =
                "SELECT i.ProductCode, i.DateOpened, c.Name as Customer, t.Name as Technician, i.Title " +
                "from Incidents i " +
                "LEFT JOIN Technicians t on i.TechID = t.TechID " +
                "LEFT JOIN Customers c on i.CustomerID = c.CustomerID " +
                "WHERE i.dateClosed IS NULL;";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IncidentFromDB incident = new IncidentFromDB();
                            incident.ProductCode = reader["ProductCode"].ToString();
                            incident.DateOpened = (DateTime)reader["DateOpened"];
                            incident.Customer = reader["Customer"].ToString();
                            incident.Technician = reader["Technician"].ToString();
                            incident.Title = reader["Title"].ToString();

                            incidentList.Add(incident);
                        }
                    }
                }
            }
            return incidentList;
        }
    }
}
