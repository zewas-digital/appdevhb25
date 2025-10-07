using System;

namespace Appdevhb25.NoahHois.Aufgabe13
{
    public class PrimitiveDatentypenSumme
    {
        public static void Aufgabe13()
        {
            int alteSumme = 20, neueSumme = 0;
            for (int i = 21; i <= 50; i++)
            {
                neueSumme = alteSumme + i;
                Console.WriteLine(alteSumme + " + " + i + " = " + neueSumme);
                alteSumme = neueSumme;
            }
        }
    }
}

