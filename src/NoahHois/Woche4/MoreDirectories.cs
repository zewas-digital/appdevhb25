using System.ComponentModel;

namespace Appdevhb25.NoahHois.BonusAufgabe11
{
    public class MoreDirectories
    {
        public static void Start(string[] args)
        {
            Console.WriteLine("Geben Sie einen Pfad ein den Sie benutzten möchten: ");
            string path = Console.ReadLine();
            ListDirectory(path, 1);
        }
        public static void ListDirectory(string path, int spaces)
        {
            string[] directories = Directory.GetDirectories(path);
            for (int i = 0; i < directories.Length; i++)
            {
                DateTime dt = Directory.GetLastWriteTime(directories[i]);
                string directoryWithoutPath = directories[i].Substring(path.Length + 1);
                Console.WriteLine(new string('+', spaces) + " " + directoryWithoutPath + " " + dt);
                ListDirectory(directories[i], spaces + 2);
            }

            string[] files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                string fileWithoutPath = files[i].Substring(path.Length + 1);
                Console.WriteLine(new string('-', spaces) + " " + fileWithoutPath);
            }
        }
    }
}