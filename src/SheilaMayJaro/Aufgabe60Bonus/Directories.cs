using System;
namespace Appdevhb25.SheilaMayJaro.Aufgabe60Bonus
{
    public class Directories
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 60)");

            /*
            Erstelle ein Programm, dass alle Ordner und Dateien in einem bestimmten Verzeichnis auf deiner Festplatte auf der Konsole ausgibt. 
            Gib weiters die Anzahl der Dateien und die Anzahl der Ordner aus.
            */
            string path = @"H:\Aufgabe60.Directories"; //Access denied? Weil StreamReader einen Ordner nicht auslesen kann 

            DirectoryInfo list = new DirectoryInfo(path);
            int countDirectories = 0;
            foreach (DirectoryInfo item in list.GetDirectories())
            {
                System.Console.WriteLine(item);
                //Gibt die Ordner aus 
                countDirectories++;
            }
            int countFiles = 0;
            foreach (FileInfo item in list.GetFiles())
            {
                System.Console.WriteLine(item);
                //Gibt die Dateien aus 
                countFiles++;
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"{countDirectories} Ordner \n{countFiles} Dateien");
        }
    }
}