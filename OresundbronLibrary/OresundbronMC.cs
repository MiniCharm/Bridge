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

        public override double PriceWithBrobisDiscount(double price)
        {
            if (Brobiz == true) 
            {
                price = 92;
            }
            return price;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
