using System;
using System.Linq.Expressions;
using System.Security.Cryptography;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe46
{
    public  class ReplaceString
    {
        static string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
        /* 1. Ersetze im obenstehenden Text alle Vorkommnisse von "wird" durch "war und ist" und gib das Ergenis auf der Konsole aus.
        2.Lösche jeden Kleinbuchstaben und gib den Text aus.
        3.Lösche jeden Großbuchstaben und gib den Text aus.
        4.Lösche jedes Leerzeichen und gib den Text aus.
        5.Lösche jedes Ausrufezeichen "!" und gib den Text aus.*/

        public static void ReplString()
        {
            //1.
            string newText = text.Replace("wird", "war"); // "wird" wird ersetzt durch "war".
            string newText2 = text.Replace("wird", "ist"); // "wird" wird ersetzt durch "ist".
            // Console.WriteLine(newText);
            // Console.WriteLine(newText2);
            RemoveVariante();
            ReplaceVariante();

            //2. 
            // foreach Schleife chars (buchstaben) durchgehen. Wenn es sich um einen Kleinbuchstaben handelt -> löschen
            //Variante 1 als Methode
            static void RemoveVariante()
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsLower(text[i]))
                    {
                        text = text.Remove(i, 1);
                        i--;
                    }
                }
                System.Console.WriteLine(text);
            }

            // Variante 2 als Methode
            static void ReplaceVariante()
            {
                for(int i = 0; i < text.Length; i++)
                {
                    if (char.IsLower(text[i]))
                    {
                        text = text.Replace(text[i], ' ');
                    }
                }
                System.Console.WriteLine(text);
            }
        }
    }
}