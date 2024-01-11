using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M320_Projektarbeit;
using M320_Projektarbeit.Employee;

namespace M320ProjektarbeitTest
{

    [TestFixture]
    public class TestDriver
    {
        [Test]
        public void TestAddDelivery()
        {
            // Arrange
            Driver d = new Driver();
            var driver = new Driver("TestDriver", "TestAddress", "TestAccount", 1000);
            var delivery = new Delivery(/* Konstruktorparameter */);

            // Act
            driver.addDelivery(delivery);

            // Assert
            Assert.Contains(delivery, driver.getDeliveries());
        }
    }
}