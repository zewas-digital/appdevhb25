namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class ProcessNumbers
    {
        public static void Start()
        {
            int[] numbers = [100, -6, 23, -87, 1, 0, 77, -543];
            int[] processed = new int[2];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                    processed[0]++;
                else
                    processed[1] += numbers[i];
            }

            Console.WriteLine($"[{processed[0]}, {processed[1]}]");
        }
    }
}