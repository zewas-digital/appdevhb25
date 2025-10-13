using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe32
{

    public class CopyArrayReverse
    {

        public static void StartCopyArrayReverse()
        {
            Console.WriteLine("----------Aufgabe 32----------");

            Random rndGen = new Random();
            int[] myArray = new int[3];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rndGen.Next(1, 101);
            }

            int[] copiedArray = CopyReverseAny(myArray);

            foreach (var number in copiedArray)
            {
                System.Console.WriteLine(number);
            }

        }

        public static int[] CopyReverse(int[] inputArray)
        {
            int[] arrayCopy = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                arrayCopy[i] = inputArray[inputArray.Length - i - 1]; //-1 weil .Lenght bei 1 startet und Index bei 0
            }
            return arrayCopy;
        }
        
        public static T[] CopyReverseAny<T>(T[] inputArray)
        {
            T[] arrayCopy = new T[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                arrayCopy[i] = inputArray[inputArray.Length - i - 1];
            }
            return arrayCopy;
        }
        
    }
}
