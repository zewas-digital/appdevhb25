namespace Appdevhb25.JonaSchnell.Aufgabe62
{
    public class Aufgabe62
    {
        public static void ReadAndDisplayCSV()
        {
            string path = "/home/jona/Dokumente/Coding_Campus/appdevhb25/src/JonaSchnell/Aufgabe62/AufgabeReadAndDisplay.csv";
            StreamReader sr = new StreamReader(path);
            while (sr.Peek() >= 0)
            {
                string document = sr.ReadLine();
                for (int i = 0; i < document.Length;)
                {
                    foreach (char lineChecker in document.Replace(";", "   | "))
                    {
                        Console.Write(lineChecker);
                        i++;
                    }
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }









        }
    }
}