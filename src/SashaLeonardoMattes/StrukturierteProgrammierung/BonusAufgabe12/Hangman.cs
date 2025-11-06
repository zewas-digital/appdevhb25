using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe12
{

    public class Hangman
    {

        public static string[] wordPool = new string[100];
        public static Random rndGen = new Random();
        public static string correctWord="";
        public static string displayWord="";
        public static int triesLeft = 6;
        public static string playerGuess="";
        public static List<char> guessedChars = new List<char>();
        public static List<string> guessedWords = new List<string>();

        public static bool win = false;
        public static string info="";
        
        public static void StartHangman()
        {
            Console.WriteLine("----------HANGMAN:----------");

            wordPool = File.ReadAllLines(@"C:\Users\sasha.mattes\Documents\Zewas\appdevhb25\src\SashaLeonardoMattes\BonusAufgabe12\HangmanWords.txt");
            correctWord = wordPool[rndGen.Next(0, 100)];
            for (int i = 0; i < correctWord.Length; i++)
            {
                displayWord += "_ ";
            }

            info = "";
            bool playerAtTurn = false;

            DrawHangman(triesLeft, info);

            //System.Console.WriteLine(correctWord);
            //System.Console.WriteLine(displayWord);

            do
            {
                bool validInput; 
                do
                {
                    System.Console.Write($"Spieler {Convert.ToInt16(playerAtTurn)+1} ist dran. Gib einen Buchstaben oder das Wort ein:");
                    playerGuess = Helper.checkUserInputString();

                    if (playerGuess.Length < 2)
                    {
                        if (isDoubleGuess(Convert.ToChar(playerGuess)))
                        {
                            validInput = false;
                            System.Console.WriteLine("Dieser Buchstabe wurde bereits gesucht!");
                        }
                        else
                        {
                            validInput = true;
                        }
                    }
                    else
                    {
                        if (isDoubleGuessWord(playerGuess))
                        {
                            validInput = false;
                            System.Console.WriteLine("Dieses Wort wurde bereits gesucht!");
                        }
                        else
                        {
                            validInput = true;
                        }
                    }
                    
                } while (!validInput);

                if (!CheckGuess(playerGuess))
                {
                    
                    if (playerGuess.Length > 1)
                    {
                        triesLeft -= 2;
                        info = "\"" + playerGuess + "\" ist nicht das gesuchte Wort!";
                    }
                    else
                    {
                        triesLeft--;
                        info = "\"" + playerGuess + "\" ist nicht im gesuchten Wort enthalten!";
                    }
                }
                else
                {
                    info = "\"" + playerGuess + "\" ist im Wort enthalen!";
                }
                DrawHangman(triesLeft, info);
                playerAtTurn = !playerAtTurn;

            } while (!win && triesLeft > 0);

            if (triesLeft > 0)
            {
                if (!playerAtTurn)
                {
                    System.Console.WriteLine("Spieler 1 hat gewonnen!");
                }
                else
                {
                    System.Console.WriteLine("Spieler 2 hat gewonnen!");

                }
            }
            else
            {
                System.Console.WriteLine("Ihr habt verloren!");
                
                System.Console.WriteLine("Das gesuchte Wort war: " + correctWord);
            }


        }

        public static void DrawHangman(int triesLeft, string info)
        {
            Console.Clear();
            Console.WriteLine("  +-------+");
            Console.WriteLine("  |       |");

            if (triesLeft <= 5)
                Console.WriteLine("  O       |");
            else
                Console.WriteLine("          |");

            if (triesLeft <= 2)
                Console.WriteLine(" /|\\      |");
            else if (triesLeft <= 3)
                Console.WriteLine(" /|       |");
            else if (triesLeft <= 4)
                Console.WriteLine("  |       |");
            else
                Console.WriteLine("          |");

            if (triesLeft <= 0)
                Console.WriteLine(" / \\      |");
            else if (triesLeft <= 1)
                Console.WriteLine(" /        |");
            else
                Console.WriteLine("          |");

            Console.WriteLine("          |");
            Console.WriteLine("===========");

            System.Console.WriteLine();
            System.Console.WriteLine("Wort: " + displayWord);
            System.Console.WriteLine();
            System.Console.WriteLine(info);
            System.Console.Write("Bereits geraten: ");
            foreach (var item in guessedChars)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
        }

        public static bool CheckGuess(string guess)
        {
            bool guessCorrect = false;

            for (int i = 0; i < correctWord.Length * 2; i += 2) //+2 um Leerzeichen zu überspringen
            {
                if (guess.ToLower() == correctWord.ToLower())
                {
                    displayWord = guess;
                    win = true;
                    guessCorrect = true;
                }

                if (correctWord.Substring(i / 2, 1).ToLower() == guess.ToLower())
                {
                    guessCorrect = true;
                    displayWord = displayWord.Remove(i, 1);
                    displayWord = displayWord.Insert(i, guess);

                    if (!displayWord.Contains("_"))
                    {
                        win = true;
                        return true;
                    }
                }
            }

            return guessCorrect;
        }

        public static bool isDoubleGuess(char guess)
        {
            foreach (var letter in guessedChars)
            {
                if (letter == guess)
                {
                    return true;
                }
            }

            guessedChars.Add(guess);
            return false;
        }

        public static bool isDoubleGuessWord(string guess)
        {
            foreach (var word in guessedWords)
            {
                if (word == guess)
                {
                    return true;
                }
            }

            guessedWords.Add(guess);
            return false;
        }
    }
}
