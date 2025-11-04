using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe27
{

    public class Generations
    {

        public static void StartGenerations()
        {
            Console.WriteLine("----------Aufgabe 27----------");

            Console.WriteLine("Gib dein Name ein:");
            string name = Helper.checkUserInputString();

            Console.WriteLine("Gib dein Alter ein:");
            int age = Helper.checkUserInputInteger();

            Console.WriteLine(getGeneration(age, name));
        }

        public static string getGeneration(int age, string name)
        {
            int birthYear = DateTime.Now.Year - age;

            if (birthYear >= 1928 && birthYear <= 1945)
            {
                return name + " " + age + ": " + "Generation Silent";
            }
            else if (birthYear >= 1946 && birthYear <= 1964)
            {
                return name + " " + age + ": " + "Generation (Baby) Boomer";
            }
            else if (birthYear >= 1965 && birthYear <= 1980)
            {
                return name + " " + age + ": " + "Generation X";
            }
            else if (birthYear >= 1981 && birthYear <= 1996)
            {
                return name + " " + age + ": " + "Generation Y";
            }
            else if (birthYear >= 1997 && birthYear <= 2009)
            {
                return name + " " + age + ": " + "Generation Z";
            }
            else if (birthYear >= 2011 && birthYear <= 2024)
            {
                return name + " " + age + ": " + "Generation Alpha";
            }
            else
            {
                return name + " " + age + ": " + "Generation Beta";
            }

            // switch (birthYear)
            // {
            //     case int year when year >= 1928 && year <= 1968:
            //         return name + " " + age + ": " + "Generation Silent";

            //     case int year when year >= 1946 && year <= 1964:
            //         return name + " " + age + ": " + "Generation Silent";

            //     case int year when year >= 1965 && year <= 1980:
            //         return name + " " + age + ": " + "Generation Silent";

            //     case int year when year >= 1981 && year <= 1996:
            //         return name + " " + age + ": " + "Generation Silent";

            //     case int year when year >= 1997 && year <= 2009:
            //         return name + " " + age + ": " + "Generation Silent";

            //     case int year when year >= 2010 && year <= 2024:
            //         return name + " " + age + ": " + "Generation Silent";

            //     default:
            //         return name + " " + age + ": " + "Generation Beta";
            // }
        }
    

    }
}
