using System;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe04
{

    public class HigherOrLower
    {
        
        public static void StartHigherOrLower()
        {
            Random rndGen = new Random();
            Console.WriteLine("----------Aufgabe 05----------");
            int zufallsZahl = rndGen.Next(0, 100 + 1);
            int guess;

            

            do
            {
                Console.WriteLine("Gib eine Zahl ein:");
                guess = Helper.checkUserInputInteger();
                
                if (zufallsZahl > guess)
                {
                    Console.WriteLine("Die gesuchte Zahl ist größer");
                }
                else if (zufallsZahl < guess)
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner");
                }
                else
                {
                    Console.WriteLine("Du hast die gesuchte Zahl gefunden");
                }

            } while (guess != zufallsZahl);
        }

    }
}
