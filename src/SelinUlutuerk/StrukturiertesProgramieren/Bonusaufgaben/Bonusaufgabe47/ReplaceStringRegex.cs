using System;
using System.Text.RegularExpressions;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe47
{
    class ReplaceStringRegex
    {
        public static void Start()
        {
            string satz = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            string[] satzinArray = satz.Split(" ");
            char[] satzasChar = satz.ToCharArray();


            // 1. Ersetzte alle "wird" durch "war und ist"
            Console.WriteLine("1. Wird ersetzt duch war und ist");
            string ohnewird = satz.Replace("wird", "war und ist");
            Console.Write(ohnewird);


            // 2. Lösche jeden Kleinbuchstaben
            Console.WriteLine("\n\n2. gelöschte Kleinbuchstaben");
            Console.Write(Regex.Replace(satz, "[a-z]", ""));

            // 3. Lösche jeden Großbuchstaben
            Console.WriteLine("\n\n3. gelöschte Großbuchstaben");
            Console.Write(Regex.Replace(satz, "[A-Z]", ""));


            // 4. Lösche jedes Leerzeichen
            Console.WriteLine("\n\n4. gelöschte Leerzeichen");
            Console.Write(Regex.Replace(satz, " ", ""));

            // 5. Lösche jedes Ausrufezeichen
            Console.WriteLine("\n\ngelöschte Ausrufezeichen");
            Console.Write(Regex.Replace(satz, "!", ""));

        }
    }
}