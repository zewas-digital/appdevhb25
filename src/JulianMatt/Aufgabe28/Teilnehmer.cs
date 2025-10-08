using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

namespace Appdevhb25.JulianMatt.Aufgabe28
{
    public class Teilnehmer
    {

        public static void Start28()
        {
            string[] name = { "Julian", "Kerim", "Jona", "Noah", "Lia", "Marcel" };

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("Es sind "+name.Length+" Teilnehmer angemeldet.");
        }
            

    }
}
