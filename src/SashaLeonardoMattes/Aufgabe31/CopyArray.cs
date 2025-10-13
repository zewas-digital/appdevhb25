using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe31
{

    public class CopyArray
    {

        public static void StartCopyArray()
        {
            Console.WriteLine("----------Aufgabe 31----------");

            Random rndGen = new Random();

            int[] myArray = new int[3];
            
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rndGen.Next(1, 101);
            }

            int[] copiedArray = Copy(myArray);

            foreach (var number in copiedArray)
            {
                System.Console.WriteLine(number);
            }

           

        }

        public static int[] Copy(int[] inputArray)
        {
            int[] arrayCopy = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i == 0)
                {
                    arrayCopy[i] = -1;
                }
                else
                {
                    arrayCopy[i] = inputArray[i];
                }
            }
            return arrayCopy;
        }
        
    }
}
