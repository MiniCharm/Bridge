using Bridge;
using StoreBealtTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBridge
{
    [TestClass]
    public sealed class TestReposetoryStorbealt
    {
        [TestMethod]
        public void GetAllTickets()
        {
            //Arrange
            Reposetory storRepo = new Reposetory();
            List<Vehicle> listOfV = storRepo.GetAllTickets();
            Vehicle v = new Car("1111111", new DateTime(2025, 07, 05), false);

            //act
            storRepo.AddTicket(v);
            

            //Assert
            Assert.IsNotNull(listOfV);
        }

        [TestMethod]
        public void TestAddTicket() 
        {
            //Arrange
            Reposetory storRepo = new Reposetory();
            List<Vehicle> listOfV = storRepo.GetAllTickets();
            Vehicle v = new Car("1111111", new DateTime(2025, 07, 05), false);

            //act
            int countBEfore = listOfV.Count();
            storRepo.AddTicket(v);
            int countAfter = listOfV.Count();

            //Assert
            Assert.AreEqual(countBEfore + 1, countAfter);
        }

        [TestMethod]
        public void GetTicketsFromLicensplate()
        {
            //Arrange
            Reposetory storRepo = new Reposetory();
            List<Vehicle> listOfV = storRepo.GetAllTickets();
            Vehicle v = new Car("5555555", new DateTime(2025, 07, 05), false);
            Vehicle v1 = new Car("5555555", new DateTime(2025, 09, 03), true);

            //act
            storRepo.AddTicket(v);
            storRepo.AddTicket(v1);
            List<Vehicle> found= storRepo.GetTicketsFromPlate("5555555");

            Assert.AreEqual(found.Count(), 2);

        }

    }
}
