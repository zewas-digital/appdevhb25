using System;
using System.ComponentModel;

namespace Appdevhb25.JonaSchnell.Aufgabe46
{
    public class Aufgabe46
    {
        public static void Start46()
        {
            System.Console.WriteLine("");

            string text = "Gestern wird ein guter Tag! Heute wird ein noch besserer Tag! Morgen wird ein spitzen guter Tag!";

            string[] words = { "ist", "ist" };

            int i = 0;

            Random random = new Random();

            string randomString = words[random.Next(words.Length)];

            var replacement = text.Replace("wird", randomString);

            i++;

            Console.WriteLine($"{replacement}");
            System.Console.WriteLine("");
        }

        public static void RemoveAsciiLowercase()
        {
            string text = "Gestern wird ein guter Tag! Heute wird ein noch guterer Tag! Morgen wird ein spitzen guter Tag!";
            foreach (char elem in text)
            {
                if (elem >= 97 && elem <= 122)
                {
                    System.Console.Write(elem);
                }
                else
                {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("");
        }
        public static void RemoveAsciiUppercase()
        {
            string text = "Gestern wird ein guter Tag! Heute wird ein noch guterer Tag! Morgen wird ein spitzen guter Tag!";
            foreach (char elem in text)
            {
                if (elem >= 65 && elem <= 90)
                {
                    System.Console.Write(elem);
                }
                else
                {
                    System.Console.Write("");
                }
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("");
        }
        public static void RemoveAsciiBlanks()
        {
            string text = "Gestern wird ein guter Tag! Heute wird ein noch guterer Tag! Morgen wird ein spitzen guter Tag!";
            foreach (char elem in text)
            {
                if (elem > 32 || elem < 32)
                {
                    System.Console.Write(elem);
                }
                else
                {
                    System.Console.Write("");
                }
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("");
        }
        public static void RemoveAsciiExclamationMark()
        {
            string text = "Gestern wird ein guter Tag! Heute wird ein noch guterer Tag! Morgen wird ein spitzen guter Tag!";
            foreach (char elem in text)
            {
                if (elem > 33 || elem < 33)
                {
                    System.Console.Write(elem);
                }
                else
                {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("");
        }
    }
}