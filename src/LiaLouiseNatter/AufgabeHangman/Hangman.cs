using System;

namespace Appdevhb25.LiaLouiseNatter.AufgabeHangman
{
    public class Hangman
    {
        private static int mistakes;
        private static char[] revealedWord;

        private static string[] correctlyGuessed = new string[26];
        private static string[] wrongGuessed = new string[26];
        private static int correctCount = 0;
        private static int wrongCount = 0;

        public static void Start()
        {
            GameFlow();
        }

        public static string[][] hangmanarray()
        {
            string[][] hangmanStages = new string[][]
            {
                new string[]
                {
                    "      ",
                    "      ",
                    "      ",
                    "      ",
                    "      ",
                    "      ",
                    "========"
                },
                new string[]
                {
                    "      ",
                    "      |",
                    "      |",
                    "      |",
                    "      |",
                    "      |",
                    "========"
                },
                new string[]
                {
                    "+-----+",
                    "      |",
                    "      |",
                    "      |",
                    "      |",
                    "      |",
                    "========"
                },
                new string[]
                {
                    "+-----+",
                    "   |  |",
                    "      |",
                    "      |",
                    "      |",
                    "      |",
                    "========"
                },
                new string[]
                {
                    "+---+  ",
                    "  |   |",
                    "  O   |",
                    "      |",
                    "      |",
                    "      |",
                    "========"
                },
                new string[]
                {
                    "+---+  ",
                    "  |   |",
                    "  O   |",
                    "  |   |",
                    "      |",
                    "      |",
                    "========"
                },
                new string[]
                {
                    "+---+  ",
                    "  |   |",
                    "  O   |",
                    " /|   |",
                    "      |",
                    "      |",
                    "========"
                },
                new string[]
                {
                    "+---+  ",
                    "  |   |",
                    "  O   |",
                    " /|\\  |",
                    "      |",
                    "      |",
                    "========"
                },
                new string[]
                {
                    "+---+  ",
                    "  |   |",
                    "  O   |",
                    " /|\\  |",
                    " /    |",
                    "      |",
                    "========"
                },
                new string[]
                {
                    "+---+  ",
                    "  |   |",
                    "  O   |",
                    " /|\\  |",
                    " / \\  |",
                    "      |",
                    "========"
                }
            };
            return hangmanStages;
        }

        public static void HangManDrawer(int mistakes, string[][] hangmanStages)
        {
            foreach (var line in hangmanStages[mistakes])
                Console.WriteLine(line);
        }

        public static string[] RandomWordList()
        {
            string[] wordList = new string[]
            {
                    "apple", "balloon", "cactus", "dragon", "elephant", "forest", "guitar", "hammer", "island", "jungle",
                    "kangaroo", "lemon", "mountain", "notebook", "ocean", "pencil", "quartz", "rocket", "sunflower", "tunnel",
                    "umbrella", "village", "whistle", "xylophone", "yogurt", "zebra", "anchor", "bridge", "cloud", "dolphin",
                    "engine", "feather", "galaxy", "harvest", "igloo", "jacket", "kitten", "ladder", "mirror", "needle",
                    "orange", "pirate", "quiver", "river", "shadow", "ticket", "unicorn", "valley", "window", "yarn",
                    "zombie", "artist", "bottle", "crystal", "desert", "energy", "flamingo", "glacier", "helmet", "insect",
                    "jewel", "koala", "lantern", "magnet", "napkin", "orbit", "parrot", "quokka", "rainbow", "scooter",
                    "tractor", "urchin", "vortex", "wallet", "xenon", "yellow", "zephyr", "arrow", "breeze", "compass",
                    "dagger", "emerald", "furnace", "garden", "harbor", "icicle", "jigsaw", "karate", "lizard", "marble",
                    "nectar", "oak", "pumpkin", "quilt", "ribbon", "saddle", "tower", "utensil", "volcano", "wagon",
                     "yeti", "zenith", "bubble", "clover", "drizzle", "echo", "firefly", "gravel", "hinge"
            };

            return wordList;
        }

        public static string RandomWordGetter(string[] wordList)
        {
            Random random = new Random();
            return wordList[random.Next(wordList.Length)];
        }

        public static void GameFlow()
        {
            int turn = 0;
            mistakes = 0;

            string[] wordList = RandomWordList();
            string currentWord = RandomWordGetter(wordList);
            revealedWord = new char[currentWord.Length];
            while (turn < 26)
            {
                Console.Clear();
                DrawCurrentWord();

                string[][] hangmanStages = hangmanarray();
                HangManDrawer(mistakes, hangmanStages);
                Looser(currentWord);
                Console.WriteLine();
                System.Console.WriteLine("------------------------");


                int currentPlayer = (turn % 2 == 0) ? 1 : 2;
                Console.WriteLine($"Spieler {currentPlayer} ist am Zug.");

                Console.Write("Correct letters: ");
                if (correctCount == 0)
                    Console.Write("keine");
                else
                    for (int i = 0; i < correctCount; i++)
                        Console.Write(correctlyGuessed[i] + " ");
                Console.WriteLine();

                Console.Write("Incorrect letters: ");
                if (wrongCount == 0)
                    Console.Write("keine");
                
                else
                    for (int i = 0; i < wrongCount; i++)
                        Console.Write(wrongGuessed[i] + " ");
                Console.WriteLine();
                System.Console.WriteLine("------------------------");

                string letter = WordOrLetter(currentWord, mistakes, currentPlayer);
                

                if (!string.IsNullOrEmpty(letter))
                {
                    bool contains = LetterChecker(letter, currentWord);
                    AlreadyGuessed(contains, letter);

                    if (contains)
                    {
                        WordDrawer(currentWord, letter);
                        Winner(currentWord, currentPlayer);
                    }
                }
                turn++;
            }
        }

        public static string WordOrLetter(string currentWord, int mistakes, int currentPlayer)
        {
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                try
                {
                    Console.Write("Do you want to try a word [0] or a letter [1]? ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 0)
                    {
                        WordChecker(currentWord, mistakes, currentPlayer);
                        return null;
                    }
                    else if (choice == 1)
                    {
                        return LetterGetter(currentWord, mistakes);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only 0 or 1 are allowed, try again...");
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only 0 or 1 are allowed, try again...");
                }
            }
        }

        public static void WordChecker(string currentWord, int mistakes, int currentPlayer)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Which word do you want to try? ");
            string guess = Console.ReadLine();

            if (currentWord == guess)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Player {currentPlayer}, you Won!");
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You guessed wrong...");
                mistakes += 2;
                wrongCount += 2;
            }
        }

        public static string LetterGetter(string currentWord, int mistakes)
        {
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                Console.Write("Which letter do you want to try? ");
                string letter = Console.ReadLine();

                if (letter.Length != 1 || !char.IsLetter(letter[0]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only single letters (a-z) are allowed...");
                    continue;
                }
                return letter.ToLower();
            }
        }

        public static bool LetterChecker(string letter, string currentWord)
        {
            return currentWord.Contains(letter);
        }

        public static void AlreadyGuessed(bool contains, string letter)
        {
            if (contains)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You guessed correctly!");
                correctlyGuessed[correctCount++] = letter;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You guessed wrong!");
                wrongGuessed[wrongCount++] = letter;
                mistakes++;
            }
        }

        public static void WordDrawer(string currentWord, string letter)
        {
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (currentWord[i] == letter[0])
                {
                    revealedWord[i] = letter[0];
                }
            }

            DrawCurrentWord();
        }

        public static void DrawCurrentWord()
        {
            for (int i = 0; i < revealedWord.Length; i++)
            {
                if (revealedWord[i] == '\0')
                    Console.Write("_ ");
                else
                    Console.Write(revealedWord[i] + " ");
            }
            
            Console.WriteLine();
        }

        private static void Looser(string currentWord)
        {
            if (wrongCount >= 9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You lost... The word was: {currentWord}");
                Environment.Exit(0);
            }
        }

        private static void Winner(string currentWord, int currentPlayer)
        {
            if (!revealedWord.Contains('\0'))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"Player{currentPlayer} you Won!");
                Environment.Exit(0);
            }
        }
    }
}
