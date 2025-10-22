using System;
using Appdevhb25.SabrinaFeurstein;

namespace Appdevhb25.SabrinaFeurstein.uebung
{

    public class PascalDreieck
    {
        public static void Pascal()
        {
            string size = Console.ReadLine();
            int sizenew;
            while (!int.TryParse(size, out sizenew))
            {
                Console.WriteLine("Wrong value! Please try again.");
                size = Console.ReadLine();
            }

            int[,] triangle = new int[sizenew, sizenew];

            for (int i = 0; i < triangle.GetLength(0); i++)
            {
                for (int j = 0; j < triangle.GetLength(1); j++)
                {
                    if (i == 0 || j == 0)
                    {
                        triangle[i, j] = 1;
                    }


                    else if (i >= 1 || j >= 1)
                    {
                        triangle[i, j] = triangle[i - 1, j] + triangle[i, j - 1];
                    }
          
                }
            }


            ArrayHelper.print2DIntArray(triangle);
        }
    }
}