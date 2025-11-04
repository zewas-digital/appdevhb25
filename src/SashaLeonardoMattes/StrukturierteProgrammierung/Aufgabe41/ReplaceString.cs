using System;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe41
{

    public class ReplaceString
    {

        public static void StartReplaceString()
        {
            Console.WriteLine("----------Aufgabe 41----------");

            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            text = text.Replace("wird", "war und ist");
            System.Console.WriteLine("wird mit war und ist ersetzen:");
            System.Console.WriteLine(text);

            char[] chars = text.ToCharArray();
            char[] upperChars = new char[chars.Length];
            char[] lowerChars = new char[chars.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                if (!char.IsLower(chars[i]) || chars[i] == ' ')
                {
                    upperChars[i] = chars[i];
                }
            }

            System.Console.WriteLine("Lösche alle Kleinbuchstaben:");
            for (int i = 0; i < upperChars.Length; i++)
            {
                System.Console.Write(upperChars[i]);
            }

            System.Console.WriteLine();

             for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLower(chars[i]) || chars[i] == ' ')
                {
                    lowerChars[i] = chars[i];
                }
            }

            System.Console.WriteLine("Lösche alle Großbuchstaben:");
            for (int i = 0; i < lowerChars.Length; i++)
            {
                System.Console.Write(lowerChars[i]);
            }

            string textNoSpace = text.Replace(" ", "");
            System.Console.WriteLine("Ohne Leerzeichen: ");
            System.Console.WriteLine(textNoSpace);

            text = text.Replace("!", "");
            System.Console.WriteLine("Ohne Rufezeichen: ");
            System.Console.WriteLine(text);
        }


    }
}
