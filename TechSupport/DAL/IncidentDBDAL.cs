﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                            IncidentFromDB incident = new IncidentFromDB
                            {
                                ProductCode = reader["ProductCode"].ToString(),
                                DateOpened = (DateTime)reader["DateOpened"],
                                Customer = reader["Customer"].ToString(),
                                Technician = reader["Technician"].ToString(),
                                Title = reader["Title"].ToString()
                            };

                            incidentList.Add(incident);
                        }
                    }
                }
            }
            return incidentList;
        }

        internal void AddIncident(IncidentFromDB incident)
        {

        }

        internal List<Customer> GetCustomers()
        {
            List<Customer> customerList = new List<Customer>();
            string selectStatement = "SELECT * FROM Customers;";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customerList.Add(new Customer
                            {
                                CustomerID = (int)reader["CustomerID"],
                                Name = reader["Name"].ToString(),
                                Address = reader["Address"].ToString(),
                                City = reader["City"].ToString(),
                                State = reader["State"].ToString(),
                                ZipCode = reader["ZipCode"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Email = reader["Email"].ToString()
                            });
                        }
                    }
                }
            }
            return customerList;
        }

        public List<Product> getProducts()
        {
            List<Product> productList = new List<Product>();
            string selectStatement = "SELECT * FROM Products;";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productList.Add(new Product
                            {
                                ProductCode = reader["ProductCode"].ToString(),
                                Name = reader["Name"].ToString(),
                                Version = (decimal)reader["Version"],
                                ReleaseDate = (DateTime)reader["ReleaseDate"]
                            });
                        }
                    }
                }
            }
            return productList;
        }
    }
}
