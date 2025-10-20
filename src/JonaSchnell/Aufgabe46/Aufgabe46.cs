using System;
using System.ComponentModel;

namespace Appdevhb25.JonaSchnell.Aufgabe46
{
    public class Aufgabe46
    {
        public static void Start46()
        {
            //1
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            string[] words = { " war ", " ist " };

            int i = 0;

            Random random = new Random();

            string randomString = words[random.Next(words.Length)];

            var replacement = text.Replace("wird", randomString);

            i++;

            Console.WriteLine($"{replacement}");
        }

        public static void RemoveAsciiLowercase()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            char[] ka = new char[text.Length];
            int j = 0;
            foreach (char letters in text)
            {
                if (letters < 97 || letters > 122)
                {
                    ka[j++] = letters;
                }
            }
            Console.Write(ka[j]);
        }

        public static void RemoveAsciiUppercase()
        {
        string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            char[] ka = new char[text.Length];
            int j = 0;
            foreach (char letters in text)
            {
                if (letters < 65 || letters > 90)
                {
                    ka[j++] = letters;
                }
            }
            Console.Write(ka[j]);
        }
    }
}