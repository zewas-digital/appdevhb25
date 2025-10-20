using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml;

namespace Appdevhb25.JulianMatt.BonusAufgabe49
{
    public class CheckEMail
    {

        public static void BonusStart49()
        {
            string EMail = GetEMail();
            IsEmailValid(EMail);
        }
        public static string GetEMail()
        {
            System.Console.WriteLine("Schreiben sie Ihre E-Mail auf");
            string eMailInformation = Console.ReadLine();
            return eMailInformation;
        }

        public static void IsEmailValid(string EMail)
        {
            string pattern = @"^[a-zA-Z0-9._%+\-]+@" + @"[A-Za-z0-9.-_]+[.]" + @"[A-Za-z]{2,30}$";

            Regex regex = new Regex(pattern);

            if (regex.IsMatch(EMail))
            {
                Console.WriteLine("Die E-Mail-Adresse ist gültig.");
            }
            else
            {
                Console.WriteLine("Die E-Mail-Adresse ist ungültig.");
            }
        }
    }
}