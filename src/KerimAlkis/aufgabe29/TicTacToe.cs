using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.KerimAlkis.Aufgabe29
{
    public class TicTacToe
    {
        public static void Start()
        {


            int[,] spielfeld = new int[3, 3];

            int p = 0;
            int spielerwechsel = 0;


            do
            {
                Console.Clear();
                Console.WriteLine("----------");
                Console.WriteLine("TicTacToe");
                Console.WriteLine("----------\n");
                Console.WriteLine("  1 2 3");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(i + 1 + "|");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(spielfeld[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                System.Console.WriteLine();

                int checkerVar = Checker(spielfeld, spielerwechsel);
                if(checkerVar != 0)
                {
                    if (checkerVar == 9)
                    {
                        Console.WriteLine("--------------");
                        Console.WriteLine("Unentschieden");
                        break;
                    }
                    else if (checkerVar == 1)
                    {
                        Console.WriteLine("--------------");
                        Console.WriteLine("Spieler 1 hat gewonnen");
                        break;
                    }
                    else if (checkerVar == 2)
                    {
                        Console.WriteLine("--------------");
                        Console.WriteLine("Spieler 2 hat gewonnen");
                        break;
                    }
                }


                if (spielerwechsel % 2 == 0)
                {
                    Console.WriteLine("Spieler 1 ist dran");
                    p = 1;
                    spielerwechsel++;
                }
                else { Console.WriteLine("Spieler 2 ist dran"); spielerwechsel++; p = 2; }

                System.Console.WriteLine();


                Console.WriteLine("ZeilenAuswahl: 1. 2. 3.");
                Console.Write("Auswahl: ");
                int zeile = 0;
                do
                {
                    char inputZ = Console.ReadKey(true).KeyChar;
                    if (inputZ == '1' || inputZ == '2' || inputZ == '3')
                    {
                        string temp = inputZ.ToString();
                        zeile = Convert.ToInt32(temp); break;
                    }
                } while (true);
                Console.Write(zeile);
                System.Console.WriteLine();

                Console.WriteLine("SpaltenAuswahl: 1. 2. 3.");
                Console.Write("Auswahl: ");
                int spalte = 0;
                do
                {
                    char inputS = Console.ReadKey(true).KeyChar;
                    if (inputS == '1' || inputS == '2' || inputS == '3')
                    {
                        string temp = inputS.ToString();
                        spalte = Convert.ToInt32(temp); break;
                    }
                } while (true);
                Console.Write(zeile);

                System.Console.WriteLine();
                
                System.Console.WriteLine();



                if (spielfeld[zeile - 1, spalte - 1] == 0)
                {
                    spielfeld[zeile - 1, spalte - 1] = p;
                }
                else
                {
                    Console.WriteLine("Das Feld ist nicht frei"); Console.ReadKey(); spielerwechsel--;
                }

            } while (true);

        }
        public static int Checker(int[,] spielfeld, int zaehler)
        {
            if (spielfeld[0, 0] == spielfeld[0, 1] && spielfeld[0, 1] == spielfeld[0, 2]) { return spielfeld[0, 0]; }
            if (spielfeld[1, 0] == spielfeld[1, 1] && spielfeld[1, 1] == spielfeld[1, 2]) { return spielfeld[1, 0]; }
            if (spielfeld[2, 0] == spielfeld[2, 1] && spielfeld[2, 1] == spielfeld[2, 2]) { return spielfeld[2, 0]; }

            if (spielfeld[0, 0] == spielfeld[1, 0] && spielfeld[1, 0] == spielfeld[2, 0]) { return spielfeld[0, 0]; }
            if (spielfeld[0, 1] == spielfeld[1, 1] && spielfeld[1, 1] == spielfeld[2, 1]) { return spielfeld[0, 1]; }
            if (spielfeld[0, 2] == spielfeld[1, 2] && spielfeld[1, 2] == spielfeld[2, 2]) { return spielfeld[0, 2]; }

            if (spielfeld[0, 0] == spielfeld[1, 1] && spielfeld[1, 1] == spielfeld[2, 2]) { return spielfeld[0, 0]; }
            if (spielfeld[0, 2] == spielfeld[1, 1] && spielfeld[1, 1] == spielfeld[2, 0]) { return spielfeld[0, 2]; }

            if (zaehler == 9)
            {
                return 9;
            }
            return 0;
            
        }
    }
}