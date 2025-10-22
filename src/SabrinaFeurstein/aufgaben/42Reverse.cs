using System;
using System.Diagnostics;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class ReversedWord
    {
        public static void Start()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            char[] charArray = word.ToCharArray();

            string reversed = string.Empty;

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reversed += charArray[i];
            }

            Console.WriteLine(reversed);

            Console.WriteLine(Reverser(charArray));
        }

        public static string Reverser(char[] charArray)
        {
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}