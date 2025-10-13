using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.LiaLouiseNatter.Aufgabe31;
using System.Collections.Immutable;

namespace Appdevhb25.LiaLouiseNatter.BonusAufgabe36
{
    public class Algorithmen
    {

        public static void Start()
        {
            //BubbleSorter();
            //SelectionSort();
            CocktailSort();

        }



        public static void BubbleSorter()
        {
            int[] unsortetArray = new int[5];

            for (int i = 0; i < unsortetArray.Length; i++)
            {
                System.Console.Write($"Number{i + 1}: ");
                int eingabe = Convert.ToInt32(Console.ReadLine());
                unsortetArray[i] = eingabe;


            }
            for (int i = 0; i < unsortetArray.Length; i++)
            {
                System.Console.Write(unsortetArray[i]);
            }

            for (int i = 0; i < unsortetArray.Length; i++)
            {
                for (int j = 0; j < unsortetArray.Length + 1; j++)
                {
                    if (j == unsortetArray.Length - 1)
                    {
                        break;
                    }
                    if (unsortetArray[j] > unsortetArray[j + 1])
                    {
                        var holder = unsortetArray[j];
                        unsortetArray[j] = unsortetArray[j + 1];
                        unsortetArray[j + 1] = holder;
                    }
                }

            }
            System.Console.WriteLine();
            System.Console.Write("Your Sorted numbers: ");
            for (int k = 0; k < unsortetArray.Length; k++)
            {
                System.Console.Write(unsortetArray[k]);
            }
        }

        public static int[] SelectionSort()
        {
            int[] unsortetArray = new int[10];
            int arrayLength = unsortetArray.Length;

            // Eingabe
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Number {i + 1}: ");
                unsortetArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Sortieren
            for (int i = 0; i < arrayLength - 1; i++)
            {
                int minimumIndex = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (unsortetArray[j] < unsortetArray[minimumIndex])
                    {
                        minimumIndex = j;
                    }
                }

                int tempHolder = unsortetArray[minimumIndex];
                unsortetArray[minimumIndex] = unsortetArray[i];
                unsortetArray[i] = tempHolder;
            }

            Console.WriteLine("Sortiertes Array:");
            foreach (var number in unsortetArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            return unsortetArray;
        }

        public static int[] CocktailSort()
        {
            int[] unsortetArray = new int[10];
            int arrayLength = unsortetArray.Length;

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Number {i + 1}: ");
                unsortetArray[i] = Convert.ToInt32(Console.ReadLine());
            }


            int startNum = 0;
            int endNum = arrayLength - 1;
            int leftToSort = arrayLength;

            do
            {
                for (int k = startNum; k < endNum; k++)
                {
                    if (unsortetArray[k] > unsortetArray[k + 1])
                    {
                        int tempHolder = unsortetArray[k];
                        unsortetArray[k] = unsortetArray[k + 1];
                        unsortetArray[k + 1] = tempHolder;
                    }
                }
                endNum--;
                leftToSort--;



                for (int j = endNum; j >= startNum; j--)
                {
                    if (unsortetArray[j] > unsortetArray[j + 1])
                    {
                        int tempHolder = unsortetArray[j];
                        unsortetArray[j] = unsortetArray[j + 1];
                        unsortetArray[j + 1] = tempHolder;
                    }

                }
                startNum++;
                leftToSort--;

            } while (leftToSort > 0);

            Console.WriteLine("Sortiertes Array:");
            foreach (var number in unsortetArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            return unsortetArray;
        }



    }
}
