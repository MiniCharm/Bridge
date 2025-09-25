using Bridge;
using OresundbronLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBridge
{
        public sealed class TestOresundMC
        {
            [DataTestMethod]
            [DataRow("11111111111")]
            [DataRow("77777777")]
            [TestMethod]
            public void TestInvalidLisenceplatMC(string licensplate)
            {
                //Act
                Action invalidLisenceplate = () => new OresundbronMC(licensplate, DateTime.Now, false);
                //Arrange
                Assert.ThrowsException<ArgumentException>(invalidLisenceplate);
            }

            [TestMethod]
            public void TestPriceMC()
            {
                //Arrange
                Vehicle mc = new OresundbronMC("7777777", DateTime.Now, false);

                //Act
                double result = mc.Price();

                //Assert
                Assert.AreEqual(result, 235);
            }


            [TestMethod]
            public void TestPriceMCWithBrobiz()
            {
                //Arrange
                Vehicle mc = new OresundbronMC("8888888", DateTime.Now, true);

                //Act
                double result = mc.PriceWithBrobisDiscount(mc.Price());

                //Assert
                Assert.AreEqual(result, 95);
            }

            [TestMethod]
            public void TestVehicleTypeMC()
            {
                //Arrange
                Vehicle mc = new OresundbronMC("7777777", DateTime.Now, false);

                //Act
                string result = mc.VehicleType();

                //Assert
                Assert.AreEqual(result, "Oresund MC");
            }
        }

}
