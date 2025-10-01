using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Car: Vehicle
    {
        private string _licenseplte;
        /// <summary>
        /// Property that contains the Licensplate as a string
        /// Validates if the length is under 7
        /// </summary>
        public override string Licenseplate
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
        /// Property that contains the date the car passed as DateTime
        /// </summary>
        public override DateTime Date { get; set; }

        /// <summary>
        /// Propperty that uses a boolean to indicates if the car used Brobiz too pay.
        /// </summary>
        public override bool Brobiz { get; set; }

        public Car( string licenselate, DateTime date, bool brobiz) 
        {
            Licenseplate = licenselate;
            Date = date;
            Brobiz = brobiz;
        }

        /// <summary>
        /// A method that returns a fixed price
        /// </summary>
        /// <returns>the double 230</returns>
        public override double Price() 
        {
            return 230;
        }
        /// <summary>
        /// A method that returns the type of vechile
        /// </summary>
        /// <returns>Returns the string Car</returns>
        public override string VehicleType() 
        {
            return "Car";
        }

        /// <summary>
        /// A method that returns the price with 10% discount
        /// </summary>
        /// <param name="price"> A double price</param>
        /// <returns>The price, with 10% subtracted</returns>
        public override double PriceWithBrobisDiscount(double price)
        {
            if (Brobiz == true)
            {
                price = price - 10 * (price / 100);
            }
            return price;
        }
    }
}
