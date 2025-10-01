using Bridge;

namespace StoreBealtTicketLibrary
{
    public class StorBealtExtended : Car
    {
        public StorBealtExtended(string licenselate, DateTime date, bool brobiz) : base(licenselate, date, brobiz)
        {

        }

        /// <summary>
        /// Method that returns the price with a weekend discount, and afterwords brobiz discount, if brobiz is true
        /// </summary>
        /// <returns>Returns a double prize</returns>
        public double WeekendDiscount() 
        {
            double price = base.Price();
            if (Date.DayOfWeek ==DayOfWeek.Sunday || Date.DayOfWeek == DayOfWeek.Saturday) 
            {
                price = price - 15 * (price / 100);
            }
            if (Brobiz == true) 
            {
                price= base.PriceWithBrobisDiscount(price);
            }
            return price;
        }
    }
}
