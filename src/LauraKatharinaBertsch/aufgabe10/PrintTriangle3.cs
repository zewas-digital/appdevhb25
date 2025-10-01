using System.Drawing;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe10
{
    public class PrintTriangle3
    {
        public static void Start(int lenght)
        {
            for (int y = 0; y < lenght; y++)
            {

                for (int x = lenght + lenght - 1; x > 0; x--)
                {


                    if (x - lenght == y)
                    {
                        Console.Write("x");
                    }
                    else if (y == lenght - 1)
                    {
                        Console.Write("x");
                    }
                    else if (x + y == lenght)
                    {

                        {
                            Console.Write("x");
                        }


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