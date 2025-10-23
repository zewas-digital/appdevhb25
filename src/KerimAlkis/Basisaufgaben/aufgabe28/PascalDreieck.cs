using System.Security.Cryptography;

namespace Appdevhb25.KerimAlkis.Aufgabe28
{
    public class PascalDreieck
    {
        public static void Start()
        {
            Console.WriteLine("Wie viele Zeilen und Spalten willst du generieren");

            int number = 0;
            do
            {
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    number += inputNumber; break;
                }
                else { Console.WriteLine("Versuchs Nochmal"); }
            } while (true);


            int[,] numberArray = new int[number, number];


            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        numberArray[i, j] = 1;
                    }
                    else { numberArray[i, j] = numberArray[i - 1, j] + numberArray[i, j - 1]; }
                }
            }
            
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    //Console.Write(numberArray[i, j].ToString().PadLeft(6));
                    Console.Write(numberArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}