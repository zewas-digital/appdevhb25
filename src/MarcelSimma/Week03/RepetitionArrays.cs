namespace Appdevhb25.MarcelSimma
{
    public class RepetitionArrays
    {
        public static void Start()
        {


            /*
            Wiederholung Arrays
            ===================
            
            Eine sehr gute Zusammenfassung bietet die offizielle C# Dokumentation von Microsoft: https://learn.microsoft.com/de-de/dotnet/csharp/language-reference/builtin-types/arrays
            
              - Speichert mehrere Werte vom gleichen Datentyp
              - Die Werte werden über einen Index adressiert 
              - Die Größe des Arrays wird bei der Initialisierung festgelegt.
              - zweideminsionales Array kann man sich wie ein Schachbrett vorstellen
              - Array.Length gibt uns die Länge des Arrays 
              - Array.GetLength(0) für mehrdimensionale Arrays
              - Arrays verwenden "copy by reference"; klassische Datentypen verwenden "copy by value"
              - Ausgabe der Werte mit for oder foreach Schleife





            Wiederholung eindimensionale Arrays
            =================================== 
            */

            // Deklaration
            int[] numbers0; // Array-Variable

            // Initialisierung
            numbers0 = new int[5]; // Array-Objekt mit 5 Elementen

            // Deklaration + Initialisierung
            int[] numbers1 = new int[3];
            // Standardwert 0

            string[] strings1 = new string[5];
            // Standardwert null

            foreach (string elem in strings1)
            {
                System.Console.WriteLine(elem + ".");
            }

            // Werte zuweisen
            numbers1[0] = 1;
            numbers1[1] = 2;
            numbers1[2] = 3;
            // numbers1[3] = 60; // Fehler: Index außerhalb des Bereichs
            // 5 ist die Länge des Arrays, der Indexbereich reicht von 0 bis 4

            // Array mit Werten initalisieren mit der Collection-Expression; möglich ab C# 12 und .NET 8 und neuer
            int[] numbers2 = [11, 22, 33];

            // Array mit Werten initialisieren; alternative Symtax vor C# 12
            int[] numbers3 = new int[] { 111, 222, 333, 444, 555 };

            // Array ausgeben, Variante 1
            for (int i = 0; i < numbers2.Length; i++)
            {
                // auf die einzelnen Werte wird über die Indexvariable i zugegriffen
                Console.WriteLine(numbers2[i]);
            }

            // Array ausgeben, Variante 2
            foreach (int number in numbers3)
            {
                Console.WriteLine(number);
            }

            /*
            Wiederholung zweidimensionale Arrays
            ====================================
            */

            // Deklaration
            int[,] numbers4;

            // Initialisierung
            numbers4 = new int[3, 3];

            // Deklaration + Initialisierung
            int[,] numbers5 = new int[3, 3];

            // Werte zuweisen
            numbers5[0, 0] = 0;
            numbers5[0, 1] = 1;
            numbers5[0, 2] = 2;

            numbers5[1, 0] = 10;
            numbers5[1, 1] = 11;
            numbers5[1, 2] = 12;

            numbers5[2, 0] = 20;
            numbers5[2, 1] = 21;
            numbers5[2, 2] = 22;

            // Array initialiseren und Werte zuweisen
            int[,] numbers6 = new int[,] { { -0, -1, -2 }, { -10, -11, -12 }, { -20, -21, -22 } };

            // Array ausgeben, Variante 1
            for (int i = 0; i < numbers6.GetLength(0); i++) // iteriert über die Zeilen
            {
                for (int j = 0; j < numbers6.GetLength(1); j++) // iteriert für die Spalten in der aktuellen Zeile
                {
                    Console.Write($"{numbers6[i, j]}    ");
                }
                Console.WriteLine();
            }

            // Array ausgeben, Variante 2
            foreach (int number in numbers6)
            {
                System.Console.WriteLine(number);
            }

            /*
            Wiederholung Jagged Arrays
            ==========================
            */

            // Deklaration
            int[][] numbers7;

            // Initialisierung
            numbers7 = new int[3][];

            // Deklaration + Initialisierung
            int[][] numbers8 = new int[3][];
            numbers8[0] = new int[4]; // erste Zeile mit 4 Spalten
            numbers8[1] = new int[2]; // zweite Zeile mit 2
            numbers8[2] = new int[3]; // dritte Zeile mit 3

            // Werte zuweisen
            int[][] numbers9 = { new int[] { 1, 2, 3, 4 }, // erste Zeile mit 4 Spalten
                                 new int[] { 11, 22 },   // zweite Zeile mit 2
                                 new int[] { 111, 222, 333 } }; // dritte Zeile mit 3

            // Array ausgeben, Variante 1
            for (int i = 0; i < numbers9.Length; i++)
            {
                for (int j = 0; j < numbers9[i].Length; j++)
                {
                    Console.Write($"{numbers9[i][j]}    ");
                }
                Console.WriteLine();
            }

            // Array ausgeben, Variante 2
            foreach (int[] row in numbers9)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number}    ");
                }
                Console.WriteLine();
            }
        }
    }
}