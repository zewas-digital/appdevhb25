using System;
using System.IO;

namespace Appdevhb25.SelinUlutuerk.AufgabeV58
{
    class PrintFileFormatted
    {
        public static void Start()
        {
            string outputPath = "C:/Users/aau28234/Documents/appdevneu/appdevhb25/src/SelinUlutuerk/AufgabeV58/output.txt";
            string inputPath = "C:/Users/aau28234/Documents/appdevneu/appdevhb25/src/SelinUlutuerk/AufgabeV58/input.txt";

            string text = File.ReadAllLines(inputPath);
            // string[] words = text.Split(' ');

            string[] words = text.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int counter = 0;

            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                foreach (var word in words)
                {
                    writer.WriteLine($"{word}\t|\t{word}\t|\t{word}");
                    writer.WriteLine("------------------------------");
                    counter++;
                }
            }
        }
    }
}