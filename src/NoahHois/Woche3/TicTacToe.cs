using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Transactions;

namespace Appdevhb25.NoahHois.Aufgabe29
{
    public class TicTacToe
    {
        public static void Start29()
        {
            int[,] playingField = new int[3, 3];

            int roundCounter = 1;
            int validRoundsCounter = 0;

            while (validRoundsCounter < 9)
            {

                for (int y = 0; y < playingField.GetLength(0); y++)
                {
                    for (int x = 0; x < playingField.GetLength(1); x++)
                    {
                        System.Console.Write(" " + playingField[y, x] + " ");
                    }
                    Console.WriteLine();
                }

                if (roundCounter % 2 == 0)
                {
                    System.Console.WriteLine("Spieler 2 ist an der Reihe.");
                }
                else
                {
                    System.Console.WriteLine("Spieler 1 ist an der Reihe.");
                }

                System.Console.WriteLine("Gib eine x-Koordinate ein.");
                string tmp = Console.ReadLine();
                int xUserInput = Convert.ToInt32(tmp);

                System.Console.WriteLine("Gib eine y-Koordinate ein.");
                int yUserInput = Convert.ToInt32(Console.ReadLine());

                if (xUserInput < 0 || xUserInput > 3)
                {
                    System.Console.WriteLine("Bitte gib einen Wert zwischen 0 und 2 ein.");
                }
                else if (yUserInput < 0 || yUserInput > 3)
                {
                    System.Console.WriteLine("Bitte gib einen Wert zwischen 0 und 2 ein.");
                }

                else if (playingField[yUserInput, xUserInput] == 0)
                {
                    validRoundsCounter++;

                    if (roundCounter % 2 == 0)
                    {
                        playingField[yUserInput, xUserInput] = 2;
                    }
                    else
                    {
                        playingField[yUserInput, xUserInput] = 1;
                    }



                    for (int y = 0; y < playingField.GetLength(0); y++)
                    {
                        if (playingField[y, 0] == 1 && playingField[y, 1] == 1 && playingField[y, 2] == 1)
                        {
                            System.Console.WriteLine("Spieler 1 hat gewonnen.");
                            validRoundsCounter = 10;
                        }
                        else if (playingField[y, 0] == 2 && playingField[y, 1] == 2 && playingField[y, 2] == 2)
                        {
                            System.Console.WriteLine("Spieler 2 hat gewonnen.");
                            validRoundsCounter = 10; ;
                        }
                    }


                    for (int x = 0; x < playingField.GetLength(0); x++)
                    {
                        if (playingField[0, x] == 1 && playingField[1, x] == 1 && playingField[2, x] == 1)
                        {
                            System.Console.WriteLine("Spieler 1 hat gewonnen.");
                            validRoundsCounter = 10; ;
                        }
                        else if (playingField[0, x] == 2 && playingField[1, x] == 2 && playingField[2, x] == 2)
                        {
                            System.Console.WriteLine("Spieler 2 hat gewonnen.");
                            validRoundsCounter = 10; ;
                        }
                    }

                    if (playingField[0, 0] == 1 && playingField[1, 1] == 1 && playingField[2, 2] == 1)
                    {
                        System.Console.WriteLine("Spieler 1 hat gewonnen.");
                        validRoundsCounter = 10; ;
                    }
                    else if (playingField[0, 0] == 2 && playingField[1, 1] == 2 && playingField[2, 2] == 2)
                    {
                        System.Console.WriteLine("Spieler 2 hat gewonnen.");
                        validRoundsCounter = 10; ;
                    }

                    else if (playingField[0, 2] == 1 && playingField[1, 1] == 1 && playingField[2, 0] == 1)
                    {
                        System.Console.WriteLine("Spieler 1 hat gewonnen.");
                        validRoundsCounter = 10; ;
                    }
                    else if (playingField[0, 2] == 2 && playingField[1, 1] == 2 && playingField[2, 0] == 2)
                    {
                        System.Console.WriteLine("Spieler 2 hat gewonnen.");
                        validRoundsCounter = 10; ;
                    }
                }
                else
                {
                    System.Console.WriteLine("Das Feld ist bereits besetzt. ");
                }

                roundCounter++;

            }
            if (validRoundsCounter == 10)
            {
                System.Console.WriteLine("Spiel beendet");
            }
            else
            {
                System.Console.WriteLine("Das Spiel ist beendet. Keiner hat gewonnen.");
            }
        }
    }
}