using System;
using System.ComponentModel.DataAnnotations;
// See https://aka.ms/new-console-template for more information

namespace Appdevhb25.SashaLeonardoMattes
{
    public static class Helper
    {
        public static int checkUserInputInteger()
        {
            bool checkInput;
            int result;
            do
            {
                checkInput = int.TryParse(Console.ReadLine(), out result);

                if (checkInput == false)
                {
                    Console.WriteLine("Bitte nur Ganzzahlen eingeben");
                }
            } while (checkInput == false);

            return result;
        }


        public static char checkUserInputChar()
        {
            bool checkInput;
            char result;
            do
            {
                checkInput = char.TryParse(Console.ReadLine(), out result);

                if (checkInput == false)
                {
                    Console.WriteLine("Bitte nur ein Zeichen eingeben");
                }
            } while (checkInput == false);

            return result;
        }

        public static ulong checkUserInputULong()
        {
            bool checkInput;
            ulong result;
            do
            {
                checkInput = ulong.TryParse(Console.ReadLine(), out result);

                if (checkInput == false)
                {
                    Console.WriteLine("Bitte nur positive Ganzzahlen eingeben");
                }
            } while (checkInput == false);

            return result;
        }

        public static double checkUserInputDouble()
        {
            bool checkInput;
            double result;
            do
            {
                checkInput = double.TryParse(Console.ReadLine(), out result);

                if (checkInput == false)
                {
                    Console.WriteLine("Bitte nur Zahlen eingeben");
                }
            } while (checkInput == false);

            return result;
        }

        public static string checkUserInputString()
        {
            bool checkInput;
            string? result;
            int notRelevant;

            do
            {
                result = Console.ReadLine();
                checkInput = int.TryParse(result, out notRelevant);
                if (checkInput)
                {
                    Console.WriteLine("Bitte gib einen gültigen Namen ein (keine Zahl, weil die Deutschen das leider nicht erlauben und Österreich sieht es auch etwas kritisch) (WICHTIG: Ich fände es ok):");
                }
            } while (checkInput || string.IsNullOrEmpty(result));

            return result;
        }

        public static void Print2DArrayInteger(int[,] arr)
        {
            int maxLength = GetMax2DArray(arr).ToString().Length;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    System.Console.Write("{0," + maxLength + "} ", arr[i, j]);
                    /*0 ist Platzhalter für 0. Variable nach "," also arr[i, j] 
                    maxLenght gibt zu reservierenden Platz an
                    Diesie beiden müssen in geschwungene Klammern
                    Abstand nach geschwungener Klammer ist wichitg --> sonst stehen Zahlen direkt hintereinander 
                    "}", ist also falsch (würde 14 und 3 als 143 ausgeben) für Abstand ziwschen Zahlen "} " (dann wird 14 3 ausgegeben)
                    */
                }
                System.Console.WriteLine();
            }
        }

        public static int GetMax2DArray(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }
    }
}

