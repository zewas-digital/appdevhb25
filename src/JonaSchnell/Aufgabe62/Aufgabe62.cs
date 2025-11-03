using System.Globalization;

namespace Appdevhb25.JonaSchnell.Aufgabe62
{
    public class Aufgabe62
    {
        public static void ReadAndDisplayCSV()
        {
            string path = "/home/jona/Dokumente/Coding_Campus/appdevhb25/src/JonaSchnell/Aufgabe62/AufgabeReadAndDisplay.csv";
            StreamReader sr = new StreamReader(path);
            int y = 0;
            int digitCounter = 0;
            int roundCounter = 0;
            while (sr.Peek() >= 0)
            {
                string document = sr.ReadLine();
                for (int i = 0; i < document.Length;)
                {
                    roundCounter++;
                    foreach (char lineChecker in document.Replace(";", " | "))
                    {
                        digitCounter++;

                        if (lineChecker >= 48 && lineChecker <= 57)
                        {
                            Console.Write(" ");
                        }
                        if (roundCounter == 1)
                        {
                            if (digitCounter == 10)
                            {
                                Console.Write(" ");
                            }
                        }


                        if (lineChecker == 124)
                        {
                            y++;
                        }
                        if (y == 2)
                        {
                            while (digitCounter < 20)
                            {
                                Console.Write(" ");
                                digitCounter++;
                            }
                        }
                        Console.Write(lineChecker);
                        i++;
                    }
                    digitCounter = 0;
                    y = 0;
                }
                System.Console.WriteLine();
                System.Console.WriteLine(new string('-', 30));
            }









        }
    }
}