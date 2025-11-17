using System;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe49
{
    class ValidateEmail
    {
        public static void Start()
        {
            System.Console.WriteLine("Gib eine gültige Telefonnummer in folgendem Format ein: \n (lokaler-Teil@Domain)");

            string? input = Console.ReadLine();
            bool isValid = Email(input);

            if (isValid)
            {
                Console.WriteLine("Die Email Adresse ist gültig.");
            }
            else
            {
                Console.WriteLine("Die Email Adresse ist ungültig.");
            }
        }

        public static bool Email(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            string pattern = @"^(?!\.)[a-zA-Z0-9._%+-]+(?<!\.)@(?:(?!-)[a-zA-Z0-9-]{1,63}(?<!-)\.)+[a-zA-Z]{2,}$";

            return Regex.IsMatch(input, pattern);
        }
    }
}