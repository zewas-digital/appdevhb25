using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

namespace Appdevhb25.JulianMatt.Aufgabe29
{
    public class Teilnehmer02
    {

        public static void Start29()
        {
            string[] name = { "Julian", "Kerim", "Jona", "Noah", "Lia", "Marcel" };

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + name[i]);
            }
            Console.WriteLine("Es sind " + name.Length + " Teilnehmer angemeldet.");
        }


    }
}
