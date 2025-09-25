using Bridge;
using StoreBealtTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBridge
{
    [TestClass]
    public sealed class TestStorbealtTicket
    {
        [DataTestMethod]
        [DataRow(2025, 9, 20)]
        [DataRow(2025, 7, 20)]
        [DataRow(2025, 6, 28)]
        [DataRow(2025, 1, 18)]

        [TestMethod]
        public void TestCarWeekenddiscountWithBrobiz(int år, int måned, int dag)
        {
            //Arrange
            StorBealtExtended car = new StorBealtExtended("7777777", new DateTime(år, måned, dag), true);
            
            //Act
            double result = car.WeekendDiscount();

            //Assert
            Assert.AreEqual(result, 175.95, 0.1);
        }

    }
}
