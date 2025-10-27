using System;
using System.ComponentModel;
using System.IO;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe61
{
    class MoreDirectories
    {
        public static void Start()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            System.Console.WriteLine(currentDirectory);

            string path = @"C:\Users\aau28234\Documents\VS";
            int counterDocs = 0;
            int counterFile = 0;

            IEnumerable<string> directories = Directory.EnumerateDirectories(path, "*", SearchOption.AllDirectories);

            foreach (var doc in directories)
            {
                System.Console.WriteLine($"- {doc.Substring(doc.LastIndexOf(Path.DirectorySeparatorChar) + 1)}");
                counterDocs++;
            }

            IEnumerable<string> files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                System.Console.WriteLine($"- {file.Substring(file.LastIndexOf(Path.DirectorySeparatorChar) + 1)}");
                counterFile++;
            }

            System.Console.WriteLine($"\n{counterDocs} Ordner");
            System.Console.WriteLine($"{counterFile} Dateien");
        }
    }
}