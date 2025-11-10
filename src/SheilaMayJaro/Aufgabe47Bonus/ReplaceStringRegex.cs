using System;
using System.Text.RegularExpressions;
namespace Appdevhb25.SheilaMayJaro.Aufgabe47Bonus
{
    public class ReplaceStringRegex
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 47)");
            string sampleText = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            System.Console.WriteLine(sampleText);

            Console.WriteLine(@"1. Ersetze im obenstehenden Text alle Vorkommnisse von ""wird"" durch ""war und ist"" und gib das Ergenis auf der Konsole aus.");
            sampleText = sampleText.Replace("wird", "war und ist");
            System.Console.WriteLine(sampleText);
            System.Console.WriteLine();
            System.Console.WriteLine("2. Lösche jeden Kleinbuchstaben und gib den Text aus.");
            string sampleTextWithoutLowerLetters = Regex.Replace(sampleText, "[a-z]", string.Empty);
            System.Console.WriteLine(sampleTextWithoutLowerLetters);
            System.Console.WriteLine();
            System.Console.WriteLine("3. Lösche jeden Großbuchstaben und gib den Text aus.");
            string sampleTextWithoutUpperLetters = Regex.Replace(sampleText, "[A-Z]", string.Empty);
            System.Console.WriteLine(sampleTextWithoutUpperLetters);
            System.Console.WriteLine();
            System.Console.WriteLine("4. Lösche jedes Leerzeichen und gib den Text aus.");
            string sampleTextWithoutWhiteSpace = Regex.Replace(sampleText, " ", string.Empty);
            System.Console.WriteLine(sampleTextWithoutWhiteSpace);
            System.Console.WriteLine();
            System.Console.WriteLine(@"5. Lösche jedes Ausrufezeichen ""!"" und gib den Text aus.");
            string sampleTextWithoutExclamationMark = Regex.Replace(sampleText, "!", ".");
            System.Console.WriteLine(sampleTextWithoutExclamationMark);
        }
    }
}