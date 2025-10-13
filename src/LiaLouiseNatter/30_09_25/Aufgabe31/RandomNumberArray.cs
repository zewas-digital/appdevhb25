using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe31
{
    public class RandomNumberArray
    {
        public static void Start()
        {
            RandomArray();
        }
        public static void RandomArray()
        {
            System.Console.Write("Anzahl der Elemente: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Nur Zahlen sind erlaubt!");

            }
            System.Console.WriteLine("--------------------");

            int[] randomArray = new int[number];
            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                randomArray[i] = random.Next(0, 100);
                System.Console.WriteLine(randomArray[i]);
            }


            int bigElement = randomArray[0];
            for (int i = 1; i < number; i++)
            {
                if (randomArray[i] > bigElement)
                {
                    bigElement = randomArray[i];
                }

            }
            System.Console.WriteLine("----------------");
            System.Console.WriteLine($"Biggest Number: {bigElement}");


            int littleElement = randomArray[0];
            for (int i = 1; i < number; i++)
            {
                if (randomArray[i] < littleElement)
                {
                    littleElement = randomArray[i];
                }

            }
            System.Console.WriteLine("----------------");
            System.Console.WriteLine($"Smallest Number: {littleElement}");


            int summ = 0;
            int average = 0;
            for (int i = 0; i < number; i++)
            {
                summ += randomArray[i];
                average = summ / randomArray.Length;
            }

            System.Console.WriteLine("----------------");
            System.Console.WriteLine($"Average: {average}");
            System.Console.WriteLine("----------------");
            System.Console.WriteLine($"Summ: {summ}");
            System.Console.WriteLine("----------------");


            

       


            

        }
        


      

        
    }
}