using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe28
{

    public class Participants
    {

        public static void StartParticipants()
        {
            Console.WriteLine("----------Aufgabe 28----------");

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
                System.Console.WriteLine(participants[i]);
            }

            System.Console.WriteLine("Anzahl der Teilnehmer: " + participants.Length);
        

        }

    }
}
