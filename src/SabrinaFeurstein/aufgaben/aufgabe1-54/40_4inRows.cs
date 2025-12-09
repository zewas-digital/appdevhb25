using System;
using System.ComponentModel;
using System.Dynamic;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class _4inRows
    {
        public static void Game()
        {
            int[,] board = new int[6, 7];
            int spieler;
            bool win = false;
            Board(board);

            for (int i = 0; i < 42;)
            {
                i++;
                spieler = 1;
                Spieler(board, spieler);
                Board(board);
                Check(board, spieler, ref win);

                if (win == true)
                    break;

                i++;
                spieler = 2;
                Spieler(board, spieler);
                Board(board);
                Check(board, spieler, ref win);

                if (win == true)
                    break;
            }

            if (win == false)
                Console.WriteLine("Unentschieden!");
        }

        public static void Board(int[,] board)
        {
            Console.Clear();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write($"{board[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Spieler(int[,] board, int spieler)
        {
            Console.WriteLine($"Spieler {spieler}");
            Console.Write("Spalte: ");
            int spalte = Convert.ToInt32(Console.ReadLine()) - 1;

            for (int i = board.GetLength(0) - 1; i >= 0; i--)
            {
                if (board[i, spalte] == 0)
                {
                    board[i, spalte] = spieler;
                    break;
                }
            }
        }
        
        public static bool Check(int[,] board, int spieler, ref bool win)
        {
            bool horizontal = false;
            bool vertical = false;
            bool diagonal1 = false;
            bool diagonal2 = false;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1) - 3; j++)
                {
                    horizontal |= board[i, j] == spieler && board[i, j + 1] == spieler && board[i, j + 2] == spieler && board[i, j + 3] == spieler;
                }
            }

            for (int i = 0; i < board.GetLength(1); i++)
            {
                for (int j = 0; j < board.GetLength(0) - 3; j++)
                {
                    vertical |= board[j, i] == spieler && board[j + 1, i] == spieler && board[j + 2, i] == spieler && board[j + 3, i] == spieler;

                }
            }

            for (int i = 0; i < board.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < board.GetLength(1) - 3; j++)
                {
                    diagonal1 |= board[i, j] == spieler && board[i + 1, j + 1] == spieler && board[i + 2, j + 2] == spieler && board[i + 3, j + 3] == spieler;
                }
            }

            for (int i = 3; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1) - 3; j++)
                {
                    diagonal2 |= board[i, j] == spieler && board[i - 1, j + 1] == spieler && board[i - 2, j + 2] == spieler && board[i - 3, j + 3] == spieler;
                }
            }

            if (horizontal || vertical || diagonal1 || diagonal2)
            {
                Console.WriteLine($"Spieler {spieler} gewinnt!");
                win = true;
            }
            return win;
        }
    }
}