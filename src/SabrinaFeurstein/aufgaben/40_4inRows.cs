using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class _4inRows
    {
        public static void Game()
        {
            int[,] board = new int[6, 7];
            int spieler;
            Board(board);

            for (int i = 0; i < 42;)
            {
                i++;
                spieler = 1;
                Spieler(board, spieler);
                Board(board);

                i++;
                spieler = 2;
                Spieler(board, spieler);
                Board(board);
            }
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
                Check(board, i);
            }
        }
        
        public static void Check(int[,] board, int zeile)
        {
            for (int j = 0; j < 3; j++)
            {
                if {}
            }
        }
    }
}