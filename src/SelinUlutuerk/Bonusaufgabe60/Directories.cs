using System;
using System.ComponentModel;
using System.IO;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe60
{
    class Directories
    {
        public static void Start()
        {
            string path = @"C:\\Users\\aau28234\\Documents\\VS";
            int counterDocs = 0;
            int counterFile = 0;

            IEnumerable<string> docs = Directory.EnumerateDirectories(path);

            foreach (var dir in docs)
            {
                System.Console.WriteLine($"- {Path.GetFileName(dir)}");
                counterDocs++;
            }

            IEnumerable<string> files = Directory.EnumerateFiles(path);
            foreach (var file in files)
            {
                System.Console.WriteLine($"-- {Path.GetFileName(file)}");
                counterFile++;
            }

            System.Console.WriteLine($"\n{counterDocs} Ordner");
            System.Console.WriteLine($"{counterFile} Dateien");
        }
    }
}