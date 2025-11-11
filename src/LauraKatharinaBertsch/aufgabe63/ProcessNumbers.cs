namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe63
{
    public class ProcessNumbers
    {
        public static void Start()
        {
            int[] output = numbers();
            Console.WriteLine($"[{output[0]}, {output[1]}]");
        }
        public static int[] numbers()
        {
            int[] numbers = [100, -6, 23, -87, 1, 0, 77, -543];
            int sum = 0;
            int amount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    sum = sum + numbers[i];
                }
                else
                {
                    amount = amount + 1;
                }
            }
            int[] output = { amount, sum };
            return output;
        }
    }
}