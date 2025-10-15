using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using Appdevhb25.LauraKatharinaBertsch.Aufgabe25;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe37
{
    public class TwoDArray
    {
        public static void Start()
        {


            int[,] twoDArray = new int[3, 3];

            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    Console.Write($"Schreibe eine Zahl für die Position [{i},{j}]");
                    int input = Convert.ToInt32(Console.ReadLine());
                    twoDArray[i, j] = input;
                }
            }
            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    Console.Write(twoDArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Zeilensummen von oben nach unten:");
            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {

                    sum += twoDArray[i, j];
                }
                Console.WriteLine("Summe der Zeile: " + sum);
            }

            Console.WriteLine("Spaltensummen von links nach rechts:");
            for (int j = 0; j < twoDArray.GetLength(0); j++)
            {
                int sum1 = 0;
                for (int i = 0; i < twoDArray.GetLength(1); i++)
                {

                    sum1 += twoDArray[i, j];
                }
                Console.WriteLine("Summe der Spalte: " + sum1);

            }


        }
    }
}