namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class MoreDirectories
    {
        public static void Start()
        {
            string path = @"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein";
            string[] folders = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            int anzahlOrdner = 0;
            int anzahlDateien = 0;

            Console.WriteLine("Ordner");
            for (int i = 0; i < folders.Length; i++)
            {
                Console.WriteLine("- " + Path.GetFileName(folders[i]));

                string[] folderContent = Directory.GetDirectories(folders[i]);
                for (int j = 0; j < folderContent.Length; j++)
                {
                    Console.WriteLine("----- " + Path.GetFileName(folderContent[j]));
                    anzahlOrdner++;
                }

                string[] filesContent = Directory.GetFiles(folders[i]);
                for (int j = 0; j < filesContent.Length; j++)
                {
                    Console.WriteLine("----- " + Path.GetFileName(filesContent[j]));
                    anzahlDateien++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Dateien");
            for (int i = 0; i < files.Length; i++)
                Console.WriteLine("- " + Path.GetFileName(files[i]));

            Console.WriteLine();
            Console.WriteLine(folders.Length + anzahlOrdner + " Ordner");
            Console.WriteLine(files.Length + anzahlDateien + " Dateien");
        }

    }
}