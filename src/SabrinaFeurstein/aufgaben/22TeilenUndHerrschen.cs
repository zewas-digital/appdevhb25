
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class TeilenUndHerrschen

    {
        public static void var(int min, int max)
        {
            for (int x = min; x < max; x++)
            {
                var erg1 = x / 5;
                var erg2 = x / 5.0;

                Console.WriteLine($"{x} / 5 = {erg1}");
                Console.WriteLine($"{x} / 5.0 = {erg2}");

                // Zahl ohne Kommastelle wird als int interpretiert -> Ergebnis wird als int angegeben (ohne Kommastellen)
                // durch Verwendung von .0 wird Zahl als double erkannt -> Ergebnis mit Kommastelle
            }
        }
    }
}
