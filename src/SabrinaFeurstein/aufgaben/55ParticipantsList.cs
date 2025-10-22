using System.IO;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class ParticipantsList
    {
        public static void Start()
        {
            StreamReader sr = new StreamReader(@"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\aufgaben\input.txt");
            string line = sr.ReadLine();
            line = sr.ReadLine();
            int i = 0;

            while (line != null)
            {
                i++;
                Console.WriteLine($"{i}. {line}");
                line = sr.ReadLine();
            }

            sr.Close();
        }
    }
}