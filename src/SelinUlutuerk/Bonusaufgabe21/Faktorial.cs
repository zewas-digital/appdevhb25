using System;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe21
{
    class Faktorial
    {
        public static void Start(int zahl)
        {
            Console.WriteLine("Bonus Aufgabe");

            long produkt = 1;
            for (int i = 1; i <= zahl; i++)
            {
                produkt = produkt * i;

                Console.WriteLine($"{i}! = {produkt, 20}");
            }
            
        }
    }
}