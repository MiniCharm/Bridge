using Bridge;

namespace TestBridge
{
    [TestClass]
    public sealed class TestMC
    {
        [TestMethod]
        public void TestPriceMC()
        {
            //Arrange
            Vehicle mc = new MC();

            //Act
            double result = mc.Price();

            //Assert
            Assert.AreEqual(result, 120);
        }

        [TestMethod]
        public void TestVehicleTypeMC()
        {
            //Arrange
            Vehicle mc = new MC();

            //Act
            string result = mc.VehicleType();

            //Assert
            Assert.AreEqual(result, "MC");
        }



    }
}
