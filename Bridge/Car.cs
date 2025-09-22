using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Car
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }


        public double Price() 
        {
            return 230;
        }

        public string VehicleType() 
        {
            return "Car";
        }
    }
}
