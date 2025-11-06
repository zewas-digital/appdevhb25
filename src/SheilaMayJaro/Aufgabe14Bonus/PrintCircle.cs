using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe14
{
    public class Circle
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 14)");
            PrintCircle(20);

        }
        public static bool IsPointOnCircle(int x, int y, int radius)
        {
            return x*x + y*y == radius*radius; 
        }
        public static void PrintCircle(int radius)
        {
            for (int x = -radius; x <= radius; x++)
            {
                for (int y = -radius; y <= radius; y++)
                {
                    if (IsPointOnCircle(x, y, radius))
                    {
                        System.Console.Write("**");
                    }
                    else
                    {
                        System.Console.Write("  ");
                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}