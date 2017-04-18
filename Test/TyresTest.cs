using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bootcamp4Day1_Encapsulation;

namespace Test
{
    [TestClass]
    public class TyresTest
    {
        private static Tyres tyres;
        [ClassInitialize]
        public static void Setup(TestContext t)
        {
            tyres = new Tyres();
        }
        [TestMethod]
        public void ChangeSpeed_WhenCalled_ChangesSpeedByPassedInValue()
        {
            decimal expected = 3;
            decimal actual;
            decimal fast = 3;

            tyres.ChangeSpeed(fast);
            actual = tyres.GetSpeed();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChangeSpeed_WhenCalled_ChangesSpeedByPassedInValueNegative()
        {
            decimal expected = 1;
            decimal actual;
            decimal fast = -2;

            tyres.ChangeSpeed(fast);
            actual = tyres.GetSpeed();

            Assert.AreEqual(expected, actual);
        }
    }
}
