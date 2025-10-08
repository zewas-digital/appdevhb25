using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

namespace Appdevhb25.JulianMatt.Aufgabe33
{
    public class Copy
    {

        public static void Start33()
        {
            int[] number = OgVar();
            int[] copy = CopyVar(number);
            number[0] = -1;

            Console.WriteLine("Originaler Array " + number);
      
            Console.WriteLine("-1");
            for (int j = 1; j < copy.Length; j++)
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

        public static int[] CopyVar(int[] number)
        {
            int[] copy = number;

            return copy;
        }
    }
}
