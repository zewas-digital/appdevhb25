using System;
using System.Data;

namespace Appdevhb25.NoahHois.Aufgabe15
{
    public class TeilenUndHerrschen
    {
        public static void Aufgabe15()
        {
            for (var i = 0; i <= 20; i++)
            {
                var erg1 = i / 5;
                var erg2 = i / 5.0;
                Console.WriteLine(i + " / 5  = " + erg1);
                Console.WriteLine(i + " / 5.0  = " + erg2);
            }
        }
    }
}