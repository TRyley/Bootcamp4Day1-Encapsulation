using System.Collections.Generic;
using Bootcamp4Day1_Encapsulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class InterfaceTest
    {

        private static List<IVehicle> _vehicles;

        [ClassInitialize]
        public static void Setup(TestContext t)
        {
            _vehicles = new List<IVehicle>();
            Engine carEngine = new Engine();
            _vehicles.Add(new Bicycle());
            _vehicles.Add(new Car(carEngine));
            _vehicles.Add(new Bike(carEngine));
            _vehicles.Add(new Boat(carEngine));
        }

        [TestMethod]
        public void CallingGenericMethods()
        {
            foreach (var vehicle in _vehicles)
            {
                vehicle.Accelerate();
                var currentSpeed = vehicle.GetCurrentSpeed();

                Assert.AreEqual(currentSpeed, 1);
            }
        }
    }
}