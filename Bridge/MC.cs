using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC : Vehicle
    {
        private string _licenseplte;
        /// <summary>
        /// Property that contains the Licensplate as a string
        /// </summary>
        public string Licenseplate
        {
            get
            {
                return _licenseplte;
            }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("Licenseplate must be under 7 characters");
                }
                else
                {
                    _licenseplte = value;
                }

            }
        }

        /// <summary>
        /// Property that contains the date the Mc passed as DateTime
        /// </summary>
        public DateTime Date { get; set; }

        public MC(string licenselate, DateTime date)
        {
            Licenseplate = licenselate;
            Date = date;
        }

        /// <summary>
        /// A method that returns a fixed price
        /// </summary>
        /// <returns>the double 120</returns>
        public override double Price()
        {
            return 120;
        }
        /// <summary>
        /// A method that returns the type of vechile
        /// </summary>
        /// <returns>Returns the string MC</returns>
        public override string VehicleType()
        {
            return "MC";
        }

    }
}
