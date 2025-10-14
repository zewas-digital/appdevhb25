using System;
using System.ComponentModel;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class TicTacToe
    {
        public static void Game()
        {
            int[,] game = new int[3, 3];
            int win = 0;
            int spieler = 0;

            Board(game);

            for (int i = 0; i < 9;)
            {
                int spalte1 = 0;
                int zeile1 = 0;

                do
                {
                    Console.WriteLine("Spieler 1");
                    Console.Write("Spalte: ");
                    spalte1 = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.Write("Zeile: ");
                    zeile1 = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (game[zeile1, spalte1] != 0)
                    {
                        Console.WriteLine("Ungültige Eingabe!");
                    }
                }
                while (game[zeile1, spalte1] != 0);

                game[zeile1, spalte1] = 1;
                Board(game);
                spieler = 1;
                i++;
                Check(game, ref win, spieler);
                if (win == 1 || i == 9)
                    break;

                int spalte2 = 0;
                int zeile2 = 0;

                do
                {
                    Console.WriteLine("Spieler 2");
                    Console.Write("Spalte: ");
                    spalte2 = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.Write("Zeile: ");
                    zeile2 = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (game[zeile2, spalte2] != 0)
                    {
                        Console.WriteLine("Ungültige Eingabe!");
                    }
                }
                while (game[zeile2, spalte2] != 0);

                game[zeile2, spalte2] = 2;
                Board(game);
                spieler = 2;
                i++;
                Check(game, ref win, spieler);
                if (win == 1)
                    break;
            }

            if (win == 0)
            {
                Console.WriteLine("Unentschieden!");
            }
        }

        public static void Board(int[,] game)
        {
            Console.Clear();
            for (int i = 0; i < game.GetLength(0); i++)
            {
                for (int j = 0; j < game.GetLength(1); j++)
                {
                    Console.Write($"{game[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Check(int[,] game, ref int win, int spieler)
        {
            bool diagonal1 = game[0, 0] == spieler && game[1, 1] == spieler && game[2, 2] == spieler;
            bool diagonal2 = game[2, 0] == spieler && game[1, 1] == spieler && game[0, 2] == spieler;
            bool vertical = false;
            bool horizontal = false;

            for (int i = 0; i < 3; i++)
            {
                vertical |= game[0, i] == spieler && game[1, i] == spieler && game[2, i] == spieler;
                horizontal |= game[i, 0] == spieler && game[i, 1] == spieler && game[i, 2] == spieler;
            }

            if (diagonal1 || diagonal2 || vertical || horizontal)
            {
                win = 1;
                Console.WriteLine($"Spieler {spieler} hat gewonnen!");
            }
        }
    }
}