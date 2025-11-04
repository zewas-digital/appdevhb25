using System.Runtime.InteropServices;

namespace Appdevhb25.JonaSchnell.Aufgabe63
{
    public class Aufgabe63
    {

        public static void ProcessNumbers()
        {

            int[] numbers = new int[5];
            for (int x = 0; x < 5; x++)
            {
                System.Console.WriteLine("Gib eine Zahl ein.");
                numbers[x] = Convert.ToInt32(Console.ReadLine());
            }
            int[] resultArray = ArrayOutgiver(numbers);
            System.Console.WriteLine(resultArray[0] + " , " + resultArray[1]);
        }
        public static int[] ArrayOutgiver(int[] numbers)
        {
            int y = 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] < 0)
                {
                    y++;
                }
                if (numbers[i] >= 0)
                {
                    sum = sum + numbers[i];
                }
            }
            
            return [y, sum];
        }
    }
}
