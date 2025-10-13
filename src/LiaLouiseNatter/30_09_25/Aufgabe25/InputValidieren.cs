using System;
using System.Runtime.Intrinsics.Arm;
using System.Globalization;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe25
{
    public class InputValidieren
    {
        public static void Start()
        {
            ParseInt();
            ParseFloat();
            ParseBool();
        }

        public static int ParseInt()
        {
            System.Console.WriteLine("Please enter an integer:");
            int numberP;
            while (!int.TryParse(Console.ReadLine(), out numberP))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            return numberP;
        }

        public static float ParseFloat()
        {
            System.Console.WriteLine("Please enter a float:");
            float numberF;
            while (!float.TryParse(Console.ReadLine(), out numberF))
            {
                Console.WriteLine("Invalid input. Please enter a valid float.");
            }
            return numberF;
        }  

        public static bool ParseBool()
        {
            System.Console.WriteLine("Please enter true or false:");
            bool boolP;
            while (!bool.TryParse(Console.ReadLine(), out boolP))
            {
                Console.WriteLine("Invalid input. Please enter true or false.");
            }
            return boolP;
        }
    }
}