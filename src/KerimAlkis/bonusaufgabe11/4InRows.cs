using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Security.AccessControl;

namespace Appdevhb25.KerimAlkis.Bonusaufgabe11
{
    public class FourInRows
    {
        private static int player1Siege;
        private static int player2Siege;

        public static void Start()
        {
            int[,] spielfeld = new int[6, 7];

            int[,] left = new int[6, 7];
            int[,] top = new int[6, 7];
            


            int spielerwechsel = 0;

            int player = 0;


            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("==========\t"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Spieler 1 "); Console.Write("--> \"X\""); Console.WriteLine("  Siege: {0}", player1Siege); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(" 4 in Row ");
            Console.Write("==========\t"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("Spieler 2 "); Console.Write("--> \"O\""); Console.WriteLine("  Siege: {0}\n\n", player2Siege); Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("| 1 | 2 | 3 | 4 | 5 | 6 | 7 |"); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < spielfeld.GetLength(0); i++)
            {
                for (int j = 0; j < spielfeld.GetLength(1); j++)
                {
                    if (spielfeld[i, j] == 0)
                    {
                        Console.Write("| "); Console.ForegroundColor = ConsoleColor.White; Console.Write("*"); (int left1, int top2) = Console.GetCursorPosition(); left[i, j] = left1; top[i, j] = top2; Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" ");
                    }
                    else if (spielfeld[i, j] == 1)
                    {
                        Console.Write("| "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("X"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" ");
                    }
                    else { Console.Write("| "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("O"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" "); }
                }
                Console.Write("|");
                Console.WriteLine("\n-----------------------------");

            }
            Console.BackgroundColor = ConsoleColor.Black;


            do
            {

                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("==========\t"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Spieler 1 "); Console.Write("--> \"X\""); Console.WriteLine("  Siege: {0}", player1Siege); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(" 4 in Row ");
                Console.Write("==========\t"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("Spieler 2 "); Console.Write("--> \"O\""); Console.WriteLine("  Siege: {0}\n\n", player2Siege); Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("| 1 | 2 | 3 | 4 | 5 | 6 | 7 |"); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----------------------------");
                for (int i = 0; i < spielfeld.GetLength(0); i++)
                {
                    for (int j = 0; j < spielfeld.GetLength(1); j++)
                    {
                        if (spielfeld[i, j] == 0)
                        {
                            Console.Write("| "); Console.ForegroundColor = ConsoleColor.White; Console.Write("*"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" ");
                        }
                        else if (spielfeld[i, j] == 1)
                        {
                            Console.Write("| "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("X"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" ");
                        }
                        else { Console.Write("| "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("O"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" "); }
                    }
                    Console.Write("|");
                    Console.WriteLine("\n-----------------------------");

                }
                Console.BackgroundColor = ConsoleColor.Black;

                if (spielerwechsel >= 7)
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
                            player1Siege++;
                            break;
                        }
                        else { Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("Spieler 2 hat GEWONNEN"); Console.ResetColor(); player2Siege++; break; }
                    }
                }
                

                System.Console.WriteLine();

                
                if (spielerwechsel % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("SPIELER 1 ist dran");Console.ForegroundColor = ConsoleColor.Yellow;
                    player = 1;
                    spielerwechsel++;
                }
                else { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("SPIELER 2 ist dran"); Console.ForegroundColor = ConsoleColor.Yellow;spielerwechsel++; player = 2; }
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
                    Console.CursorVisible = false;
                    for(int i = 0; i < freieZeile; i++)
                    {
                        
                        Console.SetCursorPosition(left[i, spalte - 1]-1, top[i, spalte - 1]);
                        if(player == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("X"); Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else { Console.ForegroundColor = ConsoleColor.Green; Console.Write("O"); Console.ForegroundColor = ConsoleColor.Yellow; }

                        Thread.Sleep(400);
                        Console.SetCursorPosition(left[i, spalte - 1] - 1, top[i, spalte - 1]);
                        Console.ForegroundColor = ConsoleColor.White; Console.Write("*"); Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.CursorVisible = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine("\n\nDas Feld ist nicht frei"); Thread.Sleep(1000); ; spielerwechsel--;
                }

            } while (true);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Zum erneut spielen druecke 1");
            if(Console.ReadKey(true).KeyChar == '1')
            {
                Start();
            }

        }
        public static int SpielbrettAuswahl()
        {
            Console.WriteLine("In welche Spalte willst du reinwerfen");
            Console.Write("Spalte: ");
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
                    if (spielfeld[i, j] == 1) { player1zaehlerZeile++; player2zaehlerZeile = 0; }
                    if (spielfeld[i, j] == 2) { player2zaehlerZeile++; player1zaehlerZeile = 0; }
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
                    if (spielfeld[j, i] == 1) { player1zaehlerSpalte++; player2zaehlerSpalte = 0; }
                    if (spielfeld[j, i] == 2) { player2zaehlerSpalte++; player1zaehlerSpalte = 0; }
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
                    if (spielfeld[zeile + j, j] == 1) { player1zaehlerZeile++; player2zaehlerZeile = 0; }
                    if (spielfeld[zeile + j, j] == 2) { player2zaehlerZeile++; player1zaehlerZeile = 0; }
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
                    if (spielfeld[j, spalte + j] == 1) { player1zaehlerSpalte++; player2zaehlerSpalte = 0; }
                    if (spielfeld[j, spalte + j] == 2) { player2zaehlerSpalte++; player1zaehlerSpalte = 0; }
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
                    if (spielfeld[j, spielfeld.GetLength(1)-1-zeile] == 1) { player1zaehlerZeile++; player2zaehlerZeile = 0; }
                    if (spielfeld[j, spielfeld.GetLength(1)-1-zeile] == 2) { player2zaehlerZeile++; player1zaehlerZeile = 0; }
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
                for (int j = spalte; j >= 0; j--)
                {
                    if (spielfeld[zaehler, j] == 1) { player1zaehlerSpalte++; player2zaehlerSpalte = 0; }
                    if (spielfeld[zaehler, j] == 2) { player2zaehlerSpalte++; player1zaehlerSpalte = 0; }
                    if (spielfeld[zaehler, j] == 0) { player1zaehlerSpalte = 0; player2zaehlerSpalte = 0; }
                    if (player1zaehlerSpalte == 4 || player2zaehlerSpalte == 4) { return 3; }
                    if (zaehler < 5) { zaehler++; };
                }
                spalte--;
            }




            return 0;
            
        }
        
    }
}