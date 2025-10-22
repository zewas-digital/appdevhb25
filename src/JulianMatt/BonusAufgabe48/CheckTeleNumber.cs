using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml;

namespace Appdevhb25.JulianMatt.BonusAufgabe48
{
    public class CheckTeleNumber
    {

        public static void BonusStart48()
        {
            string Number = GetTeleNumber();
            IsTeleValid(Number);
        }
        public static string GetTeleNumber()
        {
            System.Console.WriteLine("Geben sie ihr Nummer ein");
            string NumberInformation = Console.ReadLine();
            return NumberInformation;
        }

        public static void IsTeleValid(string Number)
        {
            string pattern = "[+1-998|00 1-998]+ |-" + "[1-9999]+ |-" + "[1-9]{3,10}$";

            Regex regex = new Regex(pattern);

            if (regex.IsMatch(Number))
            {
                Console.WriteLine("Die Nummer ist gültig.");
            }
            else
            {
                Console.WriteLine("Die Nummer ist ungültig.");
            }
        }
    }
}