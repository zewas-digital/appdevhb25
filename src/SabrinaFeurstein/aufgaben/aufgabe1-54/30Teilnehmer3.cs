using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Teilnehmer3

    {
        public static void fix()
        {
            int anzahl = 10;
            string[] teilnehmer = new string[anzahl];

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.Write("Name des Teilnehmers eingeben: ");
                teilnehmer[i] = Console.ReadLine()!;
            }

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {teilnehmer[i]}");
            }
            Console.WriteLine($"Anzahl der Teilnehmer: {teilnehmer.Length}");
        }

        public static void input()
        {
            Console.Write("Anzahl der Teilnehmer eingeben: ");
            int anzahl = Convert.ToInt32(Console.ReadLine());
            string[] teilnehmer = new string[anzahl];

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.Write("Name des Teilnehmers eingeben: ");
                teilnehmer[i] = Console.ReadLine()!;
            }

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {teilnehmer[i]}");
            }
            Console.WriteLine($"Anzahl der Teilnehmer: {teilnehmer.Length}");
        }
    }
}