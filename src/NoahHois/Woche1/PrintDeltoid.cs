using System;

namespace Appdevhb25.NoahHois.BonusAufgabe1
{
    public class PrintDeltoid
    {
        public static void BonusAufgabe1()
        {
            Console.Write("Geben Sie die Hoehe des Deltoids ein: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(">" + height);

            for (int y = 0; y < height; y++)
            {

                for (int x = height * -1 + 1; x < height; x++)
                {

                    if (Math.Abs(x) == Math.Abs(y))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            for (int y = height -2; y >= 0; y--)
            {

                for (int x = height * -1 +1; x < height; x++)
                {

                    if (Math.Abs(x) == Math.Abs(y))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}