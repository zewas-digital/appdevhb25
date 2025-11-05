using System;
using System.Globalization;

namespace Appdevhb25.SelinUlutuerk.Aufgabe25
{
    class InputValidieren
    {
        public static int Start()
        {
            Console.WriteLine("Your Number: ");

            var numberAsString = Console.ReadLine();

            int number;

            while (!int.TryParse(numberAsString, out number))
            {
                Console.WriteLine("This is not a number!");
                numberAsString = Console.ReadLine();
            }

            return number;
        }
    }
}