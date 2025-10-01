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
        /// <summary>
        /// A static list, that contains all vehicles, that crossed the bridge
        /// </summary>
        private static List<Vehicle> _vehicles = new List<Vehicle> 
        { 
                new Car("2222222", new DateTime(2025, 07, 05), false), 
                new Car("1111111", new DateTime(2025, 08, 05), true) 
        };

        /// <summary>
        /// Method, that adds a vehicle to a static list
        /// </summary>
        /// <param name="vehicle">Returns the vehicle object</param>
        public void AddTicket(Vehicle vehicle) 
        {
            _vehicles.Add(vehicle);
        }

        /// <summary>
        /// Method, that gets all the vehicles from a static list
        /// </summary>
        /// <returns></returns>
        public List<Vehicle> GetAllTickets() 
        {
            return _vehicles;
        }

        /// <summary>
        /// Method, taht gets all vehicle with a specific licensplate
        /// </summary>
        /// <param name="licenseplate">A licensplate</param>
        /// <returns>Returns a list</returns>
        public List<Vehicle> GetTicketsFromPlate(string licenseplate)
        {
            return _vehicles.Where(v => v.Licenseplate == licenseplate).ToList();
        }
    }
}
