using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodacyDemoClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodacyDemoClassLibrary.Tests
{
    [TestClass()]
    public class WeirdCalcuatorTests
    {
        [TestMethod()]
        public void DoSomeUnnecessaryCalculationTest()
        {
            WeirdCalcuator calcuator = new WeirdCalcuator();

            Assert.AreEqual(21, calcuator.DoSomeUnnecessaryCalculation(1));
        }
    }
}