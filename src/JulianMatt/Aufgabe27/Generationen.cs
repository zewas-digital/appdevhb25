using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

namespace Appdevhb25.JulianMatt.Aufgabe27
{
    public class Generationen
    {

        public static void Start27()
        {
            while (true)
            {
                GenerationCheck();
                string answer = ReapeatTheLoop();
                if (answer == "ja")
                {

                }

                else if (answer == "nein")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Ungültige Eingabe, das Programm wird beendet.");
                    break;
                }
            }
        }

        public static void GenerationCheck()
        {
            Console.WriteLine("Bitte geben sie ihren Namen und ihr Geburtsjahr an z.B Julian Matt 2009");
            Console.Write("Vorname: ");
            string name = Console.ReadLine();
            Console.Write("Nachname: ");
            string lastName = Console.ReadLine();
            GenerationVerification(name, lastName, IsAgeRight());
        }

        public static int IsAgeRight()
        {
            bool isStringValid;
            int result;
            do
            {
                Console.Write("Alter: ");
                string age = Console.ReadLine();

                isStringValid = int.TryParse(age, out result);

            } while (isStringValid == false);

            return result;
        }

        public static void GenerationVerification(string name, string lastName, int age)
        {
            Console.WriteLine();
            Console.Write(name + " " + lastName + " " + age + ": ");
            LookingForGeneration(age);
            Console.WriteLine();
        }

        public static void LookingForGeneration(int age)
        {
            int gen = 2025 - age;
            if (gen >= 2025)
            {
                Console.WriteLine("Generation Beta (Gen Beta)");
            }
            else if (gen >= 2011 && gen <= 2024)
            {
                Console.WriteLine("Generation Alpha (Gen Alpha)");
            }
            else if (gen >= 1997 && gen <= 2010)
            {
                Console.WriteLine("Generation Z (Zoomer - Digital Natives)");
            }
            else if (gen >= 1981 && gen <= 1996)
            {
                Console.WriteLine("Generation Y (Me/Millennials)");
            }
            else if (gen >= 1965 && gen <= 1980)
            {
                Console.WriteLine("Generation X (Slackers)");
            }
            else if (gen >= 1946 && gen <= 1964)
            {
                Console.WriteLine("Generation Boomer (Baby Boomer)");
            }
            else if (gen >= 1928 && gen <= 1945)
            {
                Console.WriteLine("Silent Generation (Weltrkriegsgeneration)");
            }
            else
            {
                Console.WriteLine("Really old Generation");
            }


        }

        public static string ReapeatTheLoop()
        {
            Console.WriteLine("Möchten sie eine weitere Person überprüfen? Ja oder Nein");
            string answer = Console.ReadLine().ToLower();
            return answer;
        }
    }
}
