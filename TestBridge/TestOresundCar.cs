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
            Action invalidLisenceplate = () => new OresundbronCar(licensplate, new DateTime(2025, 10, 01), false);
            //Arrange
            Assert.ThrowsException<ArgumentException>(invalidLisenceplate);
        }

        [DataTestMethod]
        [DataRow("7854964")]
        [DataRow("865247")]
        [TestMethod]
        public void TestValidLisenceplateCar(string licensplate)
        {
            //Act
            Vehicle car = new OresundbronCar(licensplate, new DateTime(2025, 10, 01), false);
            //Arrange
            Assert.AreEqual(licensplate, car.Licenseplate);
        }

        [TestMethod]
        public void TestPriceCar()
        {
            //Arrange
            Vehicle c = new OresundbronCar("7777777", new DateTime(2025, 10, 01), false);

            //Act
            double result = c.Price();

            //Assert
            Assert.AreEqual(result, 460);
        }

        [TestMethod]
        public void TestPriceCarWithBrobiz()
        {
            //Arrange
            Vehicle c = new OresundbronCar("8888888", new DateTime(2025, 10, 01), true);

            //Act
            double result = c.PriceWithBrobisDiscount(c.Price());

            //Assert
            Assert.AreEqual(result, 178);
        }

        [TestMethod]
        public void TestVehicleTypeCar()
        {
            //Arrange
            Vehicle c = new OresundbronCar("7777777", new DateTime(2025, 10, 01), false);

            //Act
            string result = c.VehicleType();

            //Assert
            Assert.AreEqual(result, "Oresund Car");
        }
    }
}
