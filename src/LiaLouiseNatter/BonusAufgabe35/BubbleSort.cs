using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.LiaLouiseNatter.Aufgabe31;
using System.Collections.Immutable;

namespace Appdevhb25.LiaLouiseNatter.BonusAufgabe35
{
    public class BubbleSort
    {

        public static void Start()
        {
            Sorter();
        }

        public static void Sorter()
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
        
    }
}