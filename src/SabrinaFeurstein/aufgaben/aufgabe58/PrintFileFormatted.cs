using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe58
{

    public class PrintFileFormatted
    {
        public static void Start()
        {
            using (StreamReader sr = new(@"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\aufgaben\aufgabe58\input.txt"))
            {
                using (StreamWriter sw = new(@"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\aufgaben\aufgabe58\output.txt"))
                {
                    string line = sr.ReadLine();
                    string[] firstRow = line.Split(' ');
                    
                    sw.Write($"{firstRow[0], -10} | {firstRow[1], -6} | {firstRow[2], -5}");
                    sw.WriteLine();
                    line = sr.ReadLine();

                    while (line != null)
                    {
                        for (int i = 0; i < 27; i++)
                        {
                            sw.Write('-');
                        }
                        sw.WriteLine();

                        string[] data = line.Split(' ');
                        string name = data[0];
                        double size = double.Parse(data[1]);
                        string sizeStr = $"{size.ToString("F2"), 10 -10}";
                        int alter = int.Parse(data[2]);

                        sw.Write($"{name, -10} | {sizeStr, 6} | {alter, 5}");

                        sw.WriteLine();
                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}