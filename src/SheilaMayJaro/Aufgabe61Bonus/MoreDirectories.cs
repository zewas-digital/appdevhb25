using System;
namespace Appdevhb25.SheilaMayJaro.Aufgabe61Bonus
{
    public class MoreDirectories
    {
        public static void Start()
        {
            /*
            Erstelle ein Programm, dass alle Ordner und Dateien in einem bestimmten Verzeichnis auf deiner Festplatte auf der Konsole ausgibt. 
            Ist in deinem Verzeichnis ein Ordner enthalten, so gib zusätzlich dessen Inhalt ebenfalls auf der Console aus. 
            Gib weiters die Anzahl der Dateien und die Anzahl der Ordner aus.
            */
            string path = @"H:\Aufgabe61.MoreDirectories";
            DirectoryInfo directory = new DirectoryInfo(path);
            int countFiles = 0;
            BrowseDirectories(directory, 0, ref countFiles);



        }
        public static void BrowseDirectories(DirectoryInfo directory, int level, ref int countFiles)
        {
            int countDirectories = 0;
            System.Console.Write(new string('-', level));
            System.Console.WriteLine(directory.Name);
            // DirectoryInfo[] browseDirectory = directory.GetDirectories();

            foreach (DirectoryInfo directory1 in directory.GetDirectories())
            {
                countDirectories++;
                BrowseDirectories(directory1, level + 1, ref countFiles);
                // foreach (FileInfo file in directory1.GetFiles())
                // {
                //     System.Console.Write(new string('-', level + 1));
                //     System.Console.WriteLine(file.Name);
                //     countFiles++;
                // }
            }
            foreach (FileInfo file in directory.GetFiles())
            {
                countFiles++;
                System.Console.Write(new string('-', level + 1));
                System.Console.WriteLine(file.Name);
            }
            if (countDirectories > 0)
            {
                System.Console.WriteLine($"{countDirectories} Ordner");
            }
            if (countFiles > 3)
            {
                System.Console.WriteLine($"{countFiles} Dateien");
            }
        }
    }
}