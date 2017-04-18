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
            Engine engine = new Engine();
            _testCar = new Car(engine);
        }

    }
}
