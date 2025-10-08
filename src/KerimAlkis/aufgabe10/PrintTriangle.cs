using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.KerimAlkis.Aufgabe10
{
    public class PrintTriangle
    {
        public static void Start()
        {
            int x;
            do
            {
                Console.Clear();
                System.Console.WriteLine("Kathetet: ");
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    x = inputNumber; break;
                }
            } while (true);


            PrintTriangle1(x);
        }
        public static void PrintTriangle1(int length)
        {
            double hypothenuse = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(length, 2));

            int hypothenuseTest = (length + length) - 1;

            int halfte = hypothenuseTest / 2;



            for (int i = 0; i < length; i++)
            {
                for (int y = 0; y < hypothenuseTest; y++)
                {
                    if (i == 0 && y == halfte)
                    {
                        Console.Write("X");
                    }
                    else if (i == length - 1)
                    {
                        Console.Write("X");
                    }
                    else if (i < hypothenuseTest - 1)
                    {
                        if (y == halfte + i || y == halfte - i)
                        {
                            Console.Write("X");
                        }
                        else { Console.Write(" "); }
                    }
                    else { Console.Write(" "); }
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine("theorethische Hypothenuse: " + hypothenuse + "\npraktische Hypothenuse: " + hypothenuseTest);
        }
    }
}