using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace Appdevhb25.KerimAlkis.Aufgabe40
{
    public class Quadrieren
    {
        public static void Start()
        {
            string path = @"C:\Users\ALKIKER\Documents\appdevhb25\src\KerimAlkis\aufgabe40\input.txt";
            string pathoutput = @"C:\Users\ALKIKER\Documents\appdevhb25\src\KerimAlkis\aufgabe40\output.txt";
            string[] Teilnehmer = File.ReadAllLines(path);
            using(StreamWriter sw = new StreamWriter(pathoutput))
            {
                int counter = 0;
                foreach (var v in Teilnehmer)
                {
                    counter++;
                    sw.WriteLine(v + " * " + v+ ": " + Convert.ToInt16(v)*Convert.ToInt16(v));
                }
            }
        }
    }
}