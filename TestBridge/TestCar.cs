using Bridge;

namespace TestBridge
{
    [TestClass]
    public sealed class TestCar
    {
        [TestMethod]
        public void TestInvalidLisenceplate() 
        {
            //Act
            Action invalidLisenceplate = () => new Car("11111111111", DateTime.Now);
            //Arrange
            Assert.ThrowsException<ArgumentException>(invalidLisenceplate);
        }

        [TestMethod]
        public void TestPriceCar()
        {
            //Arrange
            Vehicle c = new Car("7777777", DateTime.Now);

            //Act
            double result = c.Price();

            //Assert
            Assert.AreEqual(result, 230);
        }

        [TestMethod]
        public void TestVehicleTypeCar()
        {
            //Arrange
            Vehicle c = new Car("7777777", DateTime.Now);

            //Act
            string result = c.VehicleType();

            //Assert
            Assert.AreEqual(result, "Car");
        }



    }
}
