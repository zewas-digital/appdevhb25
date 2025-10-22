using System;
using Appdevhb25.SelinUlutuerk.Arrays;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe40
{
    class InRow
    {
        static int ROW = 6;
        static int COL = 7;
        static int[,] board = new int[ROW, COL];

        // Player switch
        static int currentPlayer = 1;
        static void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == 1) ? 2 : 1;
        }

        // Move
        private static bool MakeMove(int column)
        {
            if (column < 0 || column >= COL)
                return false;

            for (int row = ROW - 1; row >= 0; row--)
            {
                if (board[row, column] == 0)
                {
                    board[row, column] = currentPlayer;
                    return true;
                }
            }

            return false; // Spalte ist voll
        }

        static bool CheckWin(int player)
        {
            // Horizontal
            for (int r = 0; r < ROW; r++)
            {
                for (int c = 0; c <= COL - 4; c++)
                {
                    if (board[r, c] == player &&
                        board[r, c + 1] == player &&
                        board[r, c + 2] == player &&
                        board[r, c + 3] == player)
                        return true;
                }
            }

            // Vertikal
            for (int c = 0; c < COL; c++)
            {
                for (int r = 0; r <= ROW - 4; r++)
                {
                    if (board[r, c] == player &&
                        board[r + 1, c] == player &&
                        board[r + 2, c] == player &&
                        board[r + 3, c] == player)
                        return true;
                }
            }

            // Diagonal
            for (int r = 0; r <= ROW - 4; r++)
            {
                for (int c = 0; c <= COL - 4; c++)
                {
                    if (board[r, c] == player &&
                        board[r + 1, c + 1] == player &&
                        board[r + 2, c + 2] == player &&
                        board[r + 3, c + 3] == player)
                        return true;
                }
            }

            // Diagonal
            for (int r = 3; r < ROW; r++)
            {
                for (int c = 0; c <= COL - 4; c++)
                {
                    if (board[r, c] == player &&
                        board[r - 1, c + 1] == player &&
                        board[r - 2, c + 2] == player &&
                        board[r - 3, c + 3] == player)
                        return true;
                }
            }

            return false;
        }

        // Full board check
        static bool IsBoardFull()
        {
            for (int r = 0; r < ROW; r++)
            {
                for (int c = 0; c < COL; c++)
                {
                    if (board[r, c] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void Start()
        {
            Console.WriteLine("*** Let's play 4 in a Row ***");

            while (!IsBoardFull())
            {
                ArrayHelper.PrintArray(board);

                Console.WriteLine($"Player {currentPlayer}, choose a column between 1 and {COL}: ");
                int moveCol;

                if (!int.TryParse(Console.ReadLine(), out moveCol) || moveCol < 1 || moveCol > COL)
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                moveCol -= 1; // Umwandlung von 1–7 auf 0–6

                bool moveSuccessful = MakeMove(moveCol);

                if (!moveSuccessful)
                {
                    Console.WriteLine("Column is full. Try another one.");
                    continue;
                }

                if (CheckWin(currentPlayer))
                {
                    ArrayHelper.PrintArray(board);
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    return;
                }

                SwitchPlayer();
            }

            Console.WriteLine("Game over! Board is full.");
        }
    }
}