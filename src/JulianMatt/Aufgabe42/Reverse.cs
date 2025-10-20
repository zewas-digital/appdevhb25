using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using Appdevhb25.JulianMatt.Aufgabe01;
using Appdevhb25.JulianMatt.Aufgabe03;

namespace Appdevhb25.JulianMatt.Aufgabe42
{
    public class Reverse
    {

        public static void Start42()
        {
            string spinAround = StringMaker();
            Spinner(spinAround);
        }

        public static string StringMaker()
        {
            string spinString = Console.ReadLine();
            return spinString;
        }

        public static void Spinner(string word)
        {
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();
        }
       
    }



}

