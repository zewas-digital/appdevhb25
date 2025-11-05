using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe28
{
    class Teilnehmer
    {
        public static void Start()
        {
            string[] teilnehmer = new string[3];

            teilnehmer[0] = "Jona";
            teilnehmer[1] = "Kerim";
            teilnehmer[2] = "Julian";

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine($"{teilnehmer[i]}");
            }
            Console.WriteLine($"Anzahl der Teilnehmer: {teilnehmer.Length}");
        }
    }
}