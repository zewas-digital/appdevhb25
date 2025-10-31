using System;
using System.Text.RegularExpressions;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe49Bonus
{
    public  class ValidateEmail
    {
        public static void ValidEmail()
        {
            string input;
            string pattern = @"^\S+@\S+\.\S+$";

            System.Console.WriteLine("Pls enter your email address.");
            
            do
            {
                input = Console.ReadLine();

                bool isValidEmail = Regex.IsMatch(input, pattern);

                if (isValidEmail == true)
                {
                    System.Console.WriteLine("Email address accepted.");
                    break; // aus der Schleife raus wenn valid email address
                }
                else
                {
                    System.Console.WriteLine("Pls enter a valid email address.");
                }
                
            } while (true);
        }
    }
}