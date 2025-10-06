using System;
using System.Data;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe03
{

    public class PrintChristmasTree
    {

        public static void StartPrintChristmasTree()
        {
            Console.WriteLine("----------Bonusaufgabe 03----------");
            int size;

            Console.WriteLine("Gib die Größe ein:");
            size = Helper.checkUserInputInteger();

            CreateChristmasTree(size);
        }

        static void CreateChristmasTree(int size)
        {
            int start;
            int end;

            int correction;

            if (size % 2 == 0)
            {
                correction = 0;
            }
            else
            {
                correction = 1;
            }

            int extraRows1 = size / 3 / 3;
            int extraRows2 = size / 3 / 3 * 2; //erstes /3 weil kugeln und stamm zusammen ein drittel des baumes groß sind 2. /3 und*2 weil stamm 2/3 der größe von kugel und stamm gesamt ausmachen soll

            if (extraRows1 == 0)
            {
                extraRows1 = 1;
            }
            if (extraRows2 < 9 && extraRows2 > 6)
            {
                extraRows2 = 2;
            }
            if (extraRows2 == 0)
            {
                extraRows2 = 1;
            }

            for (int i = 0; i < size / 2 + extraRows1 + extraRows2 + 1; i++)
            {


                if (i < size / 2 + 1)
                {
                    start = size / 2 - i;
                    end = size / 2 + i + correction;
                    for (int j = 0; j < size + 1; j++)
                    {
                        if (j >= start && j <= end)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                else if (i < size / 2 + extraRows1 + 1)
                {

                    for (int j = 0; j < size + 1; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write("O");
                        }
                        else if (j % 2 == 0)
                        {
                            Console.Write("O");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    }
                }
                else
                {


                    start = size / 2 - extraRows2 - correction;
                    end = size / 2 + extraRows2 + correction;
                    for (int j = 0; j < size + 1; j++)
                    {
                        if (j >= start && j <= end)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }

                Console.WriteLine("");
            }
            Console.WriteLine();


        }

    }
}
