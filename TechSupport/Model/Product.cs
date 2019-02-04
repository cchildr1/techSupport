using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    class Product
    {
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public decimal Version { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
