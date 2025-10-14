using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe22
{
    class TeilenundHerrschen
    {
        public static void Start()
        {
            for (int x = 0; x <= 20; x++)
            {
                var erg1 = x / 5;
                var erg2 = x / 5.0;
                Console.WriteLine($"{x} / 5   = {erg1}");
                
                Console.WriteLine($"{x} / 5.0 = {erg2}");   
            }
        }
    }
}