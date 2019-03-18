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
            Assert.AreEqual(21, WeirdCalcuator.DoSomeUnnecessaryCalculation(1, 2));
        }
    }
}