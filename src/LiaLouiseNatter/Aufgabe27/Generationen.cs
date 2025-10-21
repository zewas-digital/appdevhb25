using System;
using System.Runtime.Intrinsics.Arm;
using System.Globalization;
using System.ComponentModel;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe27
{
    public class Generationen
    {
        public static void Start()
        {
            string name = EnterName();
            int age = EnterAge();
            
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
        

        public static string? getGenerationByAge(int age)
        {
            if (age < 15)
            {
                return "Generation Alpha";
            }

            if (age < 28)
            {
                return "Generation Z";
            }

            if (age < 44)
            {
                return "Generation Y";
            }

            if (age < 60)
            {
                return "Generation X";
            }

            if (age < 61)
            {
                return "Babyboomer";
            }

            if (age < 97)
            {
                return "Silent Generation";
            }

            return null; 
        }
        

        public static void Output(int age, string name)
        {
            System.Console.WriteLine($"{name} {age}: {getGenerationByAge(age)}");
        }
    }
}