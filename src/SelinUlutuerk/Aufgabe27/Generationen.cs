using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe27
{
    class Generationen
    {
        public static void Start()
        {
            Console.WriteLine("Dein Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Dein Alter: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{name} {age}: Generation {getGenerationByAge(age)}");
        }
        public static string getGenerationByAge(int age)
        {
            age = 2025 - age;
            if (age <= 1945)
            {
                return "Silent";
            }
            else if (age <= 1964)
            {
                return "Boomer";
            }
            else if (age <= 1980)
            {
                return "X";
            }
            else if (age <= 1996)
            {
                return "Y";
            }
            else if (age <= 2010)
            {
                return "Z";
            }
            else if (age <= 2024)
            {
                return "Alpha";
            }
            else
            {
                return "Beta";
            }
        }
    }
}