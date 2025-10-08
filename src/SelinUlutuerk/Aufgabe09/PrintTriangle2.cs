using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe09
{
    class PrintTriangle2
    {
        public static void Start()
        {
            int size = 5;
            for(int i = 0; i < size ; i++ )
            {
                for( int j = 0; j < size - i; j++)
                {
                    Console.Write("x");
                }

                for(int j = 0; j < i; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(".");
                }
                for(int j= 0; j < size - i; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for(int i = 0; i < size ; i++ )
            {
                for( int j = 1; j < size - i; j++)
                {
                    Console.Write(".");
                }

                for(int j = 0; j <= i; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("x");
                }
                for(int j= 1; j < size - i; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
        }
    }
}