using System;
using System.Text.RegularExpressions;
namespace Appdevhb25.SheilaMayJaro.Aufgabe48
{
    public class ValidatePhoneNumber
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 48)");

            string test = "+49 30 1234567";
            Console.WriteLine(IsPhoneNumberValid(test));
            string test1 = "0049-30-1234567";
            Console.WriteLine(IsPhoneNumberValid(test1));
            string test2 = "0301234567";
            Console.WriteLine(IsPhoneNumberValid(test2));
            string test3 = "+49 30 12A4567";
            Console.WriteLine(IsPhoneNumberValid(test3));
            string test4 = "++49 30 123456";
            Console.WriteLine(IsPhoneNumberValid(test4));

        }
        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            //[Ländervorwahl][Orts-/Netzvorwahl][Teilnehmernummer]
            //mögliche Ländervorwahlen 
            // string countryPhoneNumberPrefix = "+49";
            // string countryPhoneNumberPrefix1 = "^0049$";
            // //Orts-/Netzvorwahl
            // string countryPhoneNumberPrefix2 = "^30$";
            string pattern = @"^(?:\+|00|03)\d{1,3}[\s\-]?(?:\d[\s\-]?){6,14}\d$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}