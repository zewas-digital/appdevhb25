using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Appdevhb25.SelinUlutuerk.Aufgabe50
{
    class WhenAndWhere
    {
        public static void Start()
        {
            CultureInfo austrian = new CultureInfo("de-AT");

            DateTime moment = DateTime.Now;

            System.Console.WriteLine(moment.ToString("d"));
            System.Console.WriteLine(moment.ToString("t"));
            System.Console.WriteLine(moment.ToString());
            System.Console.WriteLine(moment.ToString("dd.MM.yyyy HH:mm zzzz"));
            System.Console.WriteLine(moment.ToString("ss.ffff"));
        }   
    }
}