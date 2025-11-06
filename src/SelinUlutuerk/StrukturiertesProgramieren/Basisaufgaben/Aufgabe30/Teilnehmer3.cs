using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe30
{
    class Teilnehmer3
    {
        public static void Start()
        {
            /*V1
            string[] teilnehmer = new string[3]; 

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine("Teilnehmer Name: ");
                teilnehmer[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {teilnehmer[i]}");
            }
            Console.WriteLine($"Anzahl der Teilnehmer: {teilnehmer.Length}");*/

            //V2

            Console.WriteLine("Wie viele Teilnehmer gibt es?");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            string[] teilnehmer = new string[anzahl];

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine("Teilnehmer Name: ");
                teilnehmer[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {teilnehmer[i]}");
            }
            Console.WriteLine($"Anzahl der Teilnehmer: {teilnehmer.Length}");
        }
    }
}