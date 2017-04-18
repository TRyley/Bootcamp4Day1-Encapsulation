using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bootcamp4Day1_Encapsulation;
namespace Test
{
    [TestClass]
    public class EngineTest
    {
        private static MotorVehicle _car;

        [ClassInitialize]
        public static void Setup(TestContext t)
        {
            Engine engine = new Engine();
            _car = new MotorVehicle(engine);
        }
        [TestMethod]
        public void Accelerate_WhenCalled_IncreasesSpeed()
        {
            decimal expectedSpeed = 1;
            decimal actualSpeed;

            _car.Accelerate();
            actualSpeed = _car.GetCurrentSpeed();

            Assert.AreEqual(expectedSpeed, actualSpeed);
        }

        [TestMethod]
        public void GetEngineSize()
        {
            decimal expectedSize = 10;

            decimal engineSize = _car.GetEngineSize();

            Assert.AreEqual(expectedSize, engineSize);
        }
    }
}
