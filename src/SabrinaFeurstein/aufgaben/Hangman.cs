using System;
using Appdevhb25.SabrinaFeurstein;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class Hangman
    {
        public static void Start()
        {
            Console.Clear();
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            char[] lettersWord = word.ToCharArray();
            char[] letterCount = new char[word.Length];
            string lettersGuessed = "";
            int wrongGuesses = 7;

            for (int i = 0; i < letterCount.Length; i++)
                letterCount[i] = '_';

            Console.Clear();
            foreach (char elem in letterCount)
                Console.Write($"{elem} ");
            Console.WriteLine();
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter a letter: ");
                char letter = Convert.ToChar(Console.ReadLine());

                for (int i = 0; i < letterCount.Length; i++)
                {
                    if (lettersWord[i] == letter)
                        letterCount[i] = letter;
                }

                Console.Clear();
                foreach (char elem in letterCount)
                    Console.Write($"{elem} ");
                Console.WriteLine();
                Console.WriteLine();

                if (!letterCount.Contains('_'))
                {
                    Console.WriteLine("Word guessed - You win!");
                    break;
                }

                if (!lettersWord.Contains(letter))
                {
                    Console.WriteLine("Letter is not included in the word!");
                    lettersGuessed += letter + " ";
                    wrongGuesses--;
                }

                if (wrongGuesses == 0)
                {
                    Console.WriteLine("Out of guesses - You lose!");
                    Console.WriteLine("The word was: " + word);
                    break;
                }

                Console.WriteLine();
                Console.WriteLine($"Guesses left: {wrongGuesses}");
                Console.WriteLine($"Already guessed letters: {lettersGuessed}");
            }
        }
    }
}