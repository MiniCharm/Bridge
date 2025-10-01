using Bridge;

namespace OresundbronLibrary
{
    public class OresundbronCar : Car
    {
        public OresundbronCar(string licenselate, DateTime date, bool brobiz) : base(licenselate, date, brobiz)
        {
        }
        /// <summary>
        /// A method that returns a fixed price
        /// </summary>
        /// <returns>Returns the double 460</returns>
        public override double Price()
        {
            return 460;
        }
        
        /// <summary>
        /// A method that returns the price with brobiz biscount
        /// </summary>
        /// <param name="price">The base price in double</param>
        /// <returns>The double 178e</returns>
        public override double PriceWithBrobisDiscount(double price)
        {
            if (Brobiz == true)
            {
                price = 178;
            }
            return price;
        }

        /// <summary>
        /// A method that returns the VehicleType
        /// </summary>
        /// <returns> Returns Type Orsund Car </returns>
        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }

}
