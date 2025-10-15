using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SheilaMayJaro.Aufgabe39
{
    public class TicTacToe
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 39)");
            //  1. Aufgabe lesen und verstehen
            //   2. Offene Fragen klären (TicTacToe ist ein langweiliges Spiel.)
            //   3. Implementierung, in Teilprobleme zerlegen und diese nacheinander lösen
            //   3.1. Welcher Spieler ist an der Reihe?
            //   3.2. Was passiert bei Unentschieden? 
            //   3.3. Wie erkenne ich, ob jemand gewonnen hat?
            //   3.4. Ausgabe vom Spielfeld
            //   3.5. Speicherung vom Spielfeld
            //   3.6. Koordinaten einlesen

                    /*
                    3.1. Wir verwenden einen Counter, der die Runden mitzählt. 
                     Wenn dieser durch 2 teilbar ist, dann ist Spieler 2 an der Reihe. 
                     Wenn ein Rest übrig bleibt, ist Spieler 1 an der Reihe.
                    */

            int[,] playground = new int[3, 3];
            int roundCounter = 1;
            int validRoundsCounter = 0;

            /*
            3.4. Spielfeld ausgeben
            */

            while (validRoundsCounter < 9) //while loop --> sobald eine Runde fertig ist, soll es sich wiederholen + Abbruchbedingung bei gültigen Runden bis exklusive 9
            {
                for (int y = 0; y < playground.GetLength(0); y++)
                {
                    for (int x = 0; x < playground.GetLength(1); x++)
                    {
                        Console.Write(" " + playground[y, x] + " "); // es wird in derselben Zeile geschrieben, daher nur Console.Write(); OHNE das Line
                    }
                    Console.WriteLine(); // da die Zeile erst hier fertig geschrieben ist, kommt hier Console.WriteLINE(); 
                }

                //3.6. Zwei Koordinaten von der Konsole einlesen lassen 
                //Herausfinden, welcher Spieler an der Reihe ist
                if (roundCounter % 2 == 0)
                {
                    System.Console.WriteLine("Spieler 2 ist an der Reihe.");
                }
                else
                {
                    System.Console.WriteLine("Spieler 1 ist an der Reihe.");
                }

                //UserInput
                Console.WriteLine("Bitte gib eine y-Koordinate ein.");
                string temp = Console.ReadLine();
                int yUserInput = Convert.ToInt32(temp);

                Console.WriteLine("Bitte gib eine x-Koordinate ein.");
                int xUserInput = Convert.ToInt32(Console.ReadLine());

                //Errorhandling, wenn der User eine Zahl eingibt, die außerhalb der Grenzen ist 
                if (yUserInput < 0 || yUserInput > 3)
                {
                    System.Console.WriteLine("Bitte gib einen Wert zwischen 0 und 2 ein.");
                }
                else if (xUserInput < 0 || xUserInput > 3)
                {
                    System.Console.WriteLine("Bitte gib einen Wert zwischen 0 und 2 ein.");
                }
                else if (playground[yUserInput, xUserInput] == 0) //Prüfen, ob das Feld noch frei ist 
                {
                    validRoundsCounter++; //da das Feld frei ist, ist es eine gültige Runde
                    if (roundCounter % 2 == 0)
                    {
                        playground[yUserInput, xUserInput] = 2; //Spieler 2
                    }
                    else
                    {
                        playground[yUserInput, xUserInput] = 1; //Spieler 1
                    }

                    /*
                    3.3. Prüfen, ob jemand gewonnen hat
                    3 gleiche Zeichen in einer Zeile
                    3 gleche Zeichen in einer Spalte
                    3 gleiche Zeichen diagonal
                    */

                    //Prüfung, ob 3 gleiche Zeichen in einer Zeile sind 
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
                    }
                    //Prüfung, ob 3 gleiche Zeichen in einer Spalte sind 
                    for (int x = 0; x < playground.GetLength(0); x++)
                    {
                        if (playground[0, x] == 1 && playground[1, x] == 1 && playground[2, x] == 1)
                        {
                            System.Console.WriteLine("Spieler 1 hat gewonnen.");
                            validRoundsCounter = 10;
                        }
                        else if (playground[0, x] == 2 && playground[1, x] == 2 && playground[2, x] == 2)
                        {
                            System.Console.WriteLine("Spieler 2 hat gewonnen.");
                            validRoundsCounter = 10;
                        }
                    }

                    // Prüfen, ob diagonal (links oben nach rechts unten) 3 gleiche Zeichen sind
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
                    //Prüfen, ob diagonal (rechts oben nach links unten) 3 gleiche Zeichen sind 
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
                    System.Console.WriteLine("Das Feld ist bereits besetzt.");
                }

                roundCounter++;
            }
            if (validRoundsCounter == 10) //wenn einer gewonnen hat, entspricht der validRoundsCounter 10
            {
                System.Console.WriteLine("Spiel ist beendet.");
            }
            else
            {
                System.Console.WriteLine("Das Spiel ist beendet. Keiner hat gewonnen."); //wenn unentschieden ist
            }
        }
    }
}
