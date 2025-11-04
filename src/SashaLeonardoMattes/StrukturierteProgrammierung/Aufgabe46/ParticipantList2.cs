using System;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe46
{

    public class ParticipantList2
    {

        public static void StartParticipantList2()
        {
            Console.WriteLine("----------Aufgabe 46----------");

            System.Console.WriteLine("Teilnehmer wurden in \"output.txt\" geschrieben.");

            string[] participants = File.ReadAllLines(@"C:\Users\sasha.mattes\Documents\Zewas\appdevhb25\src\SashaLeonardoMattes\Aufgabe46\input.txt");

            string[] outputParticipants = new string[participants.Length + 1];

            for (int i = 0; i < participants.Length; i++)
            {
                outputParticipants[i] = $"{i+1,2}. {participants[i]}";
            }
            outputParticipants[outputParticipants.Length - 1] = "Anzahl der Teilnehmer: " + participants.Length.ToString();

            File.WriteAllLines(@"C:\Users\sasha.mattes\Documents\Zewas\appdevhb25\src\SashaLeonardoMattes\Aufgabe46\output.txt", outputParticipants);
        }
        

    

    }
}
