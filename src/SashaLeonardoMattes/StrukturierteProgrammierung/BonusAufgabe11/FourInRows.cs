using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe11
{

    public class FourInRows
    {
        public static int row;
        public static int column;
        public static int turnsLeft = 42;



        public static void StartFourInRows()
        {
            Console.WriteLine("----------Bonusaufgabe 11----------");

            int[,] playField = new int[6, 7];

            bool validInput = false;
            bool win;

            do
            {
                do
                {
                    System.Console.WriteLine("Spieler 1 ist dran: In welche Spalte willst du eine 1 setzen? (von links nach rechts 1-7)");
                    column = checkInput();

                    for (int row = playField.GetLength(0) - 1; row > -1; row--)
                    {
                        if (playField[0, column] != 0)
                        { 
                            System.Console.WriteLine("Diese Spalte ist voll. Bitte wähle eine andere Spalte!");
                            validInput = false;
                            break;
                        }
                        else if (playField[row, column] == 0)
                        {
                            validInput = true;
                            playField[row, column] = 1;
                            break; //du bist nutzlos
                        }
                    }
                } while (validInput == false);

                Console.Clear();
                Helper.Print2DArrayInteger(playField);
                turnsLeft--;
                win = checkWin(playField);

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
                    System.Console.WriteLine("Spieler 2 ist dran: In welche Spalte willst du eine 2 setzen? (von links nach rechts 1-7)");
                    column = checkInput();

                    for (int row = playField.GetLength(0) - 1; row > -1; row--)
                    {
                        if (playField[0, column] != 0)
                        {
                            System.Console.WriteLine("Diese Spalte ist voll. Bitte wähle eine andere Spalte!");
                            validInput = false;
                            break;
                        }
                        else if (playField[row, column] == 0)
                        {
                            validInput = true;
                            playField[row, column] = 2;
                            break; //du bist nutzlos
                        }
                    }
                } while (validInput == false);

                Console.Clear();
                Helper.Print2DArrayInteger(playField);
                turnsLeft--;
                win = checkWin(playField);

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

            } while (!win);

        }
        public static bool checkWin(int[,] field)
        {
            if (turnsLeft > 42 - 7)
            {
                return false;
            }

            if (checkWinRow(field))
            {
                System.Console.WriteLine("Sieg durch Row");
                return true;
            }

            if (checkWinCol(field))
            {
                System.Console.WriteLine("Sieg durch Col");
                return true;
            }
            if (checkWinDiagonal(field))
            {
                System.Console.WriteLine("Sieg durch Dia");
                return true;
            }

            return false; //dass er nicht heult

        }

        public static bool checkWinRow(int[,] field)
        {
            int inRowPlayer1;
            int inRowPlayer2;
            
            for (int i = 0; i < field.GetLength(0); i++)
            {
                inRowPlayer1 = 0;
                inRowPlayer2 = 0;
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == 1)
                    {
                        inRowPlayer1++;
                        if (inRowPlayer1 == 4)
                        {
                            return true;
                        }
                        inRowPlayer2 = 0;
                    }
                    else if (field[i, j] == 2)
                    {
                        inRowPlayer2++;
                        if (inRowPlayer2 == 4)
                        {
                            return true;
                        }
                        inRowPlayer1 = 0;
                    }
                    else
                    {
                        inRowPlayer1 = 0;
                        inRowPlayer2 = 0;
                    }
                }
            }
            return false;
        }

        public static bool checkWinCol(int[,] field)
        {
            int inColPlayer1;
            int inColPlayer2;

            for (int i = 0; i < field.GetLength(1); i++)
            {
                inColPlayer1 = 0;
                inColPlayer2 = 0;
                for (int j = 0; j < field.GetLength(0); j++)
                {
                    if (field[j, i] == 1)
                    {
                        inColPlayer1++;
                        if (inColPlayer1 == 4)
                        {
                            return true;
                        }
                        inColPlayer2 = 0;
                    }
                    else if (field[j, i] == 2)
                    {
                        inColPlayer2++;
                        if (inColPlayer2 == 4)
                        {
                            return true;
                        }
                        inColPlayer1 = 0;
                    }
                    else
                    {
                        inColPlayer1 = 0;
                        inColPlayer2 = 0;
                    }
                }
            }
            return false;
        }

        public static bool checkWinDiagonal(int[,] field)
        {
            int inDiagonalPlayer1;
            int inDiagonalPlayer2;

            int diagnoal = 6;
            int col;



            //von Spalte 0-3 nach rechts diagonal
            for (int startCol = 0; startCol < 4; startCol++) //ab spalte 4 sind 4 diagnoal nach rechts unten nicht mehr möglich
            {
                if (startCol > 1) //spalte 0 und 1 sind 6 felder diagonal nach rechts unten möglich danach je 1 weniger
                {
                    diagnoal--;
                }

                col = startCol;
                inDiagonalPlayer1 = 0;
                inDiagonalPlayer2 = 0;
                for (int row = 0; row < diagnoal; row++)
                {
                    if (field[row, col] == 1)
                    {
                        inDiagonalPlayer1++;
                        if (inDiagonalPlayer1 == 4)
                        {
                            return true;
                        }
                        inDiagonalPlayer2 = 0;
                    }
                    else if (field[row, col] == 2)
                    {
                        inDiagonalPlayer2++;
                        if (inDiagonalPlayer2 == 4)
                        {
                            return true;
                        }
                        inDiagonalPlayer1 = 0;
                    }
                    else
                    {
                        inDiagonalPlayer1 = 0;
                        inDiagonalPlayer2 = 0;
                    }
                    col++;
                }
            }


            //von zeile 1-2 nach rechts diagonal
            for (int startRow = 1; startRow < 3; startRow++) //start bei 1 weil 0 vorher schon kontrolliert wurde //3 weil ab Zeile 3 nicht mehr 4 diagonal nach rechts unten möglich sind
            {
                diagnoal = 6;

                inDiagonalPlayer1 = 0;
                inDiagonalPlayer2 = 0;
                col = 0;
                for (int rowToCheckDia = startRow; rowToCheckDia < diagnoal; rowToCheckDia++)
                {
                    if (field[rowToCheckDia, col] == 1)
                    {
                        inDiagonalPlayer1++;
                        if (inDiagonalPlayer1 == 4)
                        {
                            return true;
                        }
                        inDiagonalPlayer2 = 0;
                    }
                    else if (field[rowToCheckDia, col] == 2)
                    {
                        inDiagonalPlayer2++;
                        if (inDiagonalPlayer2 == 4)
                        {
                            return true;
                        }
                        inDiagonalPlayer1 = 0;
                    }
                    else
                    {
                        inDiagonalPlayer1 = 0;
                        inDiagonalPlayer2 = 0;
                    }
                    col++;
                }
            }

            //Spalten 6-3 nach links
            for (int startCol = 6; startCol > 2; startCol--) //ab spalte 4 sind 4 diagnoal nach rechts unten nicht mehr möglich
            {
                if (startCol < 5) //spalte 0 und 1 sind 6 felder diagonal nach rechts unten möglich danach je 1 weniger
                {
                    diagnoal--;
                }

                col = startCol;
                inDiagonalPlayer1 = 0;
                inDiagonalPlayer2 = 0;
                for (int row = 0; row < diagnoal; row++)
                {
                    if (field[row, col] == 1)
                    {
                        inDiagonalPlayer1++;
                        if (inDiagonalPlayer1 == 4)
                        {
                            return true;
                        }
                        inDiagonalPlayer2 = 0;
                    }
                    else if (field[row, col] == 2)
                    {
                        inDiagonalPlayer2++;
                        if (inDiagonalPlayer2 == 4)
                        {
                            return true;
                        }
                        inDiagonalPlayer1 = 0;
                    }
                    else
                    {
                        inDiagonalPlayer1 = 0;
                        inDiagonalPlayer2 = 0;
                    }
                    col--;
                }
            }
            
             //von zeile 1-2 nach links diagonal
            for (int startRow = 1; startRow < 3; startRow++) //start bei 1 weil 0 vorher schon kontrolliert wurde //3 weil ab Zeile 3 nicht mehr 4 diagonal nach rechts unten möglich sind
            {
                diagnoal = 6;

                inDiagonalPlayer1 = 0;
                inDiagonalPlayer2 = 0;
                col = 6;
                for (int rowToCheckDia = startRow; rowToCheckDia < diagnoal; rowToCheckDia++)
                {
                    if (field[rowToCheckDia, col] == 1)
                    {
                        inDiagonalPlayer1++;
                        if (inDiagonalPlayer1 == 4)
                        {
                            return true;
                        }
                        inDiagonalPlayer2 = 0;
                    }
                    else if (field[rowToCheckDia, col] == 2)
                    {
                        inDiagonalPlayer2++;
                        if (inDiagonalPlayer2 == 4)
                        {
                            return true;
                        }
                        inDiagonalPlayer1 = 0;
                    }
                    else
                    {
                        inDiagonalPlayer1 = 0;
                        inDiagonalPlayer2 = 0;
                    }
                    col--;
                }
            }
            return false;
        }


        public static int checkInput()
        {
            bool checkInput;
            int result;

            do
            {
                checkInput = int.TryParse(Console.ReadLine(), out result);
                if (result < 1 || result > 7)
                {
                    checkInput = false;
                }
                if (checkInput == false)
                {
                    Console.WriteLine("Bitte nur Ganzzahlen eingeben zwischen 1 und 7 eingeben!");
                }

            } while (checkInput == false);

            return result - 1; //Spalte 1-7 = Index 0-6
        }



    }
}
