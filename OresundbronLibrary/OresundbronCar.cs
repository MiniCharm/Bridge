using Bridge;

namespace OresundbronLibrary
{
    public class OresundbronCar : Car
    {
        public OresundbronCar(string licenselate, DateTime date, bool brobiz) : base(licenselate, date, brobiz)
        {
        }

        public override double Price()
        {
            return 460;
        }

        public override double PriceWithBrobisDiscount(double price)
        {
            if (Brobiz == true)
            {
                price = 178;
            }
            return price;
        }

        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }

}
