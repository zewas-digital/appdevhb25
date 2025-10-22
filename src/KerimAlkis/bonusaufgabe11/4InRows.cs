using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Dynamic;
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
            int leftfinished = 0;
            int topfinished = 0;
            (leftfinished, topfinished) = Console.GetCursorPosition(); 


            do
            {
                Console.SetCursorPosition(leftfinished, topfinished);

                for (int i = 0; i < 8; i++)
                {
                    Console.SetCursorPosition(leftfinished, topfinished+i);
                    Console.Write(new string(' ', Console.WindowWidth));
                }
                Console.SetCursorPosition(leftfinished, topfinished);



                if (spielerwechsel >= 7)
                {
                    if(spielerwechsel == 42)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("----Unentschieden----");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Zum erneut spielen druecke [1]");
                        if (Console.ReadKey(true).KeyChar == '1')
                        {
                            Start();
                        }
                        else { break; }
                    }
                    (int check, int[] zeilenCoords, int[] spaltenCoords) = Checker(spielfeld);
                    if (check == 3)
                    {
                        System.Console.WriteLine();
                        if (player == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("----Spieler 1 hat GEWONNEN----");
                            Console.ResetColor();
                            player1Siege++;
                            
                        }
                        else { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("----Spieler 2 hat GEWONNEN----"); Console.ResetColor(); player2Siege++; }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Zum erneut spielen druecke [1]");
                        Console.CursorVisible = false;
                        do
                        {
                            
                            while (!Console.KeyAvailable)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                for(int i = 0; i <= 3; i++)
                                {
                                    Console.SetCursorPosition(left[zeilenCoords[i], spaltenCoords[i]] - 1, top[zeilenCoords[i], spaltenCoords[i]]);
                                    Console.Write("*");
                                }
                                Thread.Sleep(600);
                                if (player == 1) 
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    for (int i = 0; i <= 3; i++)
                                    {
                                        Console.SetCursorPosition(left[zeilenCoords[i], spaltenCoords[i]] - 1, top[zeilenCoords[i], spaltenCoords[i]]);
                                        Console.Write("X");
                                    }

                                }
                                else 
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    for (int i = 0; i <= 3; i++)
                                    {
                                        Console.SetCursorPosition(left[zeilenCoords[i], spaltenCoords[i]] - 1, top[zeilenCoords[i], spaltenCoords[i]]);
                                        Console.Write("O");
                                    }
                                }
                                Thread.Sleep(600);

                            }
                        } while (!Console.KeyAvailable);


                        if (Console.ReadKey(true).KeyChar == '1')
                        {
                            Start();
                        }
                        else { break; }


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
                    for(int i = 0; i <= freieZeile; i++)
                    {
                        
                        Console.SetCursorPosition(left[i, spalte - 1]-1, top[i, spalte - 1]);
                        if(player == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("X"); Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else { Console.ForegroundColor = ConsoleColor.Green; Console.Write("O"); Console.ForegroundColor = ConsoleColor.Yellow; }
                        if(i == freieZeile) { break; }
                        Thread.Sleep(300);
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
        public static (int, int[], int[]) Checker(int[,] spielfeld)
        {
            //WinConditions Zeile/Horizontal
            for (int i = 0; i < spielfeld.GetLength(0); i++)
            {
                int[] zeilenCoord = new int[4];
                int[] spaltenCoord = new int[4];
                int playerCount = 0;
                for (int j = 0; j < spielfeld.GetLength(1)-1; j++)
                {
                    if (spielfeld[i, j] == 0) { playerCount = 0; }
                    else if (spielfeld[i, j] == spielfeld[i,j+1]) { zeilenCoord[playerCount] = i; spaltenCoord[playerCount] = j; playerCount++; }
                    else { playerCount = 0; }
                    if (playerCount == 3) { zeilenCoord[playerCount] = i; spaltenCoord[playerCount] = j+1; return (3, zeilenCoord, spaltenCoord); }
                }
            }


            //WinConditions Spalte/Vertikal
            for (int i = 0; i < spielfeld.GetLength(1); i++)
            {
                int[] zeilenCoord = new int[4];
                int[] spaltenCoord = new int[4];
                int playerCount = 0;
                for (int j = 0; j < spielfeld.GetLength(0) - 1; j++)
                {
                    if (spielfeld[j, i] == 0) { playerCount = 0; }
                    else if (spielfeld[j, i] == spielfeld[j + 1, i]) { zeilenCoord[playerCount] = j; spaltenCoord[playerCount] = i; playerCount++; }
                    else { playerCount = 0; }
                    if (playerCount == 3) { zeilenCoord[playerCount] = j+1; spaltenCoord[playerCount] = i; return (3, zeilenCoord, spaltenCoord); }
                }
            }


            //ab hier Windconditions Diagonalle


            int zeile = 0; 
            int spalte = 0;
            //links oben --> rechts unten /Zeilen 
            while (zeile < 4)
            {
                int[] zeilenCoord = new int[4];
                int[] spaltenCoord = new int[4];
                int playerCount = 0;
                for (int j = 0; j < spielfeld.GetLength(0) - zeile - 1; j++)
                {
                    if (spielfeld[zeile + j, j] == 0) { playerCount = 0; }
                    if (spielfeld[zeile + j, j] == spielfeld[zeile + j + 1, j + 1]) { zeilenCoord[playerCount] = zeile + j; spaltenCoord[playerCount] = j; playerCount++; }
                    else { playerCount = 0; }
                    if (playerCount == 3) { zeilenCoord[playerCount] = zeile + j + 1; spaltenCoord[playerCount] = j + 1; return (3, zeilenCoord, spaltenCoord); }
                }
                zeile++;
            }


            //links oben --> rechts unten / Spalten
            while (spalte < spielfeld.GetLength(0))
            {
                int[] zeilenCoord = new int[4];
                int[] spaltenCoord = new int[4];
                int playerCount = 0;
                for (int j = 0; j < spielfeld.GetLength(0) - spalte-1; j++)
                {
                    if (spielfeld[j, spalte + j] == 0) { playerCount = 0; }
                    if (spielfeld[j, spalte + j] == spielfeld[j+1, spalte + j+1]) { zeilenCoord[playerCount] = j; spaltenCoord[playerCount] = spalte + j; playerCount++; }
                    else { playerCount = 0; }
                    if (playerCount == 3) { zeilenCoord[playerCount] = j + 1; spaltenCoord[playerCount] = spalte + j + 1; return (3, zeilenCoord, spaltenCoord); }
                    
                    
                }
                spalte++;
            }



            zeile = 0;
            spalte = spielfeld.GetLength(1) - 1;
            //rechts oben --> links unten / Zeilen
            while (zeile < 3)
            {
                int[] zeilenCoord = new int[4];
                int[] spaltenCoord = new int[4];
                int playerCount = 0;
                int zaehler = 0;
                for (int j = zeile; j < spielfeld.GetLength(0) - 1; j++)
                {
                    if (spielfeld[j, spielfeld.GetLength(1) - 1-zaehler] == 0) { playerCount = 0; }
                    if (spielfeld[j, spielfeld.GetLength(1) - 1-zaehler] == spielfeld[j+1, spielfeld.GetLength(1) - 1 - zaehler-1]) { zeilenCoord[playerCount] = j; spaltenCoord[playerCount] = spielfeld.GetLength(1) - 1 - zaehler; playerCount++; }
                    else { playerCount = 0; }
                    if (playerCount == 3) { zeilenCoord[playerCount] = j + 1; spaltenCoord[playerCount] = spielfeld.GetLength(1) - 1 - zaehler -1; return (3, zeilenCoord, spaltenCoord); }
                    zaehler++;
                    
                }
                zeile++;
            }
            //rechts oben --> links unten / Spalten
            while (spalte >= 2)
            {
                int[] zeilenCoord = new int[4];
                int[] spaltenCoord = new int[4];
                int playerCount = 0;
                int zaehler = 0;
                for (int j = spalte; j >= 1; j--)
                {
                    if (spielfeld[zaehler, j] == 0) { playerCount = 0; }
                    if (spielfeld[zaehler, j] == spielfeld[zaehler+1, j-1]) { zeilenCoord[playerCount] = zaehler; spaltenCoord[playerCount] = j; playerCount++; }
                    else { playerCount = 0; }
                    if (playerCount == 3) { zeilenCoord[playerCount] = zaehler + 1; spaltenCoord[playerCount] = j -1; return (3, zeilenCoord, spaltenCoord); }
                    if (zaehler < 4) { zaehler++; }
                }
                spalte--;
            }

            return (0, new int[0], new int[0]);

        }
        
    }
}