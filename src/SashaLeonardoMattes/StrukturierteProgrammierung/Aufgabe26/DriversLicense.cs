using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe26
{

    public class DriversLicense
    {

        public static void StartDriversLicense()
        {
            Console.WriteLine("----------Aufgabe 26----------");

            Console.WriteLine("Wie viele Personen möchtest du erstellen?");
            int lenght = Helper.checkUserInputInteger();
            string name;
            int age;

            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("Gib einen Namen ein:");
                name = Helper.checkUserInputString();
                Console.WriteLine("Gib eine Alter ein:");
                age = Helper.checkUserInputInteger();

                Console.WriteLine($"{name} {age}: Moped: {LicenseMoped(age)}, Auto: {LicenseCar(age)}, für beide Fahrzeuge: {LicenseCar(age)}");
            }

        }

        public static string LicenseCar(int age)
        {
            if (age > 17)
            {
                return "Ja";
            }
            else
            {
                return "Nein";
            }
        }
        
         public static string LicenseMoped(int age)
        {
            if (age > 14)
            {
                return "Ja";
            }            
            else
            {
                return "Nein";
            }
        }

    }
}
