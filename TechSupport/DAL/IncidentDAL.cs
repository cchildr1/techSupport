using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
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
                "SELECT i.IncidentID, i.CustomerID, i.TechID as TechID, i.ProductCode, i.DateOpened, c.Name as Customer, t.Name as Technician, i.Title, i.Description " +
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
                                IncidentID = (int)reader["IncidentID"],
                                CustomerID = (int)reader["CustomerID"],
                                ProductCode = reader["ProductCode"].ToString(),
                                DateOpened = (DateTime)reader["DateOpened"],
                                CustomerName = reader["Customer"].ToString(),
                                TechnicianName = reader["Technician"].ToString(),
                                Title = reader["Title"].ToString(),
                                Description = reader["Description"].ToString()
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
                connection.Close();
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
        internal int AddIncident(Incident incident)
        {
           
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {

                string insertStatement = "INSERT Incidents" +
                    "(CustomerID, ProductCode, DateOpened, Title, Description)" +
                    "VALUES (@CustomerID, @ProductCode, getdate(), @Title, @Description);";
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@CustomerID", incident.CustomerID);
                    insertCommand.Parameters.AddWithValue("@ProductCode", incident.ProductCode);
                    insertCommand.Parameters.AddWithValue("@Title", incident.Title);
                    insertCommand.Parameters.AddWithValue("@Description", incident.Description);


                    int result = insertCommand.ExecuteNonQuery();
                    return result;

                }
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
        /// <summary>
        /// Returns a single incident based on ID
        /// </summary>
        /// <param name="incidentID">id of incident</param>
        /// <returns>incident</returns>
        internal Incident GetIncident(int incidentID)
        {
            string selectStatement = "SELECT i.IncidentID, i.CustomerID, c.Name as CustomerName, i.ProductCode, i.Title, i.Description, i.TechID, t.Name as Technician, i.DateOpened, i.DateClosed " +
                "FROM incidents i " +
                "LEFT JOIN Customers c on i.CustomerID = c.CustomerID " +
                "LEFT JOIN Technicians t on t.TechID = i.TechID " +
                "WHERE IncidentID = @IncidentID;";
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    selectCommand.Parameters.AddWithValue("@IncidentID", incidentID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        Incident incident = new Incident();
                        if(reader.Read())
                        {
                            incident.IncidentID = (int)reader["IncidentID"];
                            incident.CustomerID = (int)reader["CustomerID"];
                            incident.CustomerName = reader["CustomerName"].ToString();
                            incident.ProductCode = reader["ProductCode"].ToString();
                            incident.Title = reader["Title"].ToString();
                            incident.Description = reader["Description"].ToString();
                            incident.DateOpened = (DateTime)reader["DateOpened"];
                            if (reader["TechID"] == DBNull.Value)
                            {
                                incident.TechnicianID = -1;
                            } else
                            {
                                incident.TechnicianID = (int)reader["TechID"];
                                incident.TechnicianName = reader["Technician"].ToString();
                            }
                            if (!(reader["DateClosed"] == DBNull.Value))
                            {
                                incident.DateClosed = (DateTime)reader["DateClosed"];
                            }
                            connection.Close();
                            return incident;
                            
                        }
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Adds incident to DB
        /// </summary>
        /// <param name="oldIncident">previous incident to match</param>
        /// <param name="newIncident">incident to add to db</param>
        /// <returns>true if successful, false otherwise</returns>
        internal bool UpdateIncident(Incident newIncident, Incident oldIncident)
        {
            string updateStatement = "UPDATE Incidents SET " +
                        "CustomerID = @CustomerID, " +
                        "ProductCode = @ProductCode, " +
                        "TechID = @TechID, " +
                        "DateClosed = @DateClosed, " +
                        "Title = @Title, " +
                        "Description = @Description " +
                        "WHERE IncidentID = @OldIncidentID " +
                        "AND CustomerID = @OldCustomerID " +
                        "AND ProductCode = @OldProductCode " +
                        "AND (TechID = @OldTechID " +
                        "OR TechID IS NULL AND @OldTechID IS NULL) " +
                        "AND DateOpened = @OldDateOpened " +
                        "AND (DateClosed = @OldDateClosed OR DateClosed IS NULL AND @OldDateClosed IS NULL) " +
                        "AND Title = @OldTitle " +
                        "AND Description = @OldDescription;";
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@IncidentID", newIncident.IncidentID);
                    updateCommand.Parameters.AddWithValue("@OldIncidentID", oldIncident.IncidentID);

                    updateCommand.Parameters.AddWithValue("@CustomerID", newIncident.CustomerID);
                    updateCommand.Parameters.AddWithValue("@OldCustomerID", oldIncident.CustomerID);

                    updateCommand.Parameters.AddWithValue("@ProductCode", newIncident.ProductCode);
                    updateCommand.Parameters.AddWithValue("@OldProductCode", oldIncident.ProductCode);
                    if (newIncident.TechnicianID == -1)
                    {
                        updateCommand.Parameters.AddWithValue("@TechID", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@TechID", newIncident.TechnicianID);
                    }
                    if (oldIncident.TechnicianID == -1)
                    {
                        updateCommand.Parameters.AddWithValue("@OldTechID", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@OldTechID", oldIncident.TechnicianID);
                    }
                    if (newIncident.DateClosed == DateTime.MinValue)
                    {
                        updateCommand.Parameters.AddWithValue("@DateClosed", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@DateClosed", newIncident.DateClosed);
                    }
                    if (oldIncident.DateClosed == DateTime.MinValue)
                    {
                        updateCommand.Parameters.AddWithValue("@OldDateClosed", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@OldDateClosed", oldIncident.DateClosed);
                    }
                    updateCommand.Parameters.AddWithValue("@Title", newIncident.Title);
                    updateCommand.Parameters.AddWithValue("@OldTitle", oldIncident.Title);

                    updateCommand.Parameters.AddWithValue("@Description", newIncident.Description);
                    updateCommand.Parameters.AddWithValue("@OldDescription", oldIncident.Description);
                    updateCommand.Parameters.AddWithValue("@OldDateOpened", oldIncident.DateOpened);
                    // shows message box of query before command executes
                    //string query = updateCommand.CommandText;
                    //foreach (SqlParameter p in updateCommand.Parameters)
                    //{
                    //    query = query.Replace(p.ParameterName, p.Value.ToString());
                    //}
                    //MessageBox.Show(query);
                    int count = updateCommand.ExecuteNonQuery();
                    connection.Close();
                    return count > 0;
                }
            }
        }

    }
}
