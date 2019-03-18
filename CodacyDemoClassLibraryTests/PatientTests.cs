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
    public class PatientTests
    {
        [TestMethod()]
        public void getFullNameTest()
        {
            Patient patient = new Patient(
                    "Beleren", "Jace", Convert.ToDateTime("2002-06-01")
                );

            Assert.AreEqual("Jace Beleren", patient.getFullName());
        }

        [TestMethod()]
        public void getPatientAgeTest()
        {
            Patient patient = new Patient(
                    "Beleren", "Jace", Convert.ToDateTime("2002-06-01")
                );

            Assert.AreEqual(17, patient.getPatientAge());
        }
    }
}