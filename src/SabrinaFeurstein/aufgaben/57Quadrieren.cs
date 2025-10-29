using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class Quadrieren
    {
        public static void Start()
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\aufgaben\57input.txt"))
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\aufgaben\57output.txt"))
                {
                    string line = sr.ReadLine();

                    while (line != null)
                    {
                        int faktor = Convert.ToInt32(line);
                        int produkt = faktor * faktor;
                        sw.WriteLine($"{faktor} * {faktor} = {produkt}");
                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}