using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This is the DAL that deals with incidents. 
    /// </summary>
    public class IncidentDAL
    {
        /// <summary>
        /// Returns the list of incidents with no close date
        /// </summary>
        /// <returns>List of open incidents</returns>
        internal List<Incident> GetOpenIncidents()
        {
            List<Incident> incidentList = new List<Incident>();

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
                            Incident incident = new Incident
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
        /// <summary>
        /// Pulls list of customers from DB
        /// </summary>
        /// <returns>List of customers</returns>
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

        /// <summary>
        /// Pulls products from DB
        /// </summary>
        /// <returns>List of Products</returns>
        internal List<Product> GetProducts()
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
        /// <summary>
        /// Adds an incident to the databse
        /// </summary>
        /// <param name="customerID">customerID as int</param>
        /// <param name="productCode">ProductCode as string</param>
        /// <param name="title">Title as string</param>
        /// <param name="description">Description as string</param>
        /// <returns>returns int result based on whether query executed</returns>
        internal int AddIncident(int customerID, string productCode, string title, string description)
        {
            SqlConnection connection = TechSupportDBConnection.GetConnection();

            string insertStatement = "INSERT Incidents" +
                "(CustomerID, ProductCode, DateOpened, Title, Description)" +
                "VALUES (@CustomerID, @ProductCode, getdate(), @Title, @Description);";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@CustomerID", customerID);
            insertCommand.Parameters.AddWithValue("@ProductCode", productCode);
            insertCommand.Parameters.AddWithValue("@Title", title);
            insertCommand.Parameters.AddWithValue("@Description", description);

            try
            {
                connection.Open();
                int result = insertCommand.ExecuteNonQuery();
                return result;
            } catch (SqlException ex)
            {
                throw ex;
            } finally
            {
                connection.Close();
            }

        }

        /// <summary>
        /// Retrieves all technicians from the database.
        /// </summary>
        /// <returns>List of technicians</returns>
        internal List<Technician> GetTechnicians()
        {
            List<Technician> technicians = new List<Technician>();
            string selectStatement = "SELECT * FROM Technicians;";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            technicians.Add(new Technician
                            {
                                TechID = (int)reader["TechID"],
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString(),
                                Phone = reader["Phone"].ToString()
                            });
                        }
                    }
                }
            }
            return technicians;
        }
    }
}
