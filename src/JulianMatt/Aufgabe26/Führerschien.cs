using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

namespace Appdevhb25.JulianMatt.Aufgabe26
{
    public class Führerschein
    {

        public static void Start26()
        {
            while (true)
            {
                LicenceCheck();
                string answer = ReapeatTheLoop();
                if ( answer == "ja")
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

        public static void LicenceCheck()
        {
            Console.WriteLine("Bitte geben sie zuerst ihren Namen an und danach ihr Alter z.B Julian Matt 29");
            Console.Write("Vorname: ");
            string name = Console.ReadLine();
            Console.Write("Nachname: ");
            string lastName = Console.ReadLine();
            AgeVerification(name, lastName, IsAgeRight());
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

        public static void AgeVerification(string name, string lastName, int age)
        {
            Console.Write("Name: " + name + " " + lastName + ", Moped: ");
            Bike(age);
            Console.Write("Auto: ");
            Car(age);
            Console.Write("Beide Fahrzeuge: ");
            CanDriveBoth(age);
        }

        public static void Bike(int age)
        {
            if (age >= 15)
            {
                Console.Write("Ja, ");
            }
            else
            {
                Console.Write("Nein, ");
            }
        }

        public static void Car(int age)
        {
            if (age >= 18)
            {
                Console.Write("Ja, ");
            }
            else
            {
                Console.Write("Nein, ");
            }
        }

        public static void CanDriveBoth(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Ja");
            }
            else
            {
                Console.WriteLine("Nein");
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
