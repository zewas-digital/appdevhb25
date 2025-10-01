using System;
using System.ComponentModel.DataAnnotations;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe02
{
    public class Mahlreihe
    {
        public static void Start()
        {
            int numbers = 8;
            for (int i = 0; i < numbers; i++)
            {
                int product = i * numbers; //ergebnis von Malrechnen (factor mal factor = product)
                Console.WriteLine($"{i} * {numbers} = {product}");
            }
        }

    }
        
}
