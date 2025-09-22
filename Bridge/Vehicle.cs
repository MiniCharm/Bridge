using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Vehicle
    {
        /// <summary>
        /// Property that contains the Licensplate as a string
        /// </summary>
        public abstract string Licenseplate { get; set; }


        /// <summary>
        /// Propperty that uses a boolean to indicates if the vehicle used Brobiz too pay.
        /// </summary>
        public abstract bool Brobiz { get; set; }

        /// <summary>
        /// Property that contains the date the vehicle passed as DateTime
        /// </summary>
        public abstract DateTime Date { get; set; }

        /// <summary>
        /// A method that returns a fixed price.
        /// </summary>
        /// <returns> The value in double</returns>
        public abstract double Price();

        /// <summary>
        /// A method that returns the price with 10% discount
        /// </summary>
        /// <param name="price"> A double price</param>
        /// <returns>The price, with 10% subtracted</returns>
        public abstract double PriceWithBrobisDiscount(double price);
        /// <summary>
        /// A method that returns the type of vechile
        /// </summary>
        /// <returns>Returns a string </returns>
        public abstract string VehicleType();
    }
}
