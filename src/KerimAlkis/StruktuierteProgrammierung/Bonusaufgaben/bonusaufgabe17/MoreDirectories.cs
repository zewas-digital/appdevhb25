using System.Security.Cryptography;

namespace Appdevhb25.KerimAlkis.Bonusaufgabe17
{
    public class MoreDirectories
    {
        public static void Start()
        {
            string path = @"C:\Users\ALKIKER\Documents\appdevhb25\src";

            string[] ordner = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            int ordnerAnzahl = ordner.Length;
            int filesAnzahl = files.Length;

            foreach (var o in ordner)
            {
                System.Console.WriteLine("-" + Path.GetFileName(o));
                string[] unterOrdner = Directory.GetDirectories(o);
                string[] unterFiles = Directory.GetFiles(o);
                if (unterOrdner.Length != 0 || unterFiles.Length != 0)
                {
                    foreach (var unterO in unterOrdner) { System.Console.WriteLine("    --" + Path.GetFileName(unterO)); }
                    foreach (var unterFile in unterFiles) { System.Console.WriteLine("  --" + Path.GetFileName(unterFile)); }
                }
                ordnerAnzahl += ordner.Length;
                filesAnzahl += files.Length;
                System.Console.WriteLine();
            }


            System.Console.WriteLine();
            Console.WriteLine("FILES");
            foreach (var file in files)
            {
                System.Console.WriteLine("-" + Path.GetFileName(file));
            }

            System.Console.WriteLine();
            
            System.Console.WriteLine(ordnerAnzahl + " Ordner");
            System.Console.WriteLine(filesAnzahl + " Dateien");


        }
    }
}