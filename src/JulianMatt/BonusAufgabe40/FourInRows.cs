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
            int row1 = 6;
            int row2 = 6;
            int row3 = 6;
            int row4 = 6;
            int row5 = 6;
            int row6 = 6;

            int lastRow = 0;
            int lastColum = 0;

            bool playerChange = false;
            while (true)
            {

                if (playerChange == false)
                {
                    Console.WriteLine("Spieler X ist drann");
                    Console.Write("Welche Spalte Wählen sie aus?");
                    int Y = Convert.ToInt32(Console.ReadLine());
                    if (Y == 1)
                    {
                        mainArray[row1, 0] = "[X]";
                        lastColum = 0;
                        lastRow = row1;
                        row1 -= 1;

                    }
                    if (Y == 2)
                    {
                        mainArray[row2, 1] = "[X]";
                        lastColum = 1;
                        lastRow = row2;
                        row2 -= 1;
                    }
                    if (Y == 3)
                    {
                        mainArray[row3, 2] = "[X]";
                        lastColum = 2;
                        lastRow = row3;
                        row3 -= 1;
                    }
                    if (Y == 4)
                    {
                        mainArray[row4, 3] = "[X]";
                        lastColum = 3;
                        lastRow = row4;
                        row4 -= 1;
                    }
                    if (Y == 5)
                    {
                        mainArray[row5, 4] = "[X]";
                        lastColum = 4;
                        lastRow = row5;
                        row5 -= 1;
                    }
                    if (Y == 6)
                    {
                        mainArray[row6, 5] = "[X]";
                        lastColum = 5;
                        lastRow = row6;
                        row6 -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalide Eingabe sie wollen wohl das ihr gegner gewinnt");
                    }
                    playerChange = true;
                }
                else if (playerChange == true)
                {
                    Console.WriteLine("Spieler O ist drann");
                    Console.Write("Welche Spalte Wählen sie aus?");
                    int Y = Convert.ToInt32(Console.ReadLine());
                    if (Y == 1)
                    {
                        mainArray[row1, 0] = "[O]";
                        lastColum = 0;
                        lastRow = row1;
                        row1 -= 1;
                    }
                    if (Y == 2)
                    {
                        mainArray[row2, 1] = "[O]";
                        lastColum = 1;
                        lastRow = row2;
                        row2 -= 1;
                    }
                    if (Y == 3)
                    {
                        mainArray[row3, 2] = "[O]";
                        lastColum = 2;
                        lastRow = row3;
                        row3 -= 1;
                    }
                    if (Y == 4)
                    {
                        mainArray[row4, 3] = "[O]";
                        lastColum = 3;
                        lastRow = row4;
                        row4 -= 1;
                    }
                    if (Y == 5)
                    {
                        mainArray[row5, 4] = "[O]";
                        lastColum = 4;
                        lastRow = row5;
                        row5 -= 1;
                    }
                    if (Y == 6)
                    {
                        mainArray[row6, 5] = "[O]";
                        lastColum = 5;
                        lastRow = row6;
                        row6 -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalide Eingabe sie wollen wohl das ihr gegner gewinnt");
                    }
                    playerChange = false;
                }

                Console.Clear();
                Print(mainArray);
                if (CheckWinner(mainArray, lastRow, lastColum))
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

        public static bool CheckWinner(string[,] mainArray, int lastRow, int lastColum)
        {
            string symbol = mainArray[lastRow, lastColum];
            if (symbol == "[ ]") return false;
            int count;

            count = 0;
            for (int i = 0; i < mainArray.GetLength(1); i++)
            {
                if (mainArray[lastRow, i] == symbol)
                    count++;
                else
                    count = 0;

                if (count >= 4)
                    return true;
            }

            count = 0;
            for (int i = -3; i < 3; i++)
            {
                if (mainArray[i, lastColum] == symbol)
                    count++;
                else
                    count = 0;

                if (count >= 4)
                    return true;
            }
            return false;
        }





    }
}
