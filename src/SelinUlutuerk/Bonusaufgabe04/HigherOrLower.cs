using System;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe15
{
    class HigherOrLower
    {
        public static void RandomNumber(int eingabe)
        {
            Random random = new Random();
            int gesuchteZahl = random.Next(1,101);

            Console.WriteLine("Errate die Zahl zwischen 1 und 100. Du hast maximal 10 Versuche.");

            for(int versuch = 1; versuch <=10; versuch++)
            {
                Console.Write($"Versuch {versuch}: ");
                eingabe = Convert.ToInt32(Console.ReadLine());

               if(eingabe > gesuchteZahl)
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner!");
                }      
                else if (eingabe < gesuchteZahl)
                {
                    Console.WriteLine("Die gesuchte Zahl ist größer!");
                }
                else
                {
                    Console.WriteLine($"Super! Die gesuchte Zahl war {gesuchteZahl}!");
                    return;
                } 
            }
        }
    }
}