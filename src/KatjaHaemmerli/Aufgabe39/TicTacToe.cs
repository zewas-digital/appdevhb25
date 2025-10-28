using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe39
{
    public  class TicTacToeSpel
    {
        // Ausgabe Spielfeld 3 Zeilen und 3 Spalten
                public static void SpielfeldZeichnen(int[,] p)
                {
                    for (int y = 0; y < p.GetLength(0); y++)
                    {
                        for (int x = 0; x < p.GetLength(1); x++)
                        {
                            Console.Write(" " + p[y, x] + " "); // Output: alles Nullen, da Standartwert von einem Array 0.
                        }
                        Console.WriteLine();
                    }                    
                }
        public static void TicTacToe()
        {
            /*Ablauf:
            - Spielfeld
            Spiel:
            - Welcher Spieler ist an der Reihe? Und Eingabe Koordinaten (userInput)
            - Wie erkenne ich das Jemand gewonnen hat? / Was wenn unentschieden?
            - Spielfeld Ausgabe
            - Koordinaten einlesen (vom userInput)
            */

            int roundCounter = 0;
            // Spielfeld 3*3
            // int[,] playground = new int[3, 3] { { 0, 1, 1 }, { 0, 0, 0 }, { 0, 0, 0 } }; // zum austesten bereits 2 werte gesetzt
            //int[,] playground = new int[3, 3] { { 2, 1, 1 }, {1, 1, 2}, {2, 2, 0}}; // zum austesten von keiner hat gewonnen
            //int[,] playground = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 2 }, { 0, 0, 2 } }; // zum austesten bereits 2 werte gesetzt
            int[,] playground = new int[3, 3];

            // Spiel
            while (roundCounter < 9)
            {
                SpielfeldZeichnen(playground);
                 // Welcher Spieler ist an der Reihe? //Counter: Wenn Zahl durch 2 teilbar: Spieler 2 ist and der Reihe sonst Spieler 1.
                 if (roundCounter % 2 == 0)
                    {
                        Console.WriteLine("Turn: Player 1");                        
                    }
                    else
                    {
                        Console.WriteLine("Turn: Player 2");                        
                    }

                // Koordinaten-Eingabe
                Console.WriteLine("Pls enter your y - coordinates. (between 0 and 2)");
                int yUserInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Now pls enter your x - coordinates. (between 0 and 2)");
                int xUserInput = Convert.ToInt32(Console.ReadLine());

                // Prüfen, ob das Feld noch frei ist
                if (playground[yUserInput, xUserInput] == 0) // bei koordinaten 0,0 ist das Feld noch frei
                {
                    if (roundCounter % 2 == 0)
                    {                        
                        playground[yUserInput, xUserInput] = 1;
                    }
                    else
                    {                        
                        playground[yUserInput, xUserInput] = 2;
                    }

                    // Prüfung wer gewonen hat: 3 gleiche Zeichen in einer Reihe
                    
                    for (int y = 0; y < playground.GetLength(0); y++) // prüfen ob in einer Zeile 3 mal die gleiche Zahl ist
                    {
                        if (playground[y, 0] == 1 && playground[y, 1] == 1 && playground[y, 2] == 1)
                        {
                            Console.WriteLine("Player 1 wins!");
                            roundCounter = 10; // roundCounter auf 10 setztem um Spiel zu beenden
                        }
                        else if (playground[y, 0] == 2 && playground[y, 1] == 2 && playground[y, 2] == 2)
                        {
                            Console.WriteLine("Player 2 wins!");
                            roundCounter = 10;
                        }
                    }
                    for (int x = 0; x < playground.GetLength(1); x++) // prüfen ob in einer Spalte 3 mal die gleiche Zahl ist
                    {
                        if (playground[0, x] == 1 && playground[1, x] == 1 && playground[2, x] == 1)
                        {
                            Console.WriteLine("Player 1 wins!");
                            roundCounter = 10;
                        }
                        else if (playground[0, x] == 2 && playground[1, x] == 2 && playground[2, x] == 2)
                        {
                            Console.WriteLine("Player 2 wins!");
                            roundCounter = 10;
                        }

                    }

                    // prüfen ob 3 diagonal links oben nach rechts unten 
                    
                        if (playground[0, 0] == 1 && playground[1, 1] == 1 && playground[2, 2] == 1)
                        {
                            Console.WriteLine("Player 1 wins!");
                            roundCounter = 10;
                        }
                        else if (playground[0, 0] == 2 && playground[1, 1] == 2 && playground[2, 2] == 2)
                        {
                            Console.WriteLine("Player 2 wins!");
                            roundCounter = 10;                            
                        }
                   

                    // prüfen ob 3 diagonal rechts oben nach links unten
                   
                        if (playground[0, 2] == 1 && playground[1, 1] == 1 && playground[2, 0] == 1)
                        {
                            Console.WriteLine("Player 1 wins!");
                            roundCounter = 10;                            
                        }
                        else if (playground[0, 2] == 2 && playground[1, 1] == 2 && playground[2, 0] == 2)
                        {
                            Console.WriteLine("Player 2 wins!");
                            roundCounter = 10;                           
                        }
                    
                roundCounter++; // Spielerwechsel nur wenn kein belegtes Feld gewählt
                }
                else
                {
                    Console.WriteLine("Pls enter other coordinates. Field is already taken.");
                }

            }
            SpielfeldZeichnen(playground);            

            if (roundCounter == 11)
            {
                Console.WriteLine("Game over. Nobody won.");                           
            }
            else // noch nicht alle Felder besetzt aber 3 gleiche in einer Reihe: aus der Spiel-Schleife raus
            {
                // Jemand hat gewonnen
                Console.WriteLine("Game over.");
            }
        }
    }
}