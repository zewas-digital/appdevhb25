namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe55
{
    public class ParticipantsList
    {
        public static void Start()
        {
            string path = "/home/laura/Documents/appdevhb25/src/LauraKatharinaBertsch/aufgabe55/input.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                int list = 0;
                line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine($"{++list,2}. {line}");
                    line = reader.ReadLine();
                }
                Console.WriteLine(line);
            }
        }
    }
}