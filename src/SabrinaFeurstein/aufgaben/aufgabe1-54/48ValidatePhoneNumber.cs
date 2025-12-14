using System;
using System.Text.RegularExpressions;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class ValidatePhoneNumber
    {
        public static void Start()
        {
            string number = "+43 666 545544";
            string pattern = @"^(\+|0{2})([0-9]{1,3})[- ]?([0-9]{2,5})[- ]?([0-9]{3,10})$";

            if (Regex.IsMatch(number, pattern))
                Console.WriteLine("Gültige Nummer");
            else
                Console.WriteLine("Ungültige Nummer");
        }
    }
}