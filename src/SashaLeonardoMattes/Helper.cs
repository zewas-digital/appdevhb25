using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
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
                    Console.WriteLine("Deine Eingabe war ungültig. Bitte keine Zahlen eingeben!");
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

        public static void Print2DArrayAsTable(string[,] arr, int[]colSizes)
        {
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == arr.GetLength(1) - 1)
                    {
                        System.Console.Write("{0,-" + colSizes[j] + "}", arr[i, j]); //wenn wir in der letzten Spalte sind kein " |" sondern "" 
                    }
                    else
                    {
                        System.Console.Write("{0,-" + colSizes[j] + "} |", arr[i, j]); //- nach 0 macht linksbündig statt rechtsbündig
                    }
                }
                System.Console.WriteLine();

                if (i != arr.GetLength(0)-1 -1) //nur wenn wir nicht in der letzten Zeile sind Trennstrich
                {
                    System.Console.WriteLine(new string('-', colSizes.Sum() + (colSizes.Length-1)*2)); //schreibt so viele "-" wie gesamte Spaltenbreite + pro Zeile 2 extra fpr leerzeichen und "|"
                }
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

        public static DateTime checkUserInputDate()
        {
            bool checkInput;
            DateTime result;
            string format = "dd.MM.yyyy";
            do
            {
                checkInput = DateTime.TryParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture, DateTimeStyles.None, out result);

                if (checkInput == false)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte benutze das Format dd.MM.yyyy");
                }
            } while (checkInput == false);

            return result;
        }
    
        public static void WriteHyphen(Type callerType)
        {
            string hyphen = new string('-', 15);
            string? exercise = callerType?.Namespace?.Substring(31);
            Console.WriteLine($"\n\n{hyphen}{exercise}{hyphen}\n");
        }
    
    }
}

