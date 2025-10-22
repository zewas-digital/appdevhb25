using System.Collections.Specialized;

namespace Appdevhb25.KerimAlkis.Aufgabe38
{
    public class ParticipantsList
    {
        public static void Start()
        {
            string path = @"C:\Users\ALKIKER\Documents\appdevhb25\src\KerimAlkis\aufgabe38\input.txt";

            StreamReader reader = new StreamReader(path);

            int counter = 1;
            while(reader.Peek() >= 0)
            {
                Console.WriteLine(counter + ". " + reader.ReadLine());
                counter++;
            }
        }
    }
}