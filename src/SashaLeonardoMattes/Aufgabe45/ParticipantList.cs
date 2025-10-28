using System;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe45
{

    public class ParticipantList
    {

        public static void StartParticipantList()
        {
            Console.WriteLine("----------Aufgabe 45----------");

            string[] participants = File.ReadAllLines(@"C:\Users\sasha.mattes\Documents\Zewas\appdevhb25\src\SashaLeonardoMattes\Aufgabe45\input.txt");
            // StreamReader re = new StreamReader(@"C:\Users\sasha.mattes\Documents\Zewas\appdevhb25\src\SashaLeonardoMattes\Aufgabe45\input.txt");

            // string line = re.ReadLine();
            // while (line != null)
            // {
            //     System.Console.WriteLine(line);
            //     line = re.ReadLine();
            // }        

            for (int i = 1; i < participants.Length + 1; i++) //+1 damit man i bei 1 für die Nummerierung starten kann
            {
                System.Console.WriteLine($"{i,2}. {participants[i]}");
            }
            
        }
        

    

    }
}
