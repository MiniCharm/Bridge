using Bridge;

namespace TestBridge
{
    [TestClass]
    public sealed class TestCar
    {
        [TestMethod]
        public void TestPrice()
        {
            //Arrange
            Car c = new Car();

            //Act
            double result = c.Price();

            //Assert
            Assert.AreEqual(result, 230);
        }

        [TestMethod]
        public void TestVehicleType()
        {
            //Arrange
            Car c = new Car();

            //Act
            string result = c.VehicleType();

            //Assert
            Assert.AreEqual(result, "Car");
        }



    }
}
