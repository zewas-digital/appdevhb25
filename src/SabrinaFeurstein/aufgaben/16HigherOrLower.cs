
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe16
{
    public class HigherOrLower
    {
        public static void Start()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 100);


            Console.WriteLine("Errate die Zahl (1-100):");

            int zahl = Convert.ToInt32(Console.ReadLine());

            while (zahl != random)
            {
                if (zahl < random)
                {
                    Console.WriteLine("größer");
                    zahl = Convert.ToInt32(Console.ReadLine());
                }
                if (zahl > random)
                {
                    Console.WriteLine("kleiner");
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
