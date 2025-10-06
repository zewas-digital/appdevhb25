
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class PiNilakantha
    {
        public static void Pi()
        {
            double pi = 3;
            double nenner = 2;

            for (int i = 0; i < int.MaxValue; i++)
            {
                pi = pi + 4 / (nenner * (nenner + 1) * (nenner + 2));
                nenner = nenner + 2;
                pi = pi - 4 / (nenner * (nenner + 1) * (nenner + 2));
                nenner = nenner + 2;
            }
            Console.WriteLine($"Berechnung von Pi mit der Nilakantha Reihe: {pi}");
        }
    }
}
