using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe8
{
    public class PrintTriangle2
    {
        public static void Start()
        {
            System.Console.Write("Größe: ");
            var height = Console.ReadLine();
            int result = Convert.ToInt32(height);

            Triangle1(result);
            System.Console.WriteLine();
            Triangle2(result);
            System.Console.WriteLine();
            Triangle3(result);
            System.Console.WriteLine();
            Triangle4(result);

        }

        public static void Triangle1(int result)
        {

            for (int i = 0; i < result; i++)
            {
                for (int j = 0; j < result; j++)
                {
                    if (j < result - i)
                    {
                        System.Console.Write("*");
                    }

                    else
                    {
                        System.Console.Write(".");
                    }
                }
                System.Console.WriteLine();
                

            }

        }

        public static void Triangle2(int result)
        {
            // rows
            for (int i = 0; i < result; i++)
            {
                // columns spaces
                for (int j = 0; j < i; j++)
                {
                    Console.Write(".");
                }

                // columns
                for (int j = 0; j < result - i; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }

        public static void Triangle3(int result)
        {
            for (int i = 0; i < result; i++)
            {
                for (int j = 0; j < result - i - 1; j++)
                {
                    System.Console.Write(".");
                }

                for (int j = 0; j < result + i - result + 1; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }

        public static void Triangle4(int result)
        {
            for (int i = 0; i < result; i++)
            {
                /*
                for (int j = 1; j < result - i; j++)
                {
                    System.Console.Write(".");
                }
                */
                for (int j = 0; j < result; j++)
                {
                    if (j <= i)
                    {
                        System.Console.Write("*");
                    }
                    else
                    {
                        System.Console.Write(".");
                    }
                }
            System.Console.WriteLine();
                
            }
            

            
            
        }
    }
}