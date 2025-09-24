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
    [ExcludeFromCodeCoverage]
    [TestClass]
    public sealed class TestOresundCar
    {
        [DataTestMethod]
        [DataRow("11111111111")]
        [DataRow("77777777")]
        [TestMethod]
        public void TestInvalidLisenceplateCar(string licensplate)
        {
            //Act
            Action invalidLisenceplate = () => new OresundbronCar(licensplate, DateTime.Now, false);
            //Arrange
            Assert.ThrowsException<ArgumentException>(invalidLisenceplate);
        }

        [TestMethod]
        public void TestPriceCar()
        {
            //Arrange
            Vehicle c = new OresundbronCar("7777777", DateTime.Now, false);

            //Act
            double result = c.Price();

            //Assert
            Assert.AreEqual(result, 460);
        }

        [TestMethod]
        public void TestPriceCarWithBrobiz()
        {
            //Arrange
            Vehicle c = new OresundbronCar("8888888", DateTime.Now, true);

            //Act
            double result = c.PriceWithBrobisDiscount(c.Price());

            //Assert
            Assert.AreEqual(result, 178);
        }

        [TestMethod]
        public void TestVehicleTypeCar()
        {
            //Arrange
            Vehicle c = new OresundbronCar("7777777", DateTime.Now, false);

            //Act
            string result = c.VehicleType();

            //Assert
            Assert.AreEqual(result, "Oresund Car");
        }
    }
}
