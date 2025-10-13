using System;
using System.Runtime.InteropServices.Marshalling;

namespace Appdevhb25.SheilaMayJaro.Aufgabe27
{
    public class Generations
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 27)");
            Console.WriteLine(getGenerationsByAge("Anna", 36));
            Console.WriteLine(getGenerationsByAge("Martin", 56));
            Console.WriteLine(getGenerationsByAge("Gabriela", 23)); 
            Console.WriteLine(getGenerationsByAge("Lukas", 12)); 

        }
        public static string getGenerationsByAge(string name, int age)
        {
            if (age <= 0) // ab 2025
            {
                return $"{name} {age}: Generation Beta";
            }
            if (age <= 14) // 2011 - 2024
            {
                return $"{name} {age}: Generation Alpha";
            }
            if (age > 14 && age <= 28) // 1997 - 2010
            {
                return $"{name} {age}: Generation Z";
            }
            if (age > 14 && age <= 28) // 1981 - 1996
            {
                return $"{name} {age}: Generation Y";
            }
            if (age > 28 && age <= 44) // 1965 - 1980
            {
                return $"{name} {age}: Generation X";
            }
            if (age > 44 && age <= 60) // 1946 - 1964
            {
                return $"{name} {age}: Generation (Baby) Boomer";
            }
            if (age > 60 && age <= 97) // 1928 - 1945
            {
                return $"{name} {age}: Generation Silent";
            }
            return " "; 
        }
    }
}