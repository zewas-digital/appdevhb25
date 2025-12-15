namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe57
{
    public class Quadrieren
    {
        public static void Start()
        {
            string input = "/home/laura/Documents/appdevhb25/src/LauraKatharinaBertsch/aufgabe57/input.txt";
            using (StreamReader reader = new StreamReader(input))
            {
                string output = "/home/laura/Documents/appdevhb25/src/LauraKatharinaBertsch/aufgabe57/output.txt";
                using (StreamWriter writer = new StreamWriter(output))
                {
                    while (reader.Peek() >= 0)
                    {
                        int line = Convert.ToInt32(reader.ReadLine() ?? string.Empty);

                        writer.WriteLine($"{line} * {line} = {line * line}");
                    }
                }
            }
        }
    }
}