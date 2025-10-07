using System;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe13
{
    class PrintDeltoid
    {
        public static void Deltoid(int size)
        {

            for(int y = 1 ; y <= size; y++)
            {
                for(int x = 1; x <= size - y; x++)
                {
                    Console.Write(" ");
                }

                for(int x = 1; x <= 2 * y ; x++)
                {
                    if (x == 1 || x == 2 * y - 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
            for(int y = 1 ; y <= size; y++)
            {
                for(int x = 1; x <= y; x++)
                {
                    Console.Write(" ");
                }
                
                for(int x = 1; x <= 2 * (size - y); x++)
                {
                    if( x == 2 * (size - y) - 1 || x == 1 )
                    {
                        Console.Write("X");
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
