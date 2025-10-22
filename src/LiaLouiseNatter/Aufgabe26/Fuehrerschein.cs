using System;
using System.Runtime.Intrinsics.Arm;
using System.Globalization;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe26
{

    public class Fuehrerschein
    {
        public static void Start()
        {
            string name = EnterName();
            int age = EnterAge();
            bool car = CarAge(age);
            bool moped = MopedAge(age);
            AgeChecker(name, age, car, moped);

        }

        public static void AgeChecker(string name, int age, bool car, bool moped)
        {
            
            printOutput(name, age, car, moped);
            
        }

        public static string EnterName()
        {
            Console.Write("Please enter your name: ");
            string? name;
            while (true)
            {
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name) || int.TryParse(name, out int _))
                {
                    System.Console.WriteLine("Please enter a valid name");
                    continue;
                }
                break;
            }
            return name;
        }
        
           public static int EnterAge()
        {
            Console.Write("Please enter your Age: ");
            int age;
            
            while(!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Enter a valid number.");
            }
            return age;
        }


        public static bool CarAge(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            return false;
        }
        
        public static bool MopedAge(int age)
        {
            if (age >= 15)
            {
                return true;
            }
            return false;
        }

        public static string carCheck(bool car)
        {
            if (car)
            {
                return "Auto Ja,";
            }
            return "Auto Nein,";
        
        }
        public static string mopedCheck(bool moped)
        {
            if (moped)
            {
                return "Moped Ja,";
            }
            return "Moped Nein,";
            
            
        }

        public static string bothCheck(bool car, bool moped)
        {
            if (car && moped)
            {
                return "für Beide Fahrzeuge: Ja";
            }
            else
            {
                return "Für Beide Fahruzeuge: Nein";
            }

        }

        public static void printOutput(string name, int age, bool car, bool moped)
        {
            System.Console.WriteLine($"{name} {age}:  { mopedCheck(moped)} {carCheck(car)} {bothCheck(car, moped)}");
        }
    }
}
// in SRP umbauen (in weitere FUnktionen aufteilen)