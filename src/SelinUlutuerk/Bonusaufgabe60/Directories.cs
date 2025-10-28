using System;
using System.ComponentModel;
using System.IO;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe60
{
    class Directories
    {
        public static void Start()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            System.Console.WriteLine(currentDirectory);

            string path = @"C:\\Users\\aau28234\\Documents\\VS";
            int counterDocs = 0;
            int counterFile = 0;

            List<string> docs = new List<string>(Directory.EnumerateFileSystemEntries(path));

            foreach (var doc in docs)
            {
                System.Console.WriteLine($"- {doc.Substring(doc.LastIndexOf(Path.DirectorySeparatorChar) + 1)}");

                if (doc.Contains("."))
                    counterFile++;
                else
                    counterDocs++;
            }
            System.Console.WriteLine($"\n{counterDocs} Ordner");
            System.Console.WriteLine($"{counterFile} Dateien");
        }
    }
}