using System;
using System.ComponentModel.DataAnnotations;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe05
{
    public class PrintLine
    {
        public static void Start()
        {
            // Console.Write(new string('-', 10));
            // int amountSymbol = 5;
            // for (int i = 0; i < amountSymbol; i++)
            // {
            //     Console.Write("-");
            // }

             int i = 0;
             int amountSymbol = 5;
            // while (i < amountSymbol)
            // {
            //     Console.Write("-");
            //     i++; // wieder aus der Schleife raus
            // }

            do
            {
                Console.Write("*");
                i++; // wieder aus der Schleife raus
            }
            while (i < amountSymbol);
        }

    }
        
}