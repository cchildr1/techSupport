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
        /// Adds an incident to the database by calling method in DAL
        /// </summary>
        /// <param name="customerID">Customer ID #</param>
        /// <param name="productCode">Product Code</param>
        /// <param name="title">Title</param>
        /// <param name="description">Description of Incident</param>
        /// <returns>int for query result</returns>
        public int AddIncident(int customerID, string productCode, string title, string description)
        {
            return this.incidentSource.AddIncident(customerID, productCode, title, description);
        }
    }
}
