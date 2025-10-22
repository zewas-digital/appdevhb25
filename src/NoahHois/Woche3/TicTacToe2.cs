using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Appdevhb25.NoahHois.Aufgabe1;

namespace Appdevhb25.NoahHois.Aufgabe30
{
    public class TicTacToe2
    {
        public static void Start()
        {
            string[,] mainArray = Arraycreator();
            Print(mainArray);
            PlayTheGame(mainArray);
        }

        public static string[,] Arraycreator()
        {

            string[,] mainArray = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mainArray[i, j] = "[ ]";
                }

            }
            return mainArray;
        }

        public static void Print(string[,] mainArray)
        {
            Console.WriteLine("     0   1   2   X ");
            for (int j = 0; j < mainArray.GetLength(0); j++)
            {
                Console.Write(" " + (j) + "  ");
                for (int i = 0; i < mainArray.GetLength(1); i++)
                {
                    Console.Write(mainArray[j, i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" Y");
        }

        public static void PlayTheGame(string[,] mainArray)
        {
            Console.WriteLine("Das Spiel beginnt:");
            Console.WriteLine("Entscheiden sie wer spieler X und wer spieler O ist: ");
            Console.WriteLine("Um dieses Spiel zu spielen nennen sie die Koordinaten die oben und an den seiten stehen und dan wir ihr symbol da plaziert ");
            bool playerChange = false;
            while (true)
            {
                if (playerChange == false)
                {
                    Console.WriteLine("Spieler X ist drann");
                    Console.Write("X Spalte Zahl:");
                    int Y = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Y Zeilen Zahl:");
                    int X = Convert.ToInt32(Console.ReadLine());
                    mainArray[X, Y] = "[X]";
                    playerChange = true;
                }
                else if (playerChange == true)
                {
                    Console.WriteLine("Spieler O ist drann");
                    Console.Write("X Spalte Zahl:");
                    int Y = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Y Zeilen Zahl:");
                    int X = Convert.ToInt32(Console.ReadLine());
                    mainArray[X, Y] = "[O]";
                    playerChange = false;
                }

                Console.Clear();
                Print(mainArray);
                if (CheckWinner(mainArray))
                {
                    Console.Write("Der Spieler ");
                    if (playerChange == false)
                    {
                        Console.WriteLine(" O hat gewonnen");
                    }
                    if (playerChange == true)
                    {
                        Console.WriteLine(" X hat gewonnen");
                    }
                    break;
                }
            }
        }

        public static bool CheckWinner(string[,] mainArray)
        {
            bool winner = false;
            for (int i = 0; i < 3; i++)
            {
                if (mainArray[i, 0] == "[X]" && mainArray[i, 1] == "[X]" && mainArray[i, 2] == "[X]" || mainArray[i, 0] == "[O]" && mainArray[i, 1] == "[O]" && mainArray[i, 2] == "[O]")
                {
                    winner = true;
                }
                if (mainArray[0, i] == "[X]" && mainArray[1, i] == "[X]" && mainArray[2, i] == "[X]" || mainArray[0, i] == "[O]" && mainArray[1, i] == "[O]" && mainArray[2, i] == "[O]")
                {
                    winner = true;
                }
            }

            if (mainArray[0, 0] == "[X]" && mainArray[1, 1] == "[X]" && mainArray[2, 2] == "[X]" || mainArray[0, 2] == "[O]" && mainArray[1, 1] == "[O]" && mainArray[2, 0] == "[O]")
            {
                winner = true;
            }
            if (mainArray[0, 0] == "[O]" && mainArray[1, 1] == "[O]" && mainArray[2, 2] == "[O]" || mainArray[0, 2] == "[X]" && mainArray[1, 1] == "[X]" && mainArray[2, 0] == "[X]")
            {
                winner = true;
            }
            return winner;
        }
    }
}