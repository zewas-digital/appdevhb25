namespace Appdevhb25.JonaSchnell.Aufgabe55
{
    public class Aufgabe55
    {
        public static void PatricipantsList()
        {
            string path = "/home/jona/Dokumente/Coding_Campus/appdevhb25/src/JonaSchnell/Aufgabe55/output.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    Console.WriteLine(sr.ReadLine());
                }
                System.Console.WriteLine(sr);
            }

        }
    }
}