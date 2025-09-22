using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Vehicle
    {
        /// <summary>
        /// Property that contains the Licensplate as a string
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Property that contains the date the vehicle passed as DateTime
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// A method that returns a fixed price
        /// </summary>
        /// <returns> The value in double</returns>
        public virtual double Price()
        {
            return 0;
        }
        /// <summary>
        /// A method that returns the type of vechile
        /// </summary>
        /// <returns>Returns a string </returns>
        public virtual string VehicleType()
        {
            return "Vehicle";
        }
    }
}
