using System;

namespace TechSupport.Model
{
    class Incident
    {
        public string ProductCode { get; set; }

        public DateTime DateOpened { get; set; }

        public string Customer { get; set;}

        public string Technician { get; set; }

        public string Title { get; set; }

    }
}
