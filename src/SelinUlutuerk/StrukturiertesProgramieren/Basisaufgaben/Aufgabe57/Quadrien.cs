using System;
using System.IO;

namespace Appdevhb25.SelinUlutuerk.Aufgabe57
{
    class Quadrien
    {
        public static void Start()
        {
            string outputPath = "C:/Users/aau28234/Documents/appdevneu/appdevhb25/src/SelinUlutuerk/Aufgabe57/output.txt";
            string inputPath = "C:/Users/aau28234/Documents/appdevneu/appdevhb25/src/SelinUlutuerk/Aufgabe57/input.txt";

            string[] lines = File.ReadAllLines(inputPath);
            int counter = 0;

            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                foreach (string line in lines)
                {
                    if (int.TryParse(line, out int number))
                    {
                        int ergebniss = number * number;
                        writer.WriteLine($"{number} * {number} = {ergebniss}");
                        counter++;
                    }
                }
            }
        }
    }
}