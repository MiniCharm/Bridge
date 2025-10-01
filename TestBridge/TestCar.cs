using Bridge;
using StoreBealtTicketLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestBridge
{
    [TestClass]
    public sealed class TestCar
    {
        [DataTestMethod]
        [DataRow("333333333333")]
        [DataRow("88888888")]
        [DataRow("789513498")]
        [TestMethod]
        public void TestInvalidLisenceplateCar(string licensplate) 
        {
            //Act
            Action invalidLisenceplate = () => new Car(licensplate, new DateTime(2025, 10, 01), false);
            //Arrange
            Assert.ThrowsException<ArgumentException>(invalidLisenceplate);
        }

        [DataTestMethod]
        [DataRow("759648")]
        [DataRow("4862157")]
        [DataRow("96587")]
        [TestMethod]
        public void TestvalidLisenceplateCar(string licensplate) 
        {
            //Act
            Vehicle car = new Car(licensplate, new DateTime(2025, 10, 01), false);
            //Assert
            Assert.AreEqual(licensplate, car.Licenseplate);
        }

        [TestMethod]
        public void TestPriceCar()
        {
            //Arrange
            Vehicle c = new Car("5555555", DateTime.Now,false);

            //Act
            double result = c.Price();

            //Assert
            Assert.AreEqual(result, 230);
        }

        [TestMethod]
        public void TestPriceCarWithBrobiz()
        {
            //Arrange
            Vehicle c = new Car("6666666", new DateTime(2025, 10, 01), true);

            //Act
            double result = c.PriceWithBrobisDiscount(c.Price());

            //Assert
            Assert.AreEqual(result, 207);
        }

        [TestMethod]
        public void TestVehicleTypeCar()
        {
            //Arrange
            Vehicle c = new Car("1111111", new DateTime(2025, 10, 01), false);

            //Act
            string result = c.VehicleType();

            //Assert
            Assert.AreEqual(result, "Car");
        }
    }
}
