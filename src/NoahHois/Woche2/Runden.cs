using System;

namespace Appdevhb25.NoahHois.Aufgabe17
{
    public class Runden
    {
        public static void Start()
        {
            Console.Write("Geben Sie eine Kommazahl ein: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Aufgabe17(number1, 2);
        }


        public static void Aufgabe17(double number1, int numberOfDecimalPlaces)
        {

            int numberAsInt = (int)(number1 * Math.Pow(10, numberOfDecimalPlaces + 1));

            int onePlace = numberAsInt % 10;

            numberAsInt /= 10;

            if (onePlace < 5)
            {

            }
            else
            {
                numberAsInt += 1;
            }
            Console.WriteLine("Hier die gerundete Zahl: " + numberAsInt / Math.Pow(10, numberOfDecimalPlaces));
        }
    }
}