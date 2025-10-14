using System;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe40
{
    public class FourInRows
    {
        public static void Start()
        {
            VierGewinnt();
        }

        public static void VierGewinnt()
        {
            int[,] board = new int[6, 7];
            int turn = 1;
            int currentPlayer = 1;
         

            while (turn < 42)
            {
                Console.Clear();
                PrintBoard(board);
                WinConditions(board, currentPlayer);
              
                
                if (turn % 2 == 0)
                {
                    currentPlayer = 2;
                    Console.WriteLine($"Spieler {currentPlayer} ist am Zug.");
                }
                else
                {
                    currentPlayer = 1;
                    Console.WriteLine($"Spieler {currentPlayer} ist am Zug.");
                }
                turn++;
            
                int xCoor = GetCoordinate("x") - 1;
                int yCoorLeft = YCoordinate(board, xCoor);

                if (yCoorLeft == -1)
                {
                    yCoorLeft--;
                }

                board[yCoorLeft, xCoor] = currentPlayer;
                
            }
        }

        public static void PrintBoard(int[,] board)
        {
            System.Console.WriteLine("Connect Four!");
            Console.WriteLine("\n   1 2 3 4 5 6 7");
            System.Console.WriteLine("----------------");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write($"{i + 1}| ");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int GetCoordinate(string name)
        {
            int coord;
            while (true)
            {
                Console.Write($"Gib die {name}-Koordinate (1-7) ein: ");

                if (int.TryParse(Console.ReadLine(), out coord) && coord >= 1 && coord <= 7)
                    return coord;
                Console.WriteLine("Ungültige Eingabe. Bitte Zahl zwischen 1 und 7 eingeben.");
            }
        }

        public static int YCoordinate(int[,] board, int xCoor)
        {
            for (int i = board.GetLength(0) - 1; i >= 0; i--)
            {
                if (board[i, xCoor] == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void WinConditions(int[,] board, int currentPlayer)
        {
            // Rechts-Links
            for (int i = 0; i < board.GetLength(0); i++)
            {
                int counter = 0;
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == currentPlayer)
                    {
                        counter++;
                        System.Console.WriteLine(counter);
                        if (counter == 4)
                        {
                            System.Console.WriteLine($"Player {currentPlayer} WON!!!");
                            break;
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }
            }

            // Oben-Unten
            for (int k = 0; k < board.GetLength(1); k++)
            {
                int counter2 = 0;
                for (int l = 0; l < board.GetLength(0); l++)
                {
                    if (board[l, k] == currentPlayer)
                    {
                        counter2++;
                        if (counter2 == 4)
                        {
                            System.Console.WriteLine($"Player {currentPlayer} WON!!!");
                            break;
                        }
                    }
                    else
                    {
                        counter2 = 0;
                    }
                }
            }

            // Für DESC
            for (int j = 0; j <= board.GetLength(0) / 2; j++)
            {
                int counter3 = 0;
                for (int i = 0; i < board.GetLength(0) - j; i++)
                {

                    if (board[j + i, i] == currentPlayer)
                    {
                        counter3++;
                        if (counter3 == 4)
                        {
                            System.Console.WriteLine($"Player {currentPlayer} WON!!!");
                        }
                        break;
                    }
                }
            }

            // Für ASC
            
        }
    }
}

