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
            System.Console.WriteLine(unsortetArray);


        }
        
    }
}