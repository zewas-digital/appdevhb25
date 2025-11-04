using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe29
{

    public class Participants2
    {

        public static void StartParticipants2()
        {
            Console.WriteLine("----------Aufgabe 29----------");

            string[] participants = new string[10];

            participants[0] = "Jona";
            participants[1] = "Noah";
            participants[2] = "Julian";
            participants[3] = "Lia";
            participants[4] = "Kerim";
            participants[5] = "Selin";
            participants[6] = "Sabrina";
            participants[7] = "Laura";
            participants[8] = "Katja";
            participants[9] = "Sheila";

            for (int i = 0; i < participants.Length; i++)
            {
                System.Console.WriteLine(i+1 + ". " + participants[i]);
            }

            System.Console.WriteLine("Anzahl der Teilnehmer: " + participants.Length);
        

        }

    }
}
