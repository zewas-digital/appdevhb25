using System;
using System.Diagnostics;
using Appdevhb25.SelinUlutuerk.Arrays;

namespace Appdevhb25.SelinUlutuerk.Aufgabe39
{
    class TicTacToe
    {
        static int[,] board = new int[3, 3];

        static int currentPlayer = 1;

        // Player switch
        static void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == 1) ? 2 : 1;
        }

        static bool MakeMove(int row, int column)
        {
            if (row >= 0 && row < 3 && column >= 0 && column < 3 && board[row, column] == 0)
            {
                board[row, column] = currentPlayer == 1 ? 1 : 2;
                return true;
            }
            if (board[row, column] == 1 || board[row, column] == 2)
            {
                return false;
            }
            return false;
        }

        public static void Start()
        {
            Console.WriteLine("***Willkommen zu TicTacToe***\n");

            while (true)
            {
                ArrayHelper.PrintArray(board);
                Console.WriteLine($"Player {currentPlayer}, enter your move(row and column): ");
                int row = Convert.ToInt16(Console.ReadLine());
                int col = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine();

                if (MakeMove(row, col))
                {
                    if (CheckWinPlayer(currentPlayer))
                    {
                        ArrayHelper.PrintArray(board);
                        Console.WriteLine($"---Player {currentPlayer} wins!---\n");
                        break;
                    }
                    else if (IsBoardFull())
                    {
                        ArrayHelper.PrintArray(board);
                        Console.WriteLine("\nIt's a draw!");
                        break;
                    }
                    SwitchPlayer();
                }
                else
                {
                    Console.WriteLine("\n---Invalid move, try again.---\n");
                }
            }

            // Zeichnen von Board
            ArrayHelper.PrintArray(board);
        }

        // Win checker
        static bool CheckWinPlayer(int player)
        {
            for (int i = 0; i < 3; i++)
            {
                // Zeilen und Spalten prüfen
                if ((board[i, 0] == player && board[i, 1] == player && board[i, 2] == player) ||
                    (board[0, i] == player && board[1, i] == player && board[2, i] == player))
                {
                    return true;
                }

                // Diagonalen prüfen
                if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
                    (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
                {
                    return true;
                }
            }
            return false;
        }

        //Board is full
        static bool IsBoardFull()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (board[r, c] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}