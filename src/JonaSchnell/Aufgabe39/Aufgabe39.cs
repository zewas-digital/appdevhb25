using System.Runtime.CompilerServices;

namespace Appdevhb25.JonaSchnell.Aufgabe39
{
    public class Aufgabe39
    {


        public static void Start39()
        {
            int[,] playground = new int[3, 3] { { 0, 1, 1 }, { 0, 0, 0 }, { 0, 0, 0 } };
            int roundCounter = 1;
            int validRoundsCounter = 0;
            //Spielfeld
            while (validRoundsCounter < 9)
            {
                for (int y = 0; y < playground.GetLength(0); y++)
                {
                    for (int x = 0; x < playground.GetLength(1); x++)
                    {
                        System.Console.Write(" " + playground[y, x] + " ");
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
                string? tmp = Console.ReadLine();
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
                //Feld frei?
                else if (playground[yUserInput, xUserInput] == 0)
                {
                    validRoundsCounter++;
                    if (roundCounter % 2 == 0)
                    {
                        playground[yUserInput, xUserInput] = 2;
                    }
                    else
                    {
                        playground[yUserInput, xUserInput] = 1;
                    }
                    //Gewinner
                    for (int y = 0; y < playground.GetLength(0); y++)
                    {
                        if (playground[y, 0] == 1 && playground[y, 1] == 1 && playground[y, 2] == 1)
                        {
                            System.Console.WriteLine("Spieler 1 hat gewonnen.");
                            validRoundsCounter = 10;
                        }
                        else if (playground[y, 0] == 2 && playground[y, 1] == 2 && playground[y, 2] == 2)
                        {
                            System.Console.WriteLine("Spieler 2 hat gewonnen.");
                            validRoundsCounter = 10;
                        }
                        if (playground[0, y] == 1 && playground[1, y] == 1 && playground[2, y] == 1)
                        {
                            System.Console.WriteLine("Spieler 1 hat gewonnen.");
                            validRoundsCounter = 10;
                        }
                        else if (playground[0, y] == 1 && playground[1, y] == 1 && playground[2, y] == 1)
                        {
                            System.Console.WriteLine("Spieler 2 hat gewonnen.");
                            validRoundsCounter = 10;
                        }
                    }

                    //Diagonal Gewinner
                    if (playground[0, 0] == 1 && playground[1, 1] == 1 && playground[2, 2] == 1)
                    {
                        System.Console.WriteLine("Spieler 1 hat gewonnen.");
                        validRoundsCounter = 10;
                    }
                    else if (playground[0, 0] == 2 && playground[1, 1] == 2 && playground[2, 2] == 2)
                    {
                        System.Console.WriteLine("Spieler 2 hat gewonnen.");
                        validRoundsCounter = 10;
                    }
                    //Oben nach unten Gewinner
                    else if (playground[0, 2] == 1 && playground[1, 1] == 1 && playground[2, 0] == 1)
                    {
                        System.Console.WriteLine("Spieler 1 hat gewonnen.");
                        validRoundsCounter = 10;
                    }
                    else if (playground[0, 2] == 2 && playground[1, 1] == 2 && playground[2, 0] == 2)
                    {
                        System.Console.WriteLine("Spieler 2 hat gewonnen.");
                        validRoundsCounter = 10;
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
                System.Console.WriteLine("Das Spiel ist beendet. Keiner hat gewonnen.");
            }
        }
    }
}