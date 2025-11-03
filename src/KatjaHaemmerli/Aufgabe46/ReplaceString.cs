using System;
using System.Linq.Expressions;
using System.Security.Cryptography;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe46
{
    public  class ReplaceString
    {
        static string text = "Heute wird ein guter Tag! Heute wird ein noch besserer Tag! Heute wird ein spitzen guter Tag!";      

        public static void ReplString()
        {
            ChangeWords();
            RemoveVariante();
            ReplaceVariante();
            ReplaceGrossbuchstaben();
            KeineLeerzeichen();
            KeineAusrufezeichen();

            static void ChangeWords()
            {
                //1.Ersetze im obenstehenden Text alle Vorkommnisse von "wird" durch "war und ist" und gib das Ergenis auf der Konsole aus.
                string newText = text.Replace("wird", "war"); // "wird" wird ersetzt durch "war".
                string newText2 = text.Replace("wird", "ist"); // "wird" wird ersetzt durch "ist".
                Console.WriteLine(newText);
                Console.WriteLine(newText2);                
            }
            
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
                for (int i = 0; i < text.Length; i++) //foreach Schleife chars (buchstaben) durchgehen. Wenn es sich um einen Kleinbuchstaben handelt -> mit einem Leerzeichen ersetzen
                {
                    if (char.IsLower(text[i]))
                    {
                        text = text.Replace(text[i], ' ');
                    }
                }
                System.Console.WriteLine(text);
            }
            
            //3.Lösche jeden Großbuchstaben und gib den Text aus.
            static void ReplaceGrossbuchstaben()
            {
                for (int i = 0; i < text.Length; i++) //foreach Schleife chars (buchstaben) durchgehen. Wenn es sich um einen Grossbuchstaben handelt -> mit einem Leerzeichen ersetzen
                {
                    if (char.IsUpper(text[i]))
                    {
                        text = text.Replace(text[i], ' ');
                    }
                }
                System.Console.WriteLine(text);
            }

            //4.Lösche jedes Leerzeichen und gib den Text aus.
            static void KeineLeerzeichen()
            {
                //5. Lösche jedes Ausrufezeichen "!" und gib den Text aus.            
                string KeineLeerzeichen = text.Replace(" ", ""); // Leerzeichen werden durch "kein Zeichen" ersetzt.
                Console.WriteLine(KeineLeerzeichen);
            }
            
            static void KeineAusrufezeichen()
            {
                //5. Lösche jedes Ausrufezeichen "!" und gib den Text aus.            
                string keineAusrufezeichen = text.Replace("!", " "); // Ausrufezeichen werden durch ein Leerzeichen ersetzt
                Console.WriteLine(keineAusrufezeichen); 
            }
            
        }
    }
}