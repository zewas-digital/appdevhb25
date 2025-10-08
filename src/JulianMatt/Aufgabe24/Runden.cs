using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Appdevhb25.JulianMatt.Aufgabe24
{
    public class Runden
    {

        public static void Start24()
        {
            while (true)
            {
                Process();
            }

        }

        public static void Process()
        {
            Console.WriteLine("Geben sie eine Kommazahl ein die für sie gerundet werden soll z.B 100.28489");
            Console.Write("Zahl: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben sie an auf welche Stelle sie die Zahl gerundet haben wollen z.B 2");
            Console.Write("Komma Stelle: ");
            int numberOfDecimalPlaces = Convert.ToInt32(Console.ReadLine());
            Output(number, numberOfDecimalPlaces);
        }

        public static void Output(double number, int numberOfDecimalPlaces)
        {
            int numberAsInt = (int)(number * Math.Pow(10, numberOfDecimalPlaces + 1));

            int einerstelle = numberAsInt % 10;

            numberAsInt /= 10;

            if (einerstelle < 5)
            {

            }
            else
            {
                numberAsInt += 1;
            }
            Console.WriteLine(numberAsInt / Math.Pow(10, numberOfDecimalPlaces));
        }
    }
}
