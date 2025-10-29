using System;
using System.Globalization;
using System.IO;

namespace Appdevhb25.SelinUlutuerk.AufgabeV58
{
    class PrintFileFormatted
    {
        public static void Start()
        {
            string outputPath = "C:/Users/aau28234/Documents/appdevneu/appdevhb25/src/SelinUlutuerk/AufgabeV58/output.txt";
            string inputPath = "C:/Users/aau28234/Documents/appdevneu/appdevhb25/src/SelinUlutuerk/AufgabeV58/input.txt";

            string[] lines = File.ReadAllLines(inputPath);

            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                writer.WriteLine("Teilnehmer  |    Größe   | Alter");
                writer.WriteLine("---------------------------------");

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(' ');

                    string name = parts[0];
                    double groesse = double.Parse(parts[1], CultureInfo.InvariantCulture);
                    int alter = int.Parse(parts[2]);

                    writer.WriteLine($"{name,-12}|  {groesse,8}  |  {alter,4}");
                    writer.WriteLine("---------------------------------");
                }
            }
        }
    }
}