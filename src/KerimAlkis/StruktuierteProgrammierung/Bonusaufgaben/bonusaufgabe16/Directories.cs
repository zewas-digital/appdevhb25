namespace Appdevhb25.KerimAlkis.Bonusaufgabe16
{
    public class Directories
    {
        public static void Start()
        {
            string path = @"C:\Users\ALKIKER";

            string[] ordner = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);


            foreach (var o in ordner)
            {
                System.Console.WriteLine(Path.GetFileName(o));
            }
            foreach (var file in files)
            {
                System.Console.WriteLine(Path.GetFileName(file));
            }

            System.Console.WriteLine();
            
            System.Console.WriteLine(ordner.Length + " Ordner");
            System.Console.WriteLine(files.Length + " Dateien");


        }
    }
}