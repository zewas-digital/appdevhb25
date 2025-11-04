using System;
using System.Diagnostics.Tracing;
namespace Appdevhb25.SheilaMayJaro.Aufgabe46
{
    public class ReplaceString
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 46)");

            /*
            1. Ersetze im obenstehenden Text alle Vorkommnisse von "wird" durch "war und ist" und gib das Ergenis auf der Konsole aus.
            2. Lösche jeden Kleinbuchstaben und gib den Text aus.
            3. Lösche jeden Großbuchstaben und gib den Text aus.
            4. Lösche jedes Leerzeichen und gib den Text aus.
            5. Lösche jedes Ausrufezeichen "!" und gib den Text aus.
            */

            string exampleText = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            System.Console.WriteLine($"Beispieltext: \n {exampleText}");
            //1. Ersetze im Text alle Vorkommnisse von "wird" durch "war und ist" und gib das Ergenis auf der Konsole aus.
            System.Console.WriteLine();
            System.Console.WriteLine("Aufgabe 46.1)");
            string newText = exampleText.Replace("wird", "war und ist");
            System.Console.WriteLine(newText);

            //2. Lösche jeden Kleinbuchstaben und gib den Text aus. 
            System.Console.WriteLine();
            System.Console.WriteLine("Aufgabe 46.2)");
            //2.1. Kleinbuchstaben erkennen 
            //2.2 Kleinbuchstaben löschen
            System.Console.WriteLine("Beispieltext ohne Kleinbuchstaben");
            string textWithoutSmallLetters = "";
            //wie verknüpfe ich es mit der ascii-tabelle?
            System.Console.WriteLine(exampleText);
            ReplaceSmallLettersMethod(exampleText);
            RemoveSmallLettersMethod(exampleText);


            System.Console.WriteLine("\nAufgabe 46.3) \nBeispieltext ohne Großbuchstaben");
            //3. Lösche jeden Großbuchstaben und gib den Text aus.
            RemoveCapitalLettersMethod(exampleText);

            System.Console.WriteLine("\nAufgabe 46.4) \nBeispieltext ohne Leerzeichen");
            //4. Lösche jedes Leerzeichen und gib den Text aus.
            string exampleTextWithoutSpace = exampleText.Replace(" ", null);
            System.Console.WriteLine(exampleTextWithoutSpace);

            System.Console.WriteLine("\nAufgabe 46.5) \nBeispieltext ohne Ausrufezeichen");
            //Lösche jedes Ausrufezeichen "!" und gib den Text aus.
            string exampleTextWithoutExclamationMark = exampleText.Replace("!", "."); 
            System.Console.WriteLine(exampleTextWithoutExclamationMark);




        }
        public static void ReplaceSmallLettersMethod(string exampleText)
        {
            for (int i = 0; i < exampleText.Length; i++)
            {
                char currentLetter = exampleText[i];
                if (currentLetter > 96 && currentLetter < 123)
                {
                    exampleText = exampleText.Replace(exampleText[i], ' ');
                }
            }
            System.Console.WriteLine(exampleText);
        }
        public static void RemoveSmallLettersMethod(string exampleText)
        {
            for (int i = 0; i < exampleText.Length; i++)
            {
                char currentLetter = exampleText[i];
                if (currentLetter > 96 && currentLetter < 123)
                {
                    exampleText = exampleText.Remove(i, 1);
                    i--;
                }
            }
            System.Console.WriteLine(exampleText);
        }
        public static void RemoveCapitalLettersMethod(string exampleText)
        {
            for (int i = 0; i < exampleText.Length; i++)
            {
                char currentLetter = exampleText[i];
                if (currentLetter > 64 && currentLetter < 91)
                {
                    exampleText = exampleText.Remove(i, 1);
                    i--;
                }
            }
            System.Console.WriteLine(exampleText);
        }
    }
}