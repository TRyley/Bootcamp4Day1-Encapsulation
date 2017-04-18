using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bootcamp4Day1_Encapsulation;

namespace Test
{
    [TestClass]
    public class VehicleTest
    {
        public static Vehicle TestVehicle;

        public object TestCar { get; private set; }

        [ClassInitialize]
        public static void Setup(TestContext t)
        {
            TestVehicle = new Vehicle();
        }
        [TestMethod]
        public void GetCurrentSpeed_WhenCalled_ReturnsSpeed()
        {
            //Arrange
            decimal expectedSpeed = 0;
            decimal actualSpeed;
            //Act
                actualSpeed = TestVehicle.GetCurrentSpeed();
            //Assert
            Assert.AreEqual(expectedSpeed, actualSpeed);
        }

        [TestMethod]
        public void Accelerate_WhenCalled_IncreasesSpeed()
        {
            decimal expectedSpeed = 1;
            decimal actualSpeed;

            TestVehicle.Accelerate();
            actualSpeed = TestVehicle.GetCurrentSpeed();

            Assert.AreEqual(expectedSpeed, actualSpeed);
        }

        [TestMethod]
        public void Brake_WhenCalled_DecreasesSpeed()
        {
            decimal expectedSpeed = 0;
            decimal actualSpeed;

            TestVehicle.Brake();
            actualSpeed = TestVehicle.GetCurrentSpeed();

            Assert.AreEqual(expectedSpeed, actualSpeed);
        }

        [TestMethod]
        public void Brake_IfSpeedIs0_NothingHappens()
        {
            decimal expectedSpeed = 0;
            decimal actualSpeed;

            TestVehicle.Brake();
            actualSpeed = TestVehicle.GetCurrentSpeed();

            Assert.AreEqual(expectedSpeed, actualSpeed);
        }
        [TestMethod]
        public void Accelerate_WhenValuePassed_SpeedIncreasesByThatAmount()
        {
            decimal expectedSpeed = 1.6M;
            decimal actualSpeed;
            decimal accel = 0.8M;

            for (var i = 0; i < 2; i++)
            {
                TestVehicle.Accelerate(accel);
            }
            actualSpeed = TestVehicle.GetCurrentSpeed();

            Assert.AreEqual(expectedSpeed, actualSpeed);
            
        }

        [TestMethod]
        public void Brake_WhenValuePassed_SpeedDecreasesByThatAmount()
        {
            decimal expectedSpeed = 2;
            decimal actualSpeed;
            decimal brake = 0.6M;

            TestVehicle.Accelerate();

            TestVehicle.Brake(brake);

            actualSpeed = TestVehicle.GetCurrentSpeed();

            Assert.AreEqual(actualSpeed, expectedSpeed);
        }

        [TestMethod]
        public void Brake_WhenSpeedEquals0_NothingHappens()
        {
            decimal expectedSpeed = 0;
            decimal actualSpeed;
            decimal brake = 0.1M;

            while (TestVehicle.GetCurrentSpeed() != 0)
            {
                TestVehicle.Brake(brake);
            }

            TestVehicle.Brake(brake);

            actualSpeed = TestVehicle.GetCurrentSpeed();

            Assert.AreEqual(actualSpeed, expectedSpeed);
        }
        [TestMethod]
        public void StartEngine_IsCalled_EngineIsStarted()
        {
            bool expectedEngineState = true;
            bool actualEngineState;

            TestVehicle.StartEngine();                    

            actualEngineState = TestVehicle.IsEngineOn();

            Assert.AreEqual(expectedEngineState, actualEngineState);
        }
        [TestMethod]
        public void StopEngine_IsCalled_EngineIsStopped()
        {
            bool expectedEngineState = false;
            bool actualEngineState;

            TestVehicle.StopEngine();

            actualEngineState = TestVehicle.IsEngineOn();

            Assert.AreEqual(expectedEngineState, actualEngineState);
        }
    }
}