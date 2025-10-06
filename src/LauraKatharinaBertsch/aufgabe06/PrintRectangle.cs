using System;
namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe06
{
    public class PrintRectangle
    {
        public static void Start()
        {

            int hight = 5;
            int lenght = 3;
            Console.WriteLine("Höhe: " + hight);
            Console.WriteLine("Länge: " + lenght);
            for (int i = 0; i < hight; i++)
            {

                for (int j = 0; j < lenght; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

        }
    }
}