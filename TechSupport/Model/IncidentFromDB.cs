using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    class IncidentFromDB
    {
        public String ProductCode { get; set; }

        public DateTime DateOpened { get; set; }

        public String Customer { get; set;}

        public String Technician { get; set; }

        public String Title { get; set; }

        public IncidentFromDB()
        {
            this.ProductCode = "";
            this.Customer = "";
            this.Technician = "";
            this.Title = "";
        }
    }
}
