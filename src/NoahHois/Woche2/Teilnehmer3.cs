using System;

namespace Appdevhb25.NoahHois.Aufgabe23
{
    public class Teilnehmer3
    {
        public static void TeilnehmerKurs3()
        {
            string temp = Console.ReadLine();

            if (int.TryParse(temp, out int numberOfParticipants))
            {
                string[] participants = new string[numberOfParticipants];

                for (int i = 0; i < participants.Length; i++)
                {
                    participants[i] = Console.ReadLine();
                }

                Console.WriteLine("Teilnehmerliste: ");

                for (int j = 0; j < participants.Length; j++)
                {
                    Console.WriteLine(participants[j]);
                }

                Console.WriteLine("Anzahl der Teilnehmer: " + participants.Length);
            }
            else
            {
                Console.WriteLine("Falsche Eingabe!");
            }
        }
    }
}