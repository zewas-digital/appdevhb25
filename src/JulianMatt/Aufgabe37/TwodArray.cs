using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using Appdevhb25.JulianMatt.Aufgabe01;

namespace Appdevhb25.JulianMatt.Aufgabe37
{
    public class TwodArrayArray
    {

        public static void Start37()
        {
            int[,] mainArray = Arraycreator();
            Print(mainArray);
            HorizontalSolution(mainArray);
            Console.WriteLine();
            VerticalSolution(mainArray);


        }

        public static int[,] Arraycreator()
        {

            int mainArrayLength;
            Random rnd = new Random();
            Console.WriteLine("Geben sie die Länge des Arrays an und die Breite an");
            Console.Write("Länge: ");
            mainArrayLength = Convert.ToInt32(Console.ReadLine());
            Console.Write("Breite: ");
            int mainArraywidth = Convert.ToInt32(Console.ReadLine());
            int[,] mainArray = new int[mainArraywidth, mainArrayLength];
            for (int j = 0; j < mainArraywidth; j++)
            {
                for (int i = 0; i < mainArrayLength; i++)
                {
                    mainArray[j, i] = rnd.Next(0, 9);
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

        public static void HorizontalSolution(int[,] mainArray)
        {

            for (int j = 0; j < mainArray.GetLength(0); j++)
            {
                int equals = 0;
                for (int i = 0; i < mainArray.GetLength(1); i++)
                {
                    equals += mainArray[j, i];

                }
                Console.Write("Summe der Zeile " + (j + 1)+": ");
                Console.WriteLine(equals);
            }
        }
        public static void VerticalSolution(int [,] mainArray)
        {
            for (int j = 0; j < mainArray.GetLength(0); j++)
            {
                int equals = 0;
                for (int i = 0; i < mainArray.GetLength(1); i++)
                {
                    equals += mainArray[i, j];

                }
                Console.Write("Summer der Spalte " + (j + 1)+": ");
                Console.WriteLine(equals);
            }
        }

    }
}
