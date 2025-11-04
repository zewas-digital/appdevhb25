namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class Directories
    {
        public static void Start()
        {
            string path = @"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein";
            string[] folders = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            Console.WriteLine("Ordner");
            for (int i = 0; i < folders.Length; i++)
                Console.WriteLine("- " + Path.GetFileName(folders[i]));

            Console.WriteLine();
            Console.WriteLine("Dateien");
            for (int i = 0; i < files.Length; i++)
                Console.WriteLine("- " + Path.GetFileName(files[i]));

            Console.WriteLine();
            Console.WriteLine(folders.Length + " Ordner");
            Console.WriteLine(files.Length + " Dateien");
        }
    }
}