using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bootcamp4Day1_Encapsulation;

namespace Test
{
    [TestClass]
    public class BicycleTest
    {
        public static Bicycle TestBike;
        [ClassInitialize]
        public static void Setup(TestContext t)
        {
            TestBike = new Bicycle();
        }
        [TestMethod]
        public void GetCurrentSpeed_WhenCalled_ReturnsSpeed()
        {
            //Arrange
            decimal expectedSpeed = 0;
            decimal actualSpeed;
            //Act
            actualSpeed = TestBike.GetCurrentSpeed();
            //Assert
            Assert.AreEqual(expectedSpeed, actualSpeed);
        }

        [TestMethod]

        public void Accelerate_WhenCalled_IncraseSpeed()
        {
            decimal expectedSpeed = 1;
            decimal actualSpeed;

            TestBike.Accelerate();
            actualSpeed = TestBike.GetCurrentSpeed();

            Assert.AreEqual(expectedSpeed, actualSpeed);
        }
        [TestMethod]
        public void Brake_WhenCalled_DecreaseSpeed()
        {
            decimal expectedSpeed = 0;
            decimal actualSpeed;

            TestBike.Brake();
            actualSpeed = TestBike.GetCurrentSpeed();

            Assert.AreEqual(expectedSpeed, actualSpeed);
        }

        [TestMethod]
        public void Accelerate_WhenValuePassed_SpeedIncreasesByValue()
        {
            decimal expectedSpeed = 0.6M;
            decimal actualSpeed;

            TestBike.Accelerate(0.6M);
            actualSpeed = TestBike.GetCurrentSpeed();

            Assert.AreEqual(expectedSpeed, actualSpeed);
        }
        [TestMethod]
        public void Brake_WhenValuePassed_SpeedDecreasesByValue()
        {
            decimal expectedSpeed = 0;
            decimal actualSpeed;

            TestBike.Brake(0.6M);
            actualSpeed = TestBike.GetCurrentSpeed();

            Assert.AreEqual(expectedSpeed, actualSpeed);
        }
    }
}
