using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe42
{
    public class Reverse
    {
        public static void Start()
        {
            Console.WriteLine("Gib ein Wort ein");
            string word = Console.ReadLine();
            char[] letter = word.ToCharArray();

            Console.WriteLine("Das Wort umgedreht:");
            for (int i = letter.Length - 1; i >= 0; i--)
            {
                Console.Write(letter[i]);
            }
            Console.WriteLine();

        }
    }
}