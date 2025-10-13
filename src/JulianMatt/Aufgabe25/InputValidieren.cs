using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Appdevhb25.JulianMatt.Aufgabe25
{
    public class InputValidieren
    {
        public static void Start25()
        {
            GetNumber();
            GetDouble();
            GetFloat();
            GetLong();
        }

        public static int GetNumber()
        {
            bool isInteger;
            int result;
            do
            {
                Console.WriteLine("Gib eine Ganzzahl ein: ");
                string input = Console.ReadLine();

                isInteger = int.TryParse(input, out result);

            } while (isInteger == false);

            return result;
        }

        public static double GetDouble()
        {
            bool isDouble;
            double result;
            do
            {
                Console.WriteLine("Gib eine Kommazahl ein01: ");
                string input = Console.ReadLine();

                isDouble = double.TryParse(input, out result);

            } while (isDouble == false);

            return result;
        }

        public static float GetFloat()
        {
            bool isFloat;
            float result;
            do
            {
                Console.WriteLine("Gib eine Kommazahl ein02: ");
                string input = Console.ReadLine();

                isFloat = float.TryParse(input, out result);

            } while (isFloat == false);

            return result;
        }

        public static long GetLong()
        {
            bool isLong;
            long result;
            do
            {
                Console.WriteLine("Gib eine große Ganzzahl ein: ");
                string input = Console.ReadLine();

                isLong = long.TryParse(input, out result);

            } while (isLong == false);

            return result;
        }


    }
}
