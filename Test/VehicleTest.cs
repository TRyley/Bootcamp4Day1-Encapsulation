using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bootcamp4Day1_Encapsulation;

namespace Test
{
    [TestClass]
    public class VehicleTest
    {
        public static MotorVehicle TestMotorVehicle;

        public object TestCar { get; private set; }

        [ClassInitialize]
        public static void Setup(TestContext t)
        {
            Engine engine = new Engine();
            TestMotorVehicle = new MotorVehicle(engine);
        }
        [TestMethod]
        public void GetCurrentSpeed_WhenCalled_ReturnsSpeed()
        {
            //Arrange
            decimal expectedSpeed = 0;
            decimal actualSpeed;
            //Act
                actualSpeed = TestMotorVehicle.GetCurrentSpeed();
            //Assert
            Assert.AreEqual(expectedSpeed, actualSpeed);
        }

        [TestMethod]
        public void Accelerate_WhenCalled_IncreasesSpeed()
        {
            decimal expectedSpeed = 1;
            decimal actualSpeed;

            TestMotorVehicle.Accelerate();
            actualSpeed = TestMotorVehicle.GetCurrentSpeed();

            Assert.AreEqual(expectedSpeed, actualSpeed);
        }

        [TestMethod]
        public void Brake_WhenCalled_DecreasesSpeed()
        {
            decimal expectedSpeed = 0;
            decimal actualSpeed;

            TestMotorVehicle.Brake();
            actualSpeed = TestMotorVehicle.GetCurrentSpeed();

            Assert.AreEqual(expectedSpeed, actualSpeed);
        }

        [TestMethod]
        public void Brake_IfSpeedIs0_NothingHappens()
        {
            decimal expectedSpeed = 0;
            decimal actualSpeed;

            TestMotorVehicle.Brake();
            actualSpeed = TestMotorVehicle.GetCurrentSpeed();

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
                TestMotorVehicle.Accelerate(accel);
            }
            actualSpeed = TestMotorVehicle.GetCurrentSpeed();

            Assert.AreEqual(expectedSpeed, actualSpeed);
            
        }

        [TestMethod]
        public void Brake_WhenValuePassed_SpeedDecreasesByThatAmount()
        {
            decimal expectedSpeed = 2;
            decimal actualSpeed;
            decimal brake = 0.6M;

            TestMotorVehicle.Accelerate();

            TestMotorVehicle.Brake(brake);

            actualSpeed = TestMotorVehicle.GetCurrentSpeed();

            Assert.AreEqual(actualSpeed, expectedSpeed);
        }

        [TestMethod]
        public void Brake_WhenSpeedEquals0_NothingHappens()
        {
            decimal expectedSpeed = 0;
            decimal actualSpeed;
            decimal brake = 0.1M;

            while (TestMotorVehicle.GetCurrentSpeed() != 0)
            {
                TestMotorVehicle.Brake(brake);
            }

            TestMotorVehicle.Brake(brake);

            actualSpeed = TestMotorVehicle.GetCurrentSpeed();

            Assert.AreEqual(actualSpeed, expectedSpeed);
        }
        [TestMethod]
        public void StartEngine_IsCalled_EngineIsStarted()
        {
            bool expectedEngineState = true;
            bool actualEngineState;

            TestMotorVehicle.StartEngine();                    

            actualEngineState = TestMotorVehicle.IsEngineOn();

            Assert.AreEqual(expectedEngineState, actualEngineState);
        }
        [TestMethod]
        public void StopEngine_IsCalled_EngineIsStopped()
        {
            bool expectedEngineState = false;
            bool actualEngineState;

            TestMotorVehicle.StopEngine();

            actualEngineState = TestMotorVehicle.IsEngineOn();

            Assert.AreEqual(expectedEngineState, actualEngineState);
        }

        [TestMethod]
        public void Reverse_WhenCalled_Reverses()
        {
            decimal expectedSpeed = -2;
            decimal currentSpeed;

            TestMotorVehicle.Reverse();

            currentSpeed = TestMotorVehicle.GetCurrentSpeed();

            Assert.AreEqual(expectedSpeed, currentSpeed);
        }

        [TestMethod]
        public void Steer_WhenCalled_Steers()
        {
            //positive for right
            //negative for left
            decimal expectedDirection = 10M;

            TestMotorVehicle.Steer(expectedDirection);

            var currentDirection = TestMotorVehicle.GetCurrentDirection();

            Assert.AreEqual(expectedDirection, currentDirection);
        }
    }
}