using Bridge;
using OresundbronLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBridge
{
        [TestClass]
        public sealed class TestOresundMCTestOresundMC
        {
            [DataTestMethod]
            [DataRow("11111111111")]
            [DataRow("77777777")]
            [TestMethod]
            public void TestInvalidLisenceplatMC(string licensplate)
            {
                //Act
                Action invalidLisenceplate = () => new OresundbronMC(licensplate, new DateTime(2025, 10, 01), false);
                //Arrange
                Assert.ThrowsException<ArgumentException>(invalidLisenceplate);
            }

            [DataTestMethod]
            [DataRow("7586954")]
            [DataRow("968574")]
            [DataRow("78596")]
            [TestMethod]
            public void TestvalidLisenceplatMC(string licensplate)
            {
                //Act
                Vehicle mc = new OresundbronMC(licensplate, new DateTime(2025, 10, 01), false);
                //Arrange
                Assert.AreEqual(licensplate, mc.Licenseplate);
            }


            [TestMethod]
            public void TestPriceMC()
            {
                //Arrange
                Vehicle mc = new OresundbronMC("7777777", new DateTime(2025, 10, 01), false);

                //Act
                double result = mc.Price();

                //Assert
                Assert.AreEqual(result, 235);
            }


            [TestMethod]
            public void TestPriceMCWithBrobiz()
            {
                //Arrange
                Vehicle mc = new OresundbronMC("8888888", new DateTime(2025, 10, 01), true);

                //Act
                double result = mc.PriceWithBrobisDiscount(mc.Price());

                //Assert
                Assert.AreEqual(result, 92);
            }

            [TestMethod]
            public void TestVehicleTypeMC()
            {
                //Arrange
                Vehicle mc = new OresundbronMC("7777777", new DateTime(2025, 10, 01), false);

                //Act
                string result = mc.VehicleType();

                //Assert
                Assert.AreEqual(result, "Oresund MC");
            }
        }
}
