using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class ParticipantsList2
    {
        public static void Start()
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\aufgaben\55input.txt"))
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\aufgaben\56output.txt"))
                {
                    string line = sr.ReadLine();
                    int anzahl = 0;

                    sw.WriteLine(line);
                    sw.WriteLine();
                    line = sr.ReadLine();

                    while (line != null)
                    {
                        sw.WriteLine("- " + line);
                        line = sr.ReadLine();
                        anzahl++;
                    }

                    sw.WriteLine();
                    sw.Write(anzahl + "Teilnehmer");
                    sw.Close();
                    sr.Close();
                }
            }
        }
    }
}