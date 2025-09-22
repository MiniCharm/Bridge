using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC
    {
        /// <summary>
        /// Property that contains the Licensplate as a string
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Property that contains the date the Mc passed as DateTime
        /// </summary>
        public DateTime Date { get; set; }


        /// <summary>
        /// A method that returns a fixed price
        /// </summary>
        /// <returns>the double 120</returns>
        public double Price()
        {
            return 120;
        }
        /// <summary>
        /// A method that returns the type of vechile
        /// </summary>
        /// <returns>Returns the string MC</returns>
        public string VehicleType()
        {
            return "MC";
        }

    }
}
