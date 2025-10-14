using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe34
{
    public class CopyReverse
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 34)");
            int[] randomNumbersArray = new int[5];
            PrintRandomNumbers(randomNumbersArray);
            Console.WriteLine("Array:");
            foreach (int item in randomNumbersArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Array Reversed:");
            int[] randomNumbersArrayReversed = PrintArrayReversed(randomNumbersArray); 
            foreach (int item in randomNumbersArrayReversed)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] PrintRandomNumbers(int[] array)
        {
            Random zufallsgenerator = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = zufallsgenerator.Next(1, 101); //inklusive 100 deshalb 101 
            }
            return array;
        }
        public static int[] PrintArrayReversed(int[] array)
        {
            int[] arrayReversed = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayReversed[i] = array[array.Length - i - 1]; //arrayReversed[0] = array [5-0-1 = 4] damit der Anfang vom arrayReversed beim Ende von array beginnt
            }
            return arrayReversed; 
        }
    }
}