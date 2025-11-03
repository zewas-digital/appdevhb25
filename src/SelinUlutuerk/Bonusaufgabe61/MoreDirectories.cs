using System;
using System.ComponentModel;
using System.IO;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe61
{
    class MoreDirectories
    {
        public static void Start()
        {
            string path = @"C:\Users\aau28234\Documents\VS\tests";
            int counterDocs = 0;
            int counterFile = 0;

            // Alle Unterordner
            IEnumerable<string> directories = Directory.EnumerateDirectories(path, "*", SearchOption.AllDirectories);

            foreach (var dir in directories)
            {
                System.Console.WriteLine($"- {Path.GetFileName(dir)}");
                counterDocs++;

                IEnumerable<string> files = Directory.EnumerateFiles(dir);
                foreach (var file in files)
                {
                    System.Console.WriteLine($"---- {Path.GetFileName(file)}");
                    counterFile++;
                }
            }

            // Dateien im Hauptverzeichnis
            IEnumerable<string> rootFiles = Directory.EnumerateFiles(path);
            foreach (var file in rootFiles)
            {
                System.Console.WriteLine($"- {Path.GetFileName(file)}");
                counterFile++;
            }

            System.Console.WriteLine($"\n{counterDocs} Ordner");
            System.Console.WriteLine($"{counterFile} Dateien");
        }
    }
}