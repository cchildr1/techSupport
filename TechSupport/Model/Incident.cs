using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Class representing an incident
    /// </summary>
    public class Incident
    {
        public int IncidentID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ProductCode { get; set; }
        public int TechnicianID { get; set; }
        public string TechnicianName { get; set; }

        public DateTime DateOpened { get; set; }

        public DateTime DateClosed { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

    }
}
