using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    /// <summary>
    /// Models an incident which contains a title, description and customerID
    /// </summary>
    class Incident
    {
        public string Title { get; }

        public string Description { get; }

        public int CustomerID { get; }
        /// <summary>
        /// Constructor that initializes values
        /// </summary>
        /// <param name="title">Title of incident</param>
        /// <param name="description">Description of incident</param>
        /// <param name="customerID">customer ID of customer reporting incident</param>
        public Incident(string title, string description, int customerID)
        {
            if(string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Title cannot be null or empty");
            }

            if(string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Description cannot be null or empty");
            }

            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("Customer ID cannot be negative");
            }

            this.Title = title;
            this.Description = description;
            this.CustomerID = customerID;
        }
    }
}
