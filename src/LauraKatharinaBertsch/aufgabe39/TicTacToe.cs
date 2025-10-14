using System.Data;
using System.Runtime.CompilerServices;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe39
{
    public class TicTacToe
    {
        public static void Start()
        {
            int[,] twoDArray = new int[3, 3];

            for (int y = 0; y < twoDArray.GetLength(0); y++)
            {
                for (int x = 0; x < twoDArray.GetLength(1); x++)
                {
                    Console.Write(twoDArray[y, x] + " ");
                }
                Console.WriteLine();
            }

            while (true)
            {
                Console.WriteLine("Spieler 1 ist dran");
                Console.WriteLine("Welche Zeile von 0-2 soll geändert werden?");
                int zeile = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Welche Spalte von 0-2 soll geändert werden?");
                int spalte = Convert.ToInt32(Console.ReadLine());
                twoDArray[zeile, spalte] = 1;
                Console.Clear();
                for (int y = 0; y < twoDArray.GetLength(0); y++)
                {
                    for (int x = 0; x < twoDArray.GetLength(1); x++)
                    {
                        Console.Write(twoDArray[y, x] + " ");
                    }
                    Console.WriteLine();
                }
                bool winner1 = TicTacToeWinner1(twoDArray);
                if (winner1)
                {
                    Console.WriteLine("Spieler 1 hat gewonnen");
                    break;
                }
                bool unentschieden = Unentschieden(twoDArray);
                if (unentschieden)
                {
                    Console.WriteLine("Das Spiel ist unentschieden");
                    break;
                }

                Console.WriteLine("Spieler 2 ist dran");
                Console.WriteLine("Welche Zeile von 0-2 soll geändert werden?");
                int zeile1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Welche Spalte von 0-2 soll geändert werden?");
                int spalte1 = Convert.ToInt32(Console.ReadLine());
                twoDArray[zeile1, spalte1] = 2;
                Console.WriteLine("Das aktualisierte Feld:");
                Console.Clear();
                for (int y = 0; y < twoDArray.GetLength(0); y++)
                {
                    for (int x = 0; x < twoDArray.GetLength(1); x++)
                    {
                        Console.Write(twoDArray[y, x] + " ");
                    }
                    Console.WriteLine();
                }
                bool winner2 = TicTacToeWinner2(twoDArray);
                if (winner2)
                {
                    Console.WriteLine("Spieler 2 hat gewonnen");
                    break;
                }
            }
        }
        public static bool TicTacToeWinner1(int[,] spielfeld)
        {
            for (int y = 0; y < 3; y++)
            {
                if (spielfeld[y, 0] == 1 && spielfeld[y, 1] == 1 && spielfeld[y, 2] == 1)
                {
                    return true;
                }
            }
            for (int x = 0; x < 3; x++)
            {
                if (spielfeld[0, x] == 1 && spielfeld[1, x] == 1 && spielfeld[2, x] == 1)
                {
                    return true;
                }
            }
            if (spielfeld[0, 0] == 1 && spielfeld[1, 1] == 1 && spielfeld[2, 2] == 1)
            {
                return true;
            }
            if (spielfeld[0, 2] == 1 && spielfeld[1, 1] == 1 && spielfeld[2, 0] == 1)
            {
                return true;
            }

            return false;
        }
        public static bool TicTacToeWinner2(int[,] spielfeld)
        {
            for (int y = 0; y < 3; y++)
            {
                if (spielfeld[y, 0] == 2 && spielfeld[y, 1] == 2 && spielfeld[y, 2] == 2)
                {
                    return true;
                }
            }
            for (int x = 0; x < 3; x++)
            {
                if (spielfeld[0, x] == 2 && spielfeld[1, x] == 2 && spielfeld[2, x] == 2)
                {
                    return true;
                }
            }
            if (spielfeld[0, 0] == 2 && spielfeld[1, 1] == 2 && spielfeld[2, 2] == 2)
            {
                return true;
            }
            if (spielfeld[0, 2] == 2 && spielfeld[1, 1] == 2 && spielfeld[2, 0] == 2)
            {
                return true;
            }

            return false;
        }
        public static bool Unentschieden(int[,] spielfeld)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (spielfeld[y, x] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}