
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class FaktorialBonus

    {
        public static void Fakultaet(int min, int max)
        {
            long produkt = 1;
            long faktor = 1;

            for (long j = 1; j <= max; j++)
            {
                produkt = produkt * faktor;
                faktor = faktor + 1;
                Console.WriteLine($"{j}! = {produkt, 20}");
            }
        }
    }
}
