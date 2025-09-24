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
            Vehicle c = new Car("6666666", DateTime.Now, true);

            //Act
            double result = c.PriceWithBrobisDiscount(c.Price());

            //Assert
            Assert.AreEqual(result, 207);
        }

        [TestMethod]
        public void TestVehicleTypeCar()
        {
            //Arrange
            Vehicle c = new Car("1111111", DateTime.Now,false);

            //Act
            string result = c.VehicleType();

            //Assert
            Assert.AreEqual(result, "Car");
        }
    }
}
