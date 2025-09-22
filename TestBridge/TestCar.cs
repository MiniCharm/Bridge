using Bridge;

namespace TestBridge
{
    [TestClass]
    public sealed class TestCar
    {
        [TestMethod]
        public void TestInvalidLisenceplateCar() 
        {
            //Act
            Action invalidLisenceplate = () => new Car("11111111111", DateTime.Now,false);
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
            double result = c.PriceWithBrobisDiscount();

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
