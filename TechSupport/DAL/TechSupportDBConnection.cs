using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.DAL
{
    /// <summary>
    /// Returns the sqlConnection to the TechSupport DB
    /// </summary>
    public static class TechSupportDBConnection
    {
        /// <summary>
        /// connections to TechSupport DB
        /// </summary>
        /// <returns>SQLConnection to DB</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=TechSupport;" +
                "Integrated Security=True;";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
