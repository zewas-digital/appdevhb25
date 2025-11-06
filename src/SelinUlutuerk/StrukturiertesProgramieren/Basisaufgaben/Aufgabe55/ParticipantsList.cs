using System;
using System.IO;
using System.Text;

namespace Appdevhb25.SelinUlutuerk.Aufgabe55
{
    class ParticipantsList
    {
        public static void Start()
        {
            using (StreamReader reader = new StreamReader("C:/Users/aau28234/Documents/appdevneu/appdevhb25/src/SelinUlutuerk/Aufgabe55/Teilnehmer.txt"))
            {
                string line = reader.ReadLine() ?? "";
                line = reader.ReadLine() ?? "";
                int counter = 1;

                while (line != null)
                {
                    Console.WriteLine($"{counter}. {line}");
                    counter++;
                    line = reader.ReadLine() ?? "";
                }
                reader.Close();
            }
        }
    }
}