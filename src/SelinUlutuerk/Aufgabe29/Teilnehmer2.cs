using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe29
{
    class Teilnehmer2
    {
        public static void Start()
        {
            string[] teilnehmer = new string[3];

            teilnehmer[0] = "Jona";
            teilnehmer[1] = "Kerim";
            teilnehmer[2] = "Julian";

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine($"{i+1}. {teilnehmer[i]}");
            }
            Console.WriteLine($"Anzahl der Teilnehmer: {teilnehmer.Length}");
        }
    }
}