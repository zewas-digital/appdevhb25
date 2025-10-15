using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe35
{

    public class TicTacToe
    {
        public static int row;
        public static int column;


        public static void StartTicTacToe()
        {
            Console.WriteLine("----------Aufgabe 35----------");

            int[,] ticTacToeField = new int[3, 3];

            bool validInput;
            int turnsLeft = 9;
            bool endGame = false;
            bool win;

            do
            {
                do
                {
                    System.Console.WriteLine("Spieler 1 ist dran: In welchem Feld willst du eine 1 setzen? (Felder erst von links nach rechs dann von oben nach unten nummeriert)");
                    checkInput();
                    if (ticTacToeField[row, column] == 0)
                    {
                        validInput = true;
                        ticTacToeField[row, column] = 1;
                    }
                    else
                    {
                        validInput = false;
                        System.Console.WriteLine("Dieses Feld ist bereits belegt!");
                        Helper.Print2DArrayInteger(ticTacToeField);
                    }

                } while (!validInput);

                Helper.Print2DArrayInteger(ticTacToeField);
                turnsLeft--;
                win = checkWin(ticTacToeField);


                if (win)
                {
                    System.Console.WriteLine("Spieler 1 hat gewonnen!");
                    return;
                }
                else if (!win && turnsLeft == 0)
                {
                    System.Console.WriteLine("Unentschieden!");
                    return;
                }

                do
                {
                    System.Console.WriteLine("Spieler 2 ist dran: In welchem Feld willst du eine 2 setzen? (Felder erst von links nach rechs dann von oben nach unten nummeriert)");
                    checkInput();

                    if (ticTacToeField[row, column] == 0)
                    {
                        validInput = true;
                        ticTacToeField[row, column] = 2;
                    }
                    else
                    {
                        validInput = false;
                        System.Console.WriteLine("Dieses Feld ist bereits belegt!");
                        Helper.Print2DArrayInteger(ticTacToeField);
                    }

                } while (!validInput);

                Helper.Print2DArrayInteger(ticTacToeField);
                win = checkWin(ticTacToeField);
                turnsLeft--;

                if (win)
                {
                    System.Console.WriteLine("Spieler 2 hat gewonnen!");
                    return;
                }
                else if (!win && turnsLeft == 0)
                {
                    System.Console.WriteLine("Unentschieden!");
                    return;
                }

            } while (!endGame);

        }
        public static bool checkWin(int[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (j == 2)
                    {
                        return true;
                    }
                    if (field[i, j] != field[i, j + 1] || field[i, j] == 0)
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < field.GetLength(1); i++)
            {
                for (int j = 0; j < field.GetLength(0); j++)
                {
                    if (j == 2)
                    {
                        return true;
                    }
                    if (field[j, i] != field[j + 1, i] || field[j, i] == 0)
                    {
                        break;
                    }
                }
            }

            if (field[0, 0] == field[1, 1] && field[0, 0] == field[2, 2] && field[1, 1] != 0)
            {
                return true;
            }
            else if (field[0, 2] == field[1, 1] && field[0, 2] == field[2, 0] && field[1, 1] != 0)
            {
                return true;
            }
            else { return false; }
        }
       

        public static int checkInput()
        {
            bool checkInput;
            int result;
            do
            {
                checkInput = int.TryParse(Console.ReadLine(), out result);
                if (result < 1 || result > 9)
                {
                    checkInput = false;
                }
                if (checkInput == false)
                {
                    Console.WriteLine("Bitte nur Ganzzahlen eingeben zwischen 1 und 9 eingeben!");
                }

            } while (checkInput == false);

            switch (result)
            {
                case 1:
                    row = 0;
                    column = 0;
                    break;
                case 2:
                    row = 0;
                    column = 1;
                    break;
                case 3:
                    row = 0;
                    column = 2;
                    break;
                case 4:
                    row = 1;
                    column = 0;
                    break;
                case 5:
                    row = 1;
                    column = 1;
                    break;
                case 6:
                    row = 1;
                    column = 2;
                    break;
                case 7:
                    row = 2;
                    column = 0;
                    break;
                case 8:
                    row = 2;
                    column = 1;
                    break;
                case 9:
                    row = 2;
                    column = 2;
                    break;
            }

            return result;
        }   
            
    }
}
