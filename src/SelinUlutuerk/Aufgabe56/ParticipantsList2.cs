using System;
using System.IO;
using System.Diagnostics.Metrics;

namespace Appdevhb25.SelinUlutuerk.Aufgabe56
{
    class ParticipantsList2
    {
        public static void Start()
        {
            string inputPath = "C:/Users/aau28234/Documents/appdevneu/appdevhb25/src/SelinUlutuerk/Aufgabe56/input.txt";

            string[] lines = File.ReadAllLines(inputPath);
            int counter = 0;

            using (StreamWriter writer = new StreamWriter("C:/Users/aau28234/Documents/appdevneu/appdevhb25/src/SelinUlutuerk/Aufgabe56/output.txt"))
            {
                foreach (string oline in lines)
                {
                    string line = oline.Trim();
                    if (line == "") continue;

                    if (counter == 0)
                    {
                        writer.WriteLine(line);
                    }
                    else
                    {
                        writer.WriteLine($"{line}");
                        
                    }
                    counter++;
                }
                writer.WriteLine($"\n{counter - 1} Teilnehmer");

            }
        }
    }
}