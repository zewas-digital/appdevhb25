using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using Appdevhb25.JulianMatt.Aufgabe01;
          
namespace Appdevhb25.JulianMatt.Aufgabe38
{
    public class PascalDreieck
    {

        public static void Start38()
        {
            int[,] mainArray = Arraycreator();
            Print(mainArray);
            

        }

        public static int[,] Arraycreator()
        {


            int mainArrayLength;

            Random rnd = new Random();
            
            Console.WriteLine("Geben sie die Länge des Pascal dreieckes an");
            
            Console.Write("Länge: ");
            mainArrayLength = Convert.ToInt32(Console.ReadLine());

            int[,] mainArray = new int[mainArrayLength, mainArrayLength];
            for (int i = 0; i < mainArrayLength; i++)
            {
                for (int j = 0; j < mainArrayLength; j++)
                {
                    if (i == 0 || j == 0)
                        mainArray[i, j] = 1;
                    else
                    {
                        mainArray[i, j] = mainArray[i - 1, j] + mainArray[i, j - 1];
                    }
                }

            }
            return mainArray;
        }
        
        public static void Print (int [,] mainArray)
        {
            for (int j = 0; j < mainArray.GetLength(0); j++)
            {
                for (int i = 0; i < mainArray.GetLength(1); i++)
                {
                    Console.Write(mainArray[j, i] + " ");
                }
                Console.WriteLine();
            }
        }

        

    }
}

