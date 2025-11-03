using System;
using System.Text.RegularExpressions;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe48Bonus
{
    public  class ValidatePhoneNumber
    {
        public static void ValidPhoneNumber()
        {
            string input;
            string pattern = @"^(?:\+|00)\d{1,3}[\s\-]?(?:\d[\s\-]?){6,14}\d$";

            System.Console.WriteLine("Pls enter your phone number.");
            
            do
            {
                input = Console.ReadLine();

                bool isValidPhoneNumber = Regex.IsMatch(input, pattern);

                if (isValidPhoneNumber == true)
                {
                    System.Console.WriteLine("phone number accepted.");
                    // break; // aus der Schleife raus wenn valid phone number
                }
                else
                {
                    System.Console.WriteLine("Pls enter a valid phone number.");
                }
                
            } while (true);
        }
    }
}