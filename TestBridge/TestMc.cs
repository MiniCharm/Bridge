using Bridge;

namespace TestBridge
{
    [TestClass]
    public sealed class TestMC
    {
        [DataTestMethod]
        [DataRow("11111111111")]
        [DataRow("77777777")]
        [DataRow("862496357")]
        [TestMethod]
        public void TestInvalidLisenceplateMc(string licensplate)
        {
            //Act
            Action invalidLisenceplate = () => new MC(licensplate, DateTime.Now,false);
            //Arrange
            Assert.ThrowsException<ArgumentException>(invalidLisenceplate);
        }

        [TestMethod]
        public void TestValidLisenceplateMc() 
        { 

            
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
