using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

namespace Appdevhb25.JulianMatt.Aufgabe34
{
    public class CopyReverse
    {

        public static void Start34()
        {
            int[] number = OgVar();
            //Console.Clear();
            int[] copy = CopyVarFlipped(number);


            Console.WriteLine("Der ursprüngliche array:");
            for (int j = 0; j < number.Length; j++)
            {
                Console.WriteLine(number[j]);
            }
            Console.WriteLine("Der Kopierte Array:");
            for (int j = 0; j < copy.Length; j++)
            {
                Console.WriteLine(copy[j]);
            }
        }
        public static int[] OgVar()
        {
            int[] number;
            int countOfParticipants = TeilnehmerAnzahl();
            Console.WriteLine("Geben sie ihre Zahlen an:");
            number = new int[countOfParticipants];

            for (int j = 0; j < countOfParticipants; j++)
            {
                number[j] = Convert.ToInt32(Console.ReadLine());
            }
            return number;
        }

        public static int TeilnehmerAnzahl()
        {
            int countOfNumbers;
            Console.WriteLine("Geben sie die Anzahl ihrer Zahlen an");
            countOfNumbers = Convert.ToInt32(Console.ReadLine());
            return countOfNumbers;
        }

        public static int[] CopyVarFlipped(int[] number)
        {
            int[] copy = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                copy[i] = number[number.Length - 1 - i];
            }
            return copy;
        }
    }
}
