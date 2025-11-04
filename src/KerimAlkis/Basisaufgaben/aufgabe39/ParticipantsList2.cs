using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace Appdevhb25.KerimAlkis.Aufgabe39
{
    public class ParticipantsList2
    {
        public static void Start()
        {
            string path = @"C:\Users\ALKIKER\Documents\appdevhb25\src\KerimAlkis\aufgabe39\input.txt";
            string pathoutput = @"C:\Users\ALKIKER\Documents\appdevhb25\src\KerimAlkis\aufgabe39\output.txt";
            string[] Teilnehmer = File.ReadAllLines(path);
            using(StreamWriter sw = new StreamWriter(pathoutput))
            {
                sw.WriteLine("Teilnehmer\n");
                int counter = 0;
                foreach (var v in Teilnehmer)
                {
                    counter++;
                    sw.WriteLine(v);
                }
                sw.WriteLine();
                sw.WriteLine(counter + " Teilnehmer");
            }
        }
    }
}