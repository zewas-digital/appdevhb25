using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe23
{

    public class Divide0To20
    {

        public static void StartDivide0To20()
        {
            Console.WriteLine("----------Aufgabe 23----------");

            for (var i = 0; i <= 20; i ++)
            {
                var result = i / 5; //speichert als int, weil er sich nicht ergebnis sondern Datentypen der Rechnung (hier int und int ansieht)
                var floatResult = i / 5.0; //speichert als double
                Console.WriteLine("{0:F0} / 5   = {1,4}", i, result);
                Console.WriteLine("{0:F0} / 5.0 = {1,4}", i, floatResult);
            }

        }

    }
}
