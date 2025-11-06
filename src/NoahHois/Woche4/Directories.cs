using System.Diagnostics;

namespace Appdevhb25.NoahHois.BonusAufgabe10
{
    public class Directories
    {
        public static void Start(string[] args)
        {
            Console.WriteLine("Geben Sie einen Pfad ein den Sie benutzten möchten: ");
            string path = Console.ReadLine();
            while (Directory.Exists(path) != true)
            {
                Console.WriteLine("Falsche Eingabe");
                Console.WriteLine("Geben Sie erneut einen gültigen Pfad ein den Sie benutzten möchten: ");
                path = Console.ReadLine();
            }

            string[] directories = Directory.GetDirectories(path);
            for (int i = 0; i < directories.Length; i++)
            {
                DateTime dt = Directory.GetLastWriteTime(directories[i]);
                string directoryWithoutPath = directories[i].Substring(path.Length + 1);
                Console.WriteLine("+ " + directoryWithoutPath + " " + dt);
            }

            string[] files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                string fileWithoutPath = files[i].Substring(path.Length + 1);
                Console.WriteLine("- " + fileWithoutPath);
            }
            Console.WriteLine();
            Console.WriteLine(directories.Length + " Ordner");
            Console.WriteLine(files.Length + " Dateien");
        }
    }
}