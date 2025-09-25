using Bridge;

namespace OresundbronLibrary
{
    public class OresundbronCar : Car
    {
        public OresundbronCar(string licenselate, DateTime date, bool brobiz) : base(licenselate, date, brobiz)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 460;
        }
        
        /// <summary>
        /// A method that returns the price 178 
        /// </summary>
        /// <param name="price"></param>
        /// <returns>A double</returns>
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
