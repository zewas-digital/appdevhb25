using System;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe48
{
    class ValidatePhoneNumber
    {
        public static void Start()
        {
            System.Console.WriteLine("Gib eine gültige Telefonnummer in folgendem Format ein: \n [Ländervorwahl][Orts-/Netzvorwahl][Teilnehmernummer]");
            
            string? input = Console.ReadLine();
            bool isValid = Number(input);

            if (isValid)
            {
                Console.WriteLine("Die Telefonnummer ist gültig.");
            }
            else
            {
                Console.WriteLine("Die Telefonnummer ist ungültig.");
            }
        }

        public static bool Number(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            // zum entfernen von Sonderzeichen
            string cleaned = Regex.Replace(input, @"[\s\-\(\)]", "");

            if (Regex.IsMatch(cleaned, @"^\+\+"))
                return false;
            

            if (Regex.IsMatch(cleaned, @"^(?:\+|00)[0-9]{1,3}"))
            {
                // Entferne Ländervorwahl
                cleaned = Regex.Replace(cleaned, @"^(?:\+|00)[0-9]{1,3}", "");
            }

            else if (cleaned.StartsWith("0"))
            {
                // ohne Ländervorwahl
                cleaned = cleaned.Substring(1);
            }

            else
            {
                // Weder gültige Ländervorwahl noch nationale Nummer
                return false;
            }

            return Regex.IsMatch(cleaned, @"^[0-9]{3,10}$");
        }
    }
}