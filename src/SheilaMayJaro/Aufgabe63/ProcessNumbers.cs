using System; 
namespace Appdevhb25.SheilaMayJaro.Aufgabe63
{
    public class ProcessNumbers
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 63)");
            int[] numbers = [0, -23, 49, 57, -19, 5, 1, -3, 13, 56, -68];
            int[] result = SortNumbers(numbers); 

            foreach(int number in result)
            {
                System.Console.WriteLine(number);
            }
        }
        static int[] SortNumbers(int[] numbers)
        {
            int[] result = new int[2]; 
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    result[0]++;  ;
                }
                else
                {
                    result[1] += numbers[i]; 
                }
            }
            return result; 
        }
    }
}