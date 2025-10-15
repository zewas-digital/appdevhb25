using System;
using Microsoft.VisualBasic;

namespace Appdevhb25.JonaSchnell.Aufgabe43
{
    public class Aufgabe43
    {
        public static void Start43()
        {
            string[] words = ["Apfel", "Birne", "Maus", "Haus", "Blabla"];

            string? wordPart = Console.ReadLine();
            if (string.IsNullOrEmpty(wordPart))
            {
                Console.WriteLine("Ungültige Eingabe!");
                return;
            }
            /*for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower().Contains(wordPart.ToLower()) == true)
                {
                    System.Console.WriteLine(i + 1);
                }
            }*/
            foreach (string word in words)
            {
                if (word.Trim().ToLower().Contains(wordPart.ToLower()))
                {
                    System.Console.WriteLine(word);
                }
            }
        }
    }
}