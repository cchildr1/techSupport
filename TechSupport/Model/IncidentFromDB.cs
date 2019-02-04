using System;

namespace TechSupport.Model
{
    class IncidentFromDB
    {
        public string ProductCode { get; set; }

        public DateTime DateOpened { get; set; }

        public string Customer { get; set;}

        public string Technician { get; set; }

        public string Title { get; set; }

        public IncidentFromDB()
        {
            this.ProductCode = "";
            this.Customer = "";
            this.Technician = "";
            this.Title = "";
            this.DateOpened = DateTime.Now;
        }
    }
}
