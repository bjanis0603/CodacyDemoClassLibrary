using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodacyDemoClassLibrary
{
    public static class WeirdCalcuator
    {
        public static string ThisMethodIsNotUsed()
        {
            return "Nope, it sure isn't!";
        }

        public static int DoSomeUnnecessaryCalculation(int a, int b)
        {
            int output;

            if (a > 9)
            {
                b = 7;
            }
            else if (a > 8)
            {
                b = 3;
            }
            else if (a > 7)
            {
                b = 3;
            }
            else if (b < a)
            {
                a = b * 3;
            }

            string unnecessaryString = HowOftenDoesPatientVisit(a);

            if (a != b)
            {
                string anotherUnnecessaryThing = HowOftenDoesPatientVisit(b);
            }
            else
            {
                string yetAnotherUnnecessaryThing = HowOftenDoesPatientVisit(a - b);
            }

            output = b * a;

            return output;
        }

        public static int DoAnotherUnnecessaryCalculation(int a, int b)
        {
            int output;

            if (a > 9)
            {
                b = 7;
            }
            else if (a > 8)
            {
                b = 3;
            }
            else if (a > 7)
            {
                b = 3;
            }
            else if (b < a)
            {
                a = b * 3;
            }

            string unnecessaryString = HowOftenDoesPatientVisit(a);

            if (a != b)
            {
                string anotherUnnecessaryThing = HowOftenDoesPatientVisit(b);
            }
            else
            {
                string yetAnotherUnnecessaryThing = HowOftenDoesPatientVisit(a - b);
            }

            output = b * a;

            return output;
        }

        public static string HowOftenDoesPatientVisit(int numberOfVisits)
        {
            //string thisIsBad = "We should not have commented out code in our files";

            string returnValue = string.Empty;
            switch(numberOfVisits)
            {
                case 0:
                    {
                        returnValue = "This is a new patient";
                        break;
                    }
                case 1:
                    {
                        returnValue = "This patient has been here once";
                        break;
                    }
                case 2:
                    {
                        returnValue = "This patient has been here more than once";
                        break;
                    }
                case 3:
                    {
                        returnValue = "This patient has been here than once";
                        break;
                    }
                default:
                    {
                        returnValue = "This patient visits here a lot";
                        break;
                    }                   
            }
            return returnValue;
        }
    }
}
