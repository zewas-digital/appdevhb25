using System.Diagnostics.CodeAnalysis;

namespace Appdevhb25.KerimAlkis.Bonusaufgabe11
{
    public class FourInRows
    {
        public static void Start()
        {
            int[,] spielfeld = new int[6, 7];

            int spielerwechsel = 0;

            int player = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("==========");
                Console.WriteLine(" 4 in Row \tSpieler 1 --> \"1\" | Spieler 2 --> \"2\"");
                Console.WriteLine("==========\n");
                Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("| 1 | 2 | 3 | 4 | 5 | 6 | 7 |"); Console.ResetColor();
                Console.WriteLine("-----------------------------");
                for (int i = 0; i < spielfeld.GetLength(0); i++)
                {
                    for (int j = 0; j < spielfeld.GetLength(1); j++)
                    {
                        string ausgabe;
                        if (spielfeld[i, j] == 0)
                        {
                            ausgabe = "*";
                        }
                        else { ausgabe = spielfeld[i, j].ToString(); }
                        Console.Write("| " + ausgabe + " ");
                    }
                    Console.Write("|");
                    Console.WriteLine("\n-----------------------------");
                }


                if(spielerwechsel >= 7)
                {
                    int check = Checker(spielfeld);
                    if (check == 3)
                    {
                        System.Console.WriteLine();
                        if (player == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Spieler 1 hat GEWONNEN");
                            Console.ResetColor();
                            break;
                        }
                        else { Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("Spieler 2 hat GEWONNEN"); Console.ResetColor(); break; }
                    }
                }
                

                System.Console.WriteLine();

                
                if (spielerwechsel % 2 == 0)
                {
                    Console.WriteLine("SPIELER 1 ist dran");
                    player = 1;
                    spielerwechsel++;
                }
                else { Console.WriteLine("SPIELER 2 ist dran"); spielerwechsel++; player = 2; }
                System.Console.WriteLine();
                int spalte = SpielbrettAuswahl();


                bool spaltenChecker = false;
                int freieZeile = 0;

                for(int i = spielfeld.GetLength(0) - 1; i >= 0 ; i--)
                {
                    if(spielfeld[i,spalte-1] == 0)
                    {
                        spaltenChecker = true;
                        freieZeile = i;
                        break;
                    }
                }

                if (spaltenChecker == true)
                {
                    spielfeld[freieZeile, spalte - 1] = player;
                }
                else
                {
                    Console.WriteLine("\nDas Feld ist nicht frei"); Console.ReadKey(); spielerwechsel--;
                }

            } while (true);


        }
        public static int SpielbrettAuswahl()
        {
            Console.WriteLine("In welche Spalte willst du reinwerfen");
            Console.Write("Auswahl: ");
            int spalte = 0;
            do
            {
                char inputS = Console.ReadKey(true).KeyChar;
                string temp = inputS.ToString();
                if (int.TryParse(temp, out int spalteninput) && spalteninput >= 1 && spalteninput <= 7)
                {
                    spalte = spalteninput; break;
                }

            } while (true);
            Console.Write(spalte);
            return spalte;
        }
        public static int Checker(int[,] spielfeld)
        {
            //WinConditions Zeile/Horizontal
            for (int i = 0; i < spielfeld.GetLength(0); i++)
            {
                int player1zaehlerZeile = 0;
                int player2zaehlerZeile = 0;
                for (int j = 0; j < spielfeld.GetLength(1); j++)
                {
                    if (spielfeld[i, j] == 1) { player1zaehlerZeile++; }
                    if (spielfeld[i, j] == 2) { player2zaehlerZeile++; }
                    if (spielfeld[i, j] == 0) { player1zaehlerZeile = 0; player2zaehlerZeile = 0; }
                    if (player1zaehlerZeile == 4 || player2zaehlerZeile == 4) { return 3; }
                }
            }

            //WinConditions Spalte/Vertikal
            for (int i = 0; i < spielfeld.GetLength(1); i++)
            {
                int player1zaehlerSpalte = 0;
                int player2zaehlerSpalte = 0;
                for (int j = 0; j < spielfeld.GetLength(0); j++)
                {
                    if (spielfeld[j, i] == 1) { player1zaehlerSpalte++; }
                    if (spielfeld[j, i] == 2) { player2zaehlerSpalte++; }
                    if (spielfeld[j, i] == 0) { player1zaehlerSpalte = 0; player2zaehlerSpalte = 0; }
                    if (player1zaehlerSpalte == 4 || player2zaehlerSpalte == 4) { return 3; }
                }
            }



            //ab hier Windconditions Diagonalle


            int zeile = 0;
            int spalte = 0;
            //links oben --> rechts unten / Zeilen
            while (zeile < spielfeld.GetLength(0))
            {
                int player1zaehlerZeile = 0;
                int player2zaehlerZeile = 0;
                for (int j = 0; j < spielfeld.GetLength(0) - zeile; j++)
                {
                    if (spielfeld[zeile + j, j] == 1) { player1zaehlerZeile++; }
                    if (spielfeld[zeile + j, j] == 2) { player2zaehlerZeile++; }
                    if (spielfeld[zeile + j, j] == 0) { player1zaehlerZeile = 0; player2zaehlerZeile = 0; }
                    if (player1zaehlerZeile == 4 || player2zaehlerZeile == 4) { return 3; }
                }
                zeile++;
            }

            //links oben --> rechts unten / Spalten
            while (spalte < spielfeld.GetLength(0))
            {
                int player1zaehlerSpalte = 0;
                int player2zaehlerSpalte = 0;
                for (int j = 0; j < spielfeld.GetLength(0) - spalte; j++)
                {
                    if (spielfeld[j, spalte + j] == 1) { player1zaehlerSpalte++; }
                    if (spielfeld[j, spalte + j] == 2) { player2zaehlerSpalte++; }
                    if (spielfeld[j, spalte + j] == 0) { player1zaehlerSpalte = 0; player2zaehlerSpalte = 0; }
                    if (player1zaehlerSpalte == 4 || player2zaehlerSpalte == 4) { return 3; }
                }
                spalte++;
            }
            
            
            
            

            

            zeile = 0;
            spalte = spielfeld.GetLength(1) -1;
            //rechts oben --> links unten / Zeilen
            while (zeile < 3)
            {
                int player1zaehlerZeile = 0;
                int player2zaehlerZeile = 0;
                int zaehler = 0;
                for (int j = zeile; j < spielfeld.GetLength(0)-1; j++)
                {
                    if (spielfeld[j, spielfeld.GetLength(1)-1-zeile] == 1) { player1zaehlerZeile++; }
                    if (spielfeld[j, spielfeld.GetLength(1)-1-zeile] == 2) { player2zaehlerZeile++; }
                    if (spielfeld[j, spielfeld.GetLength(1)-1-zeile] == 0) { player1zaehlerZeile = 0; player2zaehlerZeile = 0; }
                    if (player1zaehlerZeile == 4 || player2zaehlerZeile == 4) { return 3; }
                    zaehler++;
                }
                zeile++;
            }
            
            //rechts oben --> links unten / Spalten
            while (spalte >= 2)
            {
                int player1zaehlerSpalte = 0;
                int player2zaehlerSpalte = 0;
                int zaehler = 0;
                for (int j = spalte; j > spielfeld.GetLength(0)-1; j--)
                {
                    if (spielfeld[j -j + zaehler, j] == 1) { player1zaehlerSpalte++; }
                    if (spielfeld[j -j + zaehler, j] == 2) { player2zaehlerSpalte++; }
                    if (spielfeld[j -j + zaehler, j] == 0) { player1zaehlerSpalte = 0; player2zaehlerSpalte = 0; }
                    if (player1zaehlerSpalte == 4 || player2zaehlerSpalte == 4) { return 3; }
                    zaehler++;
                }
                spalte--;
            }




            return 0;
            
        }
    }
}