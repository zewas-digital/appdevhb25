using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe16
{
    public class HigherOrLower
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 16)");
            PrintHigherOrLower(); 
        }
        public static void PrintHigherOrLower()
        {
            Console.WriteLine("Rate eine Zahl zwischen 1 und 100."); 
            int number = Convert.ToInt32(Console.ReadLine());

            // erstellt neue Variable (Objekt) vom Typ Random
            Random rand = new Random();
            int numberToGuess = rand.Next(1, 101); //inklusive 100
            while (number != numberToGuess)
            {
                if (number < numberToGuess)
                {
                    Console.WriteLine($"Die gesuchte Zahl ist höher als {number}.");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Die gesuchte Zahl ist niedriger als {number}.");
                    number = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine($"Herzlichen Glückwünsch! Du hast die Zahl {numberToGuess} erraten."); 
        }
    }
}