using System;

namespace Appdevhb25.SabrinaFeurstein.uebung
{
    public class aufgabe16
    {
        public static void HigherOrLower()
        {
            Random num = new Random();
            int random = num.Next(1, 100);

            Console.Write("Gib eine Zahl zwischen 1 und 100 ein: ");
            int zahl = Convert.ToInt32(Console.ReadLine());

            while (zahl != random)
            {
                if (zahl < random)
                {
                    Console.Write("größer: ");
                    zahl = Convert.ToInt32(Console.ReadLine());
                }
                if (zahl > random)
                {
                    Console.Write("kleiner: ");
                    zahl = Convert.ToInt32(Console.ReadLine());
                }
            }
            if (zahl == random)
            {
                Console.WriteLine("Zahl erraten!");
            }
        }
    }
}