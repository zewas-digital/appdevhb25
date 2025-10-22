using System;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe48
{
    public class ValidatePhoneNumber
    {
        public static void Start()
        {
            NumberChecker();
        }

        private static void NumberChecker()
        {

            string[] testNumbers =
            {
                "+49 30 1234567",
                "0049-30-1234567",
                "0301234567",
                "+49 30 12A4567",
                "++49 301234567",
                "+49-30-123#456",
                "+43 677-61(72)2146"
            };

            Regex regex = new Regex(@"^(\+|00|0)?[1-9][1-9]([ \-()]*[0-9]){3,11}$");

            // @ verbatem literal - für die ganzen /
            // "^ kennzeichnet den start
            // [1-9][1-9] für die zwei zahlen nach dem + oder 00
            // [0-9\s\s\-()]{3,6} 3-10 Zahlen von 0-9 die durch -, space und () getrennt sein können

            foreach (string numbers in testNumbers)
            {
                bool correctNumer = regex.IsMatch(numbers);
                if (correctNumer)
                {
                    System.Console.WriteLine($"{numbers} is a Valid Number");
                }
                else
                {
                    System.Console.WriteLine($"{numbers} is not a Valid Number");
                }
                
            }


            
        }


        


    }
}

