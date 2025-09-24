using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBealtTicketLibrary
{
    public class Reposetory
    {
        private static List<Vehicle> _vehicles = new List<Vehicle> 
        { 
                new Car("2222222", new DateTime(2025, 07, 05), false), 
                new Car("1111111", new DateTime(2025, 08, 05), true) 
        };

        public void AddTicket(Vehicle vehicle) 
        {
            _vehicles.Add(vehicle);
        }

        public List<Vehicle> GetAllTickets() 
        {
            return _vehicles;
        }

        public List<Vehicle> GetTicketsFromPlate(string licenseplate)
        {
            return _vehicles.Where(v => v.Licenseplate == licenseplate).ToList();
        }
    }
}
