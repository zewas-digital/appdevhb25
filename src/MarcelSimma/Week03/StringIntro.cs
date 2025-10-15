using System.Runtime.InteropServices;

namespace Appdevhb25.MarcelSimma
{
    public class StringIntro
    {
        public static void Start()
        {
            /*
            Einführung in Strings
            =====================
            
            Link zur String Dokumentation: https://learn.microsoft.com/de-de/dotnet/csharp/programming-guide/strings/
            */

            // Deklaration
            string message1;

            // Alias für Obenstehendes
            System.String message2;

            message1 = "Hallo";

            message2 = " Welt!";

            // Verknüpfung
            string message3 = message1 + message2;

            System.Console.WriteLine(message3);

            System.Console.WriteLine("--------------------");
            // alles in Großbuchstaben
            System.Console.WriteLine(message3.ToUpper());

            // alles in Kleinbuchstaben
            System.Console.WriteLine(message1.ToLower());

            System.Console.WriteLine("--------------------");
            // Verknüpfung von Strings mit Concat-Methode
            string message4 = System.String.Concat("Hallo", message2);

            System.Console.WriteLine(message4);

            System.Console.WriteLine("--------------------");
            // Ein String wird im Hintergrund als Char-Array verwaltet. Folglich kann ich die Länge wie bei einem Array abfragen.
            System.Console.WriteLine(message4.Length);

            // Ich kann auch mit Schleifen über die einzelnen Zeichen iterieren.
            foreach (char elem in message4)
            {
                Console.WriteLine(elem);
            }

            for (int i = 0; i < message4.Length; i++)
            {
                System.Console.WriteLine("Character " + i + ": " + message4[i]);
            }
            System.Console.WriteLine("--------------------");
            // Ich kann einen String in ein Char-Array konvertieren
            char[] stringAsChar = message4.ToCharArray();

            for (int i = 0; i < stringAsChar.Length; i++)
            {
                System.Console.WriteLine("Character from Array" + i + ": " + stringAsChar[i]);
            }
            System.Console.WriteLine("--------------------");
            // Verbatim Literal @ (Wiederholung)
            string ohneVerbatimLiteral = "c:\\Program Files\\Microsoft Visual Studio 9.0";
            string verbatimLiteral = @"
            .
            c:\Program Files\Microsoft Visual Studio 9.0
            .
            ";
            System.Console.WriteLine(verbatimLiteral);
            System.Console.WriteLine("--------------------");
            // String Interpolation $ (Wiederholung)

            string interpolatedString = $"Interpolation: {message4}";
            System.Console.WriteLine(interpolatedString);

            // Leerer String
            string empty = "";

            // richtige Variante wäre
            empty = String.Empty;
            System.Console.WriteLine("--------------------");
            // Substring
            // message4 = "Hallo Welt!"
            //(startIndex, Length)
            string substring = message4.Substring(0, 5);
            System.Console.WriteLine(substring);

            int indexOf = message4.IndexOf("lo");
            System.Console.WriteLine(indexOf);
            System.Console.WriteLine("--------------------");

            // Zerlegung eines Strings in ein Array aus Substrings basierend auf einem einzelnen Zeichen.
            string satz = "Hallo Welt dies ist ein Satz.";
            string[] satzInArray = satz.Split(" ");

            foreach (string wort in satzInArray)
            {
                System.Console.WriteLine(wort);
            }

            System.Console.WriteLine("--------------------");

            // Wiederholung Copy by Value
            int[] intArray = [1, 2, 3];
            int[] copiedArray = intArray;
            intArray[1] = 100;

            foreach (int elem in copiedArray)
            {
                System.Console.WriteLine(elem);
            }
            /*
            Ausgabe:
            1
            100
            3
            */

            System.Console.WriteLine("--------------------");

            // Auch Strings verwenden Copy by Value
            string temp = "Hallo";
            // temp2 und temp zeigen auf dasselbe Objekt im Speicher
            string temp2 = temp;
            // Strings sind unveränderbar. Untenstehende Anweisung führt also dazu, dass ein neues String-Objekt im Speicher erzeugt wird und temp nun auf das neue Objekt zeigt. 
            temp = "Hallo Welt";

            System.Console.WriteLine(temp2);


            // Eine Liste aller String Methoden findest du hier: 
            // https://learn.microsoft.com/de-de/dotnet/api/system.string?view=net-8.0
        }

    }
}