using System;
using System.Runtime.CompilerServices;
using Appdevhb25.SelinUlutuerk.Aufgabe19;

namespace Appdevhb25.SelinUlutuerk.Aufgabe20
{
    class Faktorial
    {
        public static void Start(int zahl)
        {

            long produkt = 1;
            for (int i = 1; i <= zahl; i++)
            {
                produkt = produkt * i;

                Console.WriteLine($"{produkt}");
            }
            
        }
    }
}