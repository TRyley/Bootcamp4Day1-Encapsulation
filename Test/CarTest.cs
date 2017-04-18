using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bootcamp4Day1_Encapsulation;

namespace Test
{
    [TestClass]
    public class CarTest
    {
        private static Car _testCar;

        [ClassInitialize]
        public static void Setup(TestContext t)
        {
            _testCar = new Car();
        }

        [TestMethod]
        public void Reverse_WhenCalled_Reverses()
        {
            decimal expectedSpeed = -2;
            decimal currentSpeed;

            _testCar.Reverse();

            currentSpeed = _testCar.GetCurrentSpeed();

            Assert.AreEqual(expectedSpeed, currentSpeed);
        }
    }
}
