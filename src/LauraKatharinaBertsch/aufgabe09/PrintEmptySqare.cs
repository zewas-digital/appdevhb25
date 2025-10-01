using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe09
{
    public class PrintEmptySquare
    {
        public static void Start(int size)
        {
            for (int y = 0; y < size; y++)
            {


                for (int x = 0; x < size; x++)
                {



                    if (y == 0)
                    {
                        Console.Write("x");
                    }
                    else if (y == size - 1)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        if (x == 0)
                        {
                            Console.Write("x");
                        }
                        else if (x == size - 1)
                        {
                            Console.Write("x");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }




                }
                Console.WriteLine();
            }




        }
    }
}