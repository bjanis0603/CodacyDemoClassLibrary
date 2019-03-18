using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodacyDemoClassLibrary
{
    public class Patient
    {
        private readonly string lastName;
        private readonly string firstName;
        public DateTime dateOfBirth;

        public Patient(string _lastName, string _firstname, DateTime _DateOfBirth)
        {
            this.lastName = _lastName;
            this.firstName = _firstname;
            this.dateOfBirth = _DateOfBirth;
        }

        public string getFullName()
        {
            return $"{this.firstName} {this.lastName}";
        }

        public int getPatientAge()
        {
            return DateTime.Today.Year - dateOfBirth.Year;
        }

        public string PrintSomethingBasedOnAge()
        {
            string output = string.Empty;
            if (getPatientAge() < 18)
            {
                return "Patient is a minor";
            }
            else if (getPatientAge() >= 18)
            {
                return "Patient is an adult";
            }
            return output;
        }
    }
}
