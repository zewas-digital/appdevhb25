using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace Appdevhb25.KerimAlkis.Vertiefungsaufgabe02
{
    public class PrintFileFormatted
    {
        public static void Start()
        {
            string path = @"C:\Users\ALKIKER\Documents\appdevhb25\src\KerimAlkis\vertiefungsaufgabe02\input.txt";
            string pathoutput = @"C:\Users\ALKIKER\Documents\appdevhb25\src\KerimAlkis\vertiefungsaufgabe02\output.txt";
            string[] Teilnehmer = File.ReadAllLines(path);
            using(StreamWriter sw = new StreamWriter(pathoutput))
            {
                sw.WriteLine("Teilnehmer | Groesse | Alter");
                sw.WriteLine("--------------------------------");
                for (int i = 0; i < Teilnehmer.Length; i++)
                {
                    string[] parts = Teilnehmer[i].Split(' ');

                    string name = parts[0];
                    double groesse = double.Parse(parts[1]);
                    int alter = int.Parse(parts[2]);

                    sw.WriteLine($"{name,-10} | {groesse,7:F2} | {alter,6}");
                    
                }
            
            }
        }
    }
}