using System;
using System.Reflection;

namespace Appdevhb25.SheilaMayJaro.Aufgabe26
{
    public class DriversLicense
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 26)");
            PrintDriversLicense(17, "Alex");
            Console.WriteLine(); 
            PrintDriversLicense(22, "Bettina");
            Console.WriteLine(); 
            PrintDriversLicense(20, "Alwin");
            Console.WriteLine(); 
            PrintDriversLicense(13, "Linda");
            Console.WriteLine(); 
            PrintDriversLicense(39, "Nadine"); 

        }
        public static void PrintDriversLicense(int age, string name)
        {
            //berechtigt zum Moped fahren 
            if (age >= 16)
            {
                Console.WriteLine($"{name} ist berechtigt mit dem Moped zu fahren.");
            }
            else
            {
                Console.WriteLine($"{name} ist nicht berechtigt mit dem Moped zu fahren.");
            }
            if (age >= 18)
            {
                Console.WriteLine($"{name} ist berechtigt mit dem Auto zu fahren.");
            }
            else
            {
                Console.WriteLine($"{name} ist nicht berechtigt mit dem Auto zu fahren.");
            }
            if (age >= 16 && age >= 18)
            {
                Console.WriteLine($"{name} ist berechtigt mit beidem zu fahren.");
            }
            else
            {
                Console.WriteLine($"{name} ist nicht berechtigt mit beidem zu fahren.");
            }
        }
    }
}