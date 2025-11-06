namespace Appdevhb25.KerimAlkis.Aufgabe41
{
    public class ReadAndDisplayCSV
    {
        public static void Start()
        {
            string path = @"C:\Users\ALKIKER\Documents\appdevhb25\src\KerimAlkis\Basisaufgaben\aufgabe41\InputAufgabe62.csv";

            string[] fileToString = File.ReadAllLines(path);

            int spaltenAnzahl = fileToString[0].Split(';').Length;

            string[,] tabelle = new string[fileToString.Length, spaltenAnzahl];
            for (int i = 0; i < fileToString.Length; i++)
            {
                string[] zeile = fileToString[i].Split(";");
                for (int j = 0; j < spaltenAnzahl; j++)
                {
                    tabelle[i, j] = zeile[j];
                }
            }

            int[] spaltenAbstand = new int[spaltenAnzahl];

            for (int i = 0; i < spaltenAbstand.Length; i++)
            {
                int abstand = 0;
                for (int j = 0; j < tabelle.GetLength(0); j++)
                {
                    if (tabelle[j, i].Length > abstand)
                    {
                        abstand = tabelle[j, i].Length;
                    }
                }
                spaltenAbstand[i] = abstand+1;
            }

            string linie = "";
            for(int i = 0; i < spaltenAbstand.Length; i++)
            {
                for (int j = 0; j < spaltenAbstand[i]; j++)
                {
                    linie += "-";
                }
                linie += "-";
            }
            
            for(int i = 0; i < tabelle.GetLength(0); i++)
            {
                for (int j = 0; j < tabelle.GetLength(1); j++)
                {
                    if (j > 0)
                    {
                        Console.Write("| ");
                    }
                    Console.Write(tabelle[i, j].PadRight(spaltenAbstand[j]));
                }
                System.Console.WriteLine();
                Console.Write(linie);
                System.Console.WriteLine();
            }
        }
    }
}