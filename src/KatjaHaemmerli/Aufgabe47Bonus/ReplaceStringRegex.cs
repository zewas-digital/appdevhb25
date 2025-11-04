using System;
using System.Text.RegularExpressions;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe47Bonus
{
    public  class ReplaceStringRegex
    {
        public static void ReplaceMitRegex()
        {
            string text = @"Heute wird ein guter Tag! Heute wird ein noch besserer Tag! Heute wird ein spitzen guter Tag!";

            // 1. --------
            // 2. Lösche jeden Kleinbuchstaben und gib den Text aus.            
            string pattern = "[a-z]";
            Regex regexName = new Regex(pattern);
            string replacement = "";
            string newText = regexName.Replace(text, replacement);

            System.Console.WriteLine($"Text ohne Kleinbuchstaben: {newText}");

            // 3. Lösche jeden Großbuchstaben und gib den Text aus.
            string pattern2 = "[A-Z]";
            Regex regexName2 = new Regex(pattern2);
            string replacement2 = "";
            string newText2 = regexName2.Replace(text, replacement2);

            System.Console.WriteLine($"Text ohne Großbuchstaben: {newText2}");

            // 4. Lösche jedes Leerzeichen und gib den Text aus.
            string pattern3 = " ";
            Regex regexName3 = new Regex(pattern3);
            string replacement3 = "";
            string newText3 = regexName3.Replace(text, replacement3);

            System.Console.WriteLine($"Text ohne Leerzeichen: {newText3}");

            // 5. Lösche jedes Ausrufezeichen "!" und gib den Text aus.
             string pattern4 = "[!]";
            Regex regexName4 = new Regex(pattern4);
            string replacement4 = "";
            string newText4 = regexName4.Replace(text, replacement4);

            System.Console.WriteLine($"Text ohne Ausrufezeichen: {newText4}"); 
        }
    }
}