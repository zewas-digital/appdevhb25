using System;

namespace Appdevhb25.SheilaMayJaro.Aufgabe45
{
    public class CountLettersAndSymbols
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 45)");

            string exampleText = "The quick brown fox jumps over the lazy dog. You can't get rid of me! Assign the address of number to a pointer.";
            //Erstelle ein Programm, das ausgibt, wie oft einzelne Buchstaben und Zeichen im Text vorkommen.
            //Um die einzelnen Buchstaben und Zeichen zu zählen soll ein int[] verwendet werden. 
            // Der entsprechende char kann für das Array als Index verwendet werden. Gib am Schluss die Anzahl der einzelnen Zeichen (zb. A,a,ä,.) aus.

            //Beispiel: Wie oft kommt 'a' im Text vor.
            char letter = 'a';
            int characterCount = 0;

            char[] exampleTextInChar = exampleText.ToCharArray();

            for (int i = 0; i < exampleTextInChar.Length; i++)
            {
                System.Console.WriteLine(exampleTextInChar[i] + " ASCII-Code: " + (int)exampleTextInChar[i]);
                //Buchstabe vom Text + Dezimalzahl in der Ascii-Code-Tabelle 
                /* implizite Casts - Bsp. mit Mischa - es gibt auch explizite Casts
                int word2 = 'l';
                double number = word2; 
                */
            }
            System.Console.WriteLine();

            //Zum Zählen wie oft ein bestimmter Charakter vorkommt
            for (int i = 0; i < exampleTextInChar.Length; i++)
            {
                if (exampleTextInChar[i] == letter)
                {
                    characterCount++;
                }
            }
            System.Console.WriteLine($"Der Character {letter} ist im Text {characterCount} mal enthalten.");
            System.Console.WriteLine();

            //Zum Zählen wie oft die einzelnen Charaktere vorkommen 
            int[] asciiTable = new int[128]; // Da es in der Ascii-Tabelle von der Aufgabenstellung 128 Zeichen sind, ist die Länge/Größe 128

            System.Console.WriteLine("Ascii-Tabelle:");
            for (int i = 0; i < exampleText.Length; i++)
            {
                char currentLetter = exampleText[i]; //für den momentanen Buchstaben eine Variable erstellen 

                asciiTable[(int)currentLetter]++; //damit diese Variable bei der Ascii-Tabelle an der Stelle von dem Buchstaben dazugezählt werden kann 
            }

            System.Console.WriteLine("--------------------------");
            for (int i = 32; i < asciiTable.Length -1 /* weil 127 Delete ist, daher nur bis 126 */; i++) //Erst ab Index 32 kommen für uns relevante Zeichen daher 32 < i < 127
            {
                if (asciiTable[i] > 0)
                {
                    System.Console.WriteLine(asciiTable[i] + " " + (char)i);
                }
            }
        }
    }
}