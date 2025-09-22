using Bridge;

namespace TestBridge
{
    [TestClass]
    public sealed class TestMC
    {
        [TestMethod]
        public void TestInvalidLisenceplateMc()
        {
            //Act
            Action invalidLisenceplate = () => new MC("11111111111", DateTime.Now,false);
            //Arrange
            Assert.ThrowsException<ArgumentException>(invalidLisenceplate);
        }

        [TestMethod]
        public void TestPriceMcWithBrobiz()
        {
            //Arrange
            Vehicle mc = new MC("8888888", DateTime.Now, true);

            //Act
            double result = mc.PriceWithBrobisDiscount(mc.Price());

            //Assert
            Assert.AreEqual(result, 108);
        }

        [TestMethod]
        public void TestPriceMC()
        {
            //Arrange
            Vehicle mc = new MC("6666666",DateTime.Now,false);

            //Act
            double result = mc.Price();

            //Assert
            Assert.AreEqual(result, 120);
        }

        [TestMethod]
        public void TestVehicleTypeMC()
        {
            //Arrange
            Vehicle mc = new MC("6666666", DateTime.Now,false);

            //Act
            string result = mc.VehicleType();

            //Assert
            Assert.AreEqual(result, "MC");
        }



    }
}
