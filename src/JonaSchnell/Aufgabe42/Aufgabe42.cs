using System;

namespace Appdevhb25.JonaSchnell.Aufgabe42
{
    public class Aufgabe42
    {
        public static void Start42()
        {
            Console.WriteLine("Gib ein Wort ein.");
            string? original = Console.ReadLine();

            if (string.IsNullOrEmpty(original))
            {
                Console.WriteLine("Ungültige Eingabe!");
                return;
            }

            int length = original.Length;
            Console.WriteLine(length);
        }
    }
}
