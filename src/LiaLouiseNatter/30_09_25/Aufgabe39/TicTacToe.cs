using System;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe39
{
    public class TicTacToe
    {
        public static void Start()
        {
            TicTacToeGame();
        }

        public static void TicTacToeGame()
        {
            int[,] board = new int[3, 3];
            int turn = 0;

            while (turn < 9)
            {
                Console.Clear();
                PrintBoard(board);
                int currentPlayer;
                if (turn % 2 == 0)
                {
                    currentPlayer = 1;
                    Console.WriteLine($"Spieler {currentPlayer} ist am Zug.");
                }
                else
                {
                    currentPlayer = 2;
                    Console.WriteLine($"Spieler {currentPlayer} ist am Zug.");
                }

                int xCoor = GetCoordinate("x") - 1;
                int yCoor = GetCoordinate("y") - 1;

                if (board[xCoor, yCoor] != 0)
                {
                    Console.WriteLine("Feld bereits belegt!");
                    Console.ReadKey();
                    continue;
                }

                board[xCoor, yCoor] = currentPlayer;
                turn++;

                if (CheckWinner(board, currentPlayer))
                {
                    Console.Clear();
                    PrintBoard(board);
                    Console.WriteLine($"Spieler {currentPlayer} hat gewonnen!");
                    return;
                }
            }

            Console.Clear();
            PrintBoard(board);
            Console.WriteLine("Unentschieden! Kein Spieler hat gewonnen.");
        }

        public static int GetCoordinate(string name)
        {
            int coord;
            while (true)
            {
                Console.Write($"Gib die {name}-Koordinate (1-3) ein: ");

                if (int.TryParse(Console.ReadLine(), out coord) && coord >= 1 && coord <= 3)
                    return coord;
                Console.WriteLine("Ungültige Eingabe. Bitte Zahl zwischen 1 und 3 eingeben.");
            }
        }

        public static void PrintBoard(int[,] board)
        {
            System.Console.WriteLine("TicTacToe!");
            Console.WriteLine("\n   1 2 3");
            System.Console.WriteLine("----------");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i + 1}| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static bool CheckWinner(int[,] board, int player)
        {
            for (int i = 0; i < 3; i++)
            {   // Spalten
                if ( (board[0, i] == player && board[1, i] == player && board[2, i] == player) ||
                    // Zeilen
                    (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                    )
                    return true;
            }

            if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
                (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
                return true;

            return false;
        }
    }
}

