using Bridge;

namespace TestBridge
{
    [TestClass]
    public sealed class TestMC
    {
        [TestMethod]
        public void TestInvalidLisenceplate()
        {
            //Act
            Action invalidLisenceplate = () => new MC("11111111111", DateTime.Now);
            //Arrange
            Assert.ThrowsException<ArgumentException>(invalidLisenceplate);
        }

        [TestMethod]
        public void TestPriceMC()
        {
            //Arrange
            Vehicle mc = new MC("6666666",DateTime.Now);

            //Act
            double result = mc.Price();

            //Assert
            Assert.AreEqual(result, 120);
        }

        [TestMethod]
        public void TestVehicleTypeMC()
        {
            //Arrange
            Vehicle mc = new MC("6666666", DateTime.Now);

            //Act
            string result = mc.VehicleType();

            //Assert
            Assert.AreEqual(result, "MC");
        }



    }
}
