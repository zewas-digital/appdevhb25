using System;

namespace Appdevhb25.NoahHois.Aufgabe21
{
    public class Teilnehmer
    {
        public static void TeilnehmerKurs()
        {
            string[] participants = { "Julian", "Jona", "Kerim" };          //<=     new string[];

            // teilnehmer[0] = "Julian";
            // teilnehmer[1] = "Jona";
            // teilnehmer[2] = "Kerim";
            // teilnehmer[3] = "Lia";
            // teilnehmer[4] = "Katja";
            // teilnehmer[5] = "Laura";
            // teilnehmer[6] = "Noah";
            // teilnehmer[7] = "Sasha";
            // teilnehmer[8] = "Sabrina";
            // teilnehmer[9] = "Sheila";
            // teilnehmer[10] = "Selin";


            for (int i = 0; i < participants.Length; i++)
            {
                Console.WriteLine(participants[i]);
            }
            Console.WriteLine("Anzahl der Teilnehmer: " + participants.Length);
        }
    }
}