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

        /// <summary>
        /// En Add metode, som tilføjer et Vehcle objekt til en statisk  liste
        /// </summary>
        /// <param name="vehicle">Returnerer et vehicle objekt</param>
        public void AddTicket(Vehicle vehicle) 
        {
            _vehicles.Add(vehicle);
        }

        /// <summary>
        /// En Get metode, som henter alle Vehcle der er i en statisk liste
        /// </summary>
        /// <returns></returns>
        public List<Vehicle> GetAllTickets() 
        {
            return _vehicles;
        }

        /// <summary>
        /// Metode, som hender alle Vehcles med den pågældende licenseplate
        /// </summary>
        /// <param name="licenseplate">En Vehcle licensplate</param>
        /// <returns>Returnere en liste Vehcles </returns>
        public List<Vehicle> GetTicketsFromPlate(string licenseplate)
        {
            return _vehicles.Where(v => v.Licenseplate == licenseplate).ToList();
        }
    }
}
