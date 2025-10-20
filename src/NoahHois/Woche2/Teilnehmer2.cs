using System;

namespace Appdevhb25.NoahHois.Aufgabe22
{
    public class Teilnehmer2
    {
        public static void TeilnehmerKurs2()
        {
            string[] participants = { "Julian", "Jona", "Kerim", "Lia", "Katja", "Laura", "Noah", "Sasha", "Sabrina", "Sheila", "Selin" };

            for (int i = 0; i < participants.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + participants[i]);
            }
            Console.WriteLine("Anzahl der Teilnehmer: " + participants.Length);
        }
    }
}