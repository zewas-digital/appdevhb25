using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Appdevhb25.JulianMatt.Aufgabe01;

namespace Appdevhb25.JulianMatt.Bonusaufgabe40
{
    public class FourInRows
    {

        public static void BonusStart40()
        {
            string[,] mainArray = Arraycreator();
            Print(mainArray);
            PlayTheGame(mainArray);
        }

        public static string[,] Arraycreator()
        {

            string[,] mainArray = new string[7, 6];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    mainArray[i, j] = "[ ]";
                }

            }
            return mainArray;
        }

        public static void Print(string[,] mainArray)
        {
            Console.WriteLine(" 1   2   3   4   5   6 ");
            for (int j = 0; j < mainArray.GetLength(0); j++)
            {

                for (int i = 0; i < mainArray.GetLength(1); i++)
                {
                    Console.Write(mainArray[j, i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
        }

        public static void PlayTheGame(string[,] mainArray)
        {
            Console.WriteLine("Das Spiel beginnt:");
            Console.WriteLine("Entscheiden sie wer spieler X und wer spieler O ist: ");
            Console.WriteLine("Um dieses Spiel zu spielen nenen sie die Koordinaten die oben und an den seiten stehen und dan wir ihr symbol da plaziert ");
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
