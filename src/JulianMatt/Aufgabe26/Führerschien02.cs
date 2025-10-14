using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

namespace Appdevhb25.JulianMatt.Aufgabe26
{
    public class Führerschein02
    {

        public static void Start2601()
        {
            string[] namen = { "Michael", "Peter", "Anna", "Lena", "Tom" };
            int[] alter = { 16, 20, 14, 18, 15 };

            Console.WriteLine("Überprüfung der Fahrzeugberechtigung:");

            for (int i = 0; i < namen.Length; i++)
            {
                AgeVerification(namen[i], alter[i]);
            }
        }

        public static void AgeVerification(string name, int age)
        {
            Console.WriteLine();
            Console.Write("Name: " + name + " (" + age + "): Moped: ");
            Bike(age);
            Console.Write("Auto: ");
            Car(age);
            Console.Write("Für beide Fahrzeuge: ");
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

    }
}
