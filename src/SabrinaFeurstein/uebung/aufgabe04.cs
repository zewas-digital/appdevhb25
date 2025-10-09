using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using Appdevhb25.SabrinaFeurstein.uebung;

namespace Appdevhb25.SabrinaFeurstein.uebung
{
    public class aufgabe04
    {
        public static void intervall(int start, int ende, int teiler)
        {
            Console.WriteLine("Teiler: " + teiler);
            Console.WriteLine("Intervallstart: " + start);
            Console.WriteLine("Intervallende: " + ende);
            for (int i = start; i <= ende; i++)
            {
                if (i % teiler == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}