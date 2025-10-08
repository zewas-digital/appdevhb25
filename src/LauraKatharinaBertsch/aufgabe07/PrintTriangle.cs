using System.Globalization;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe07
{
    public class PrintTriangle
    {
        public static void Start()
        {

            int hight = 5;
            int lenght = 5;
            Console.WriteLine("Höhe: " + hight);
            Console.WriteLine("Länge: " + lenght);
            for (int i = 0; i < hight; i++)
            {

                for (int j = 0; j < lenght; j++)
                {
                    Console.Write("x");

                }
                lenght = lenght - 1;
                Console.WriteLine();
            }

        }
    }
}