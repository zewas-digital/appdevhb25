using System;
using System.Text.RegularExpressions;

namespace Appdevhb25.SelinUlutuerk.Aufgabe46
{
    class ReplaceString
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
            // string klein = "";
            // foreach (char c in satz)
            // {
            //     if (!(c >= 'a' && c <= 'z'))
            //     {
            //         klein += c;
            //     }
            // }
            // Console.Write(klein);

            Console.Write(Regex.Replace(satz, "[a-z]", ""));

            

            // for (char c = 'a'; c <= 'z'; c++)
            // {
            //     foreach (char b in satz)
            //     {
            //         if (b != c)
            //         {
            //             klein += b;
            //         }
            //     }
            // }
            

            // 3. Lösche jeden Großbuchstaben
            Console.WriteLine("\n\n3. gelöschte Großbuchstaben");
            string gross = "";
            foreach (char c in satz)
            {
                if (!(c >= 'A' && c <= 'Z'))
                {
                    gross += c;
                }
            }
            Console.Write(gross);

            // 4. Lösche jedes Leerzeichen
            Console.WriteLine("\n\n4. gelöschte Leerzeichen");
            string leer = "";
            foreach (char c in satz)
            {
                if (!(c == ' '))
                {
                    leer += c;
                }
            }

            Console.Write(leer);


            // 5. Lösche jedes Ausrufezeichen
            Console.WriteLine("\n\ngelöschte Ausrufezeichen");
            string ruf = "";
            foreach (char c in satz)
            {
                if (!(c == '!'))
                {
                    ruf += c;
                }
            }

            Console.Write(ruf);


            // Console.WriteLine("\ngelöschtes Leerzeichen:");
            // for(int i = 0; i <= satz.Length; i++)
            // {
            //     char[] totrim = { '!' };
            //     Console.Write(satz.Trim(totrim));
            // }
        }
    }
}