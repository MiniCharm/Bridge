using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundbronLibrary
{
    public class OresundbronMC : MC
    {
        public OresundbronMC(string licenselate, DateTime date, bool brobiz) : base(licenselate, date, brobiz)
        {
        }

        public override double Price()
        {
            return 235;
        }

        /// <summary>
        /// Method that returns the price with brobiz
        /// </summary>
        /// <param name="price">Den originale pris</param>
        /// <returns>Returns the double 92</returns>
        public override double PriceWithBrobisDiscount(double price)
        {
            if (Brobiz == true) 
            {
                price = 92;
            }
            return price;
        }

        /// <summary>
        /// A method that returns the VehicleType
        /// </summary>
        /// <returns> Returns Type Orsund MC </returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
