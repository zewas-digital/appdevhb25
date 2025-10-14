using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe30
{

    public class Participants3
    {

        public static void StartParticipants3()
        {
            Console.WriteLine("----------Aufgabe 30----------");

            System.Console.WriteLine("Wie viele Teilnehmer möchtest du erstellen?");

            int numberParticipants = Helper.checkUserInputInteger();
            string[] participants = new string[numberParticipants];

            for (int i = 0; i < numberParticipants; i++)
            {
                System.Console.WriteLine($"Gib den {i+1}. Namen ein:");
                participants[i] = Helper.checkUserInputString();
            }

            System.Console.WriteLine("Erstellte Teilnehmer:");
            foreach (var participant in participants)
            {
                System.Console.WriteLine(participant);
            }
            System.Console.WriteLine("Anzahl der Teilnehmer: " + numberParticipants);
        

        }

    }
}
