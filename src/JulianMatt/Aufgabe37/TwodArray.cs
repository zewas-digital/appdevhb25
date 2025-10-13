using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

namespace Appdevhb25.JulianMatt.Aufgabe37
{
    public class TwodArrayArray
    {

        public static void Start37()
        {
            int[] mainArray = Arraycreator();
            Calculator(mainArray);


        }

        public static int[] Arraycreator()
        {
            int[] mainArray;
            int mainArrayLength;
            Random rnd = new Random();
            Console.WriteLine("Geben sie die Länge des Arrays an:");
            mainArrayLength = Convert.ToInt32(Console.ReadLine());
            mainArray = new int[mainArrayLength];
            for (int j = 0; j < mainArrayLength; j++)
            {
                for (int i = 0; i < mainArrayLength; i++)
                {
                    mainArray[i] = rnd.Next(0, 10);
                    Console.Write(mainArray[i] + " ");
                }
                Console.WriteLine();
            }
            return mainArray;

        }

        public static void Calculator(int[] mainArray)
        {

        }

    }
}
