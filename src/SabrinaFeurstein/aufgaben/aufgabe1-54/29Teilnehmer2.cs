using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Teilnehmer2

    {
        public static void kurs()
        {
            string[] teilnehmer =
            [
                "Jona",
                "Kerim",
                "Julian",
                "Katja",
                "Sabrina",
                "Selin",
                "Sheila",
                "Lia",
                "Laura",
                "Sasha",
            ];
            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {teilnehmer[i]}");
            }
            Console.WriteLine($"Anzahl der Teilnehmer: {teilnehmer.Length}");
        }

    }
}