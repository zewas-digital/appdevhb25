using System.Xml;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe56
{
    public class ParticipantsList2
    {
        public static void Start()
        {
            string input = "/home/laura/Documents/appdevhb25/src/LauraKatharinaBertsch/aufgabe56/input.txt";

            using (StreamReader reader = new StreamReader(input))
            {
                string output = "/home/laura/Documents/appdevhb25/src/LauraKatharinaBertsch/aufgabe56/output.txt";
                using (StreamWriter writer = new StreamWriter(output))
                {
                    string line = reader.ReadLine();
                    writer.WriteLine(line);
                    int list = 0;
                    line = reader.ReadLine();
                    writer.WriteLine();
                    while (line != null)
                    {
                        writer.WriteLine(line);
                        list++;
                        line = reader.ReadLine();
                    }
                    writer.WriteLine();
                    writer.WriteLine($"{list} Teilnehmer");
                }
            }
        }
    }
}