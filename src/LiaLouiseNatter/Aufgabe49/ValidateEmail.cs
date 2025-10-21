using System;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe49
{
    public class ValidateEmail
    {
        public static void Start()
        {
            MailChecker();
        }

        private static void MailChecker()
        {

            string[] testNumbers =
            {
                "max.mustermann@example.de",
                "user_123@mail.example.com",
                "test+info99@web-server.org",
                "max mustermann@example.de",
                "user!@mail.de",
                "admin@web-.de",
                "+43 677-61(72)2146",
                "sasha.mattes@gmail.com",
                "kerim.alkis@hilti.com"
            };

            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9-]+(\.[a-zA-Z0-9]+)*\.[a-zA-Z]{2,}$");


            // @ verbatem literal - für die ganzen /
            // "^ kennzeichnet den start
         

            foreach (string numbers in testNumbers)
            {
                bool correctNumer = regex.IsMatch(numbers);
                if (correctNumer)
                {
                    System.Console.WriteLine($"{numbers} is a Valid Mail");
                }
                else
                {
                    System.Console.WriteLine($"{numbers} is not a Valid Mail");
                }
                
            }


            
        }


        


    }
}

