using Bridge;
using StoreBealtTicketLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestBridge
{
    [TestClass]
    public sealed class TestCar
    {
        [DataTestMethod]
        [DataRow("11111111111")]
        [DataRow("77777777")]
        [TestMethod]
        public void TestInvalidLisenceplateCar(string licensplate) 
        {
            //Act
            Action invalidLisenceplate = () => new Car(licensplate, DateTime.Now,false);
            //Arrange
            Assert.ThrowsException<ArgumentException>(invalidLisenceplate);
        }

        [TestMethod]
        public void TestPriceCar()
        {
            //Arrange
            Vehicle c = new Car("7777777", DateTime.Now,false);

            //Act
            double result = c.Price();

            //Assert
            Assert.AreEqual(result, 230);
        }

        [TestMethod]
        public void TestPriceCarWithBrobiz()
        {
            //Arrange
            Vehicle c = new Car("8888888", DateTime.Now, true);

            //Act
            double result = c.PriceWithBrobisDiscount(c.Price());

            //Assert
            Assert.AreEqual(result, 207);
        }

        [TestMethod]
        public void TestVehicleTypeCar()
        {
            //Arrange
            Vehicle c = new Car("7777777", DateTime.Now,false);

            //Act
            string result = c.VehicleType();

            //Assert
            Assert.AreEqual(result, "Car");
        }
    }
}
