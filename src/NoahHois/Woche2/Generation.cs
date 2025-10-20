using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Appdevhb25.NoahHois.Aufgabe20
{
    public class Generation
    {

        static string getGenerationByAge(int age)
        {
            // Jahrgang berechnen
            int jahrgang = 2025 - age;
            // Rückgabe Generation abhängig von Jahrgang
            if (jahrgang >= 2025)
            {
                return "Beta";
            }
            if (jahrgang >= 2011 && jahrgang <= 2024)
            {
                return "Alpha";
            }
            if (jahrgang >= 1997 && jahrgang <= 2010)
            {
                return "Z";
            }
            if (jahrgang >= 1981 && jahrgang <= 1996)
            {
                return "Y";
            }
            if (jahrgang >= 1965 && jahrgang <= 1980)
            {
                return "X";
            }
            if (jahrgang >= 1946 && jahrgang <= 1964)
            {
                return "Boomer";
            }
            if (jahrgang >= 1928 && jahrgang <= 1945)
            {
                return "Silent";
            }
            return "unbekannt";
        }

        public static void AusgabeGenerationen()
        {
            // Anna 10
            Console.WriteLine("Anna 10: Generation " + getGenerationByAge(10));
            // Peter 20
            Console.WriteLine("Peter 20: Generation " + getGenerationByAge(20));
            // Martin 50
            Console.WriteLine("Martin 50: Generation " + getGenerationByAge(50));
        }

    }
}