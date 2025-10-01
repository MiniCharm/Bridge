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
            Action invalidLisenceplate = () => new MC(licensplate, new DateTime(2025, 10, 1), false);
            //Assert
            Assert.ThrowsException<ArgumentException>(invalidLisenceplate);
        }

        [DataTestMethod]
        [DataRow("1111")]
        [DataRow("7652148")]
        [DataRow("96584")]
        [TestMethod]
        public void TestValidLisenceplateMc( string licensplate) 
        {
            //Act
            Vehicle mc = new MC(licensplate, new DateTime(2025, 10, 1), false);

            //Assert
            Assert.AreEqual(licensplate, mc.Licenseplate);
            
        }

        [TestMethod]
        public void TestPriceMcWithBrobiz()
        {
            //Arrange
            Vehicle mc = new MC("8888888", new DateTime(2025, 10, 1), true);

            //Act
            double result = mc.PriceWithBrobisDiscount(mc.Price());

            //Assert
            Assert.AreEqual(result, 108);
        }

        [TestMethod]
        public void TestPriceMC()
        {
            //Arrange
            Vehicle mc = new MC("6666666", new DateTime(2025, 10, 1), false);

            //Act
            double result = mc.Price();

            //Assert
            Assert.AreEqual(result, 120);
        }

        [TestMethod]
        public void TestVehicleTypeMC()
        {
            //Arrange
            Vehicle mc = new MC("5864792", new DateTime(2025, 10, 1), false);

            //Act
            string result = mc.VehicleType();

            //Assert
            Assert.AreEqual(result, "MC");
        }



    }
}
