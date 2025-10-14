namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe35
{
    public class BubbleSort
    {
        public static void Start()
        {

            int[] numbers = { 1, 3, 6, 3, 9, 7, };
            int sortedNumbers = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (sortedNumbers < numbers[i])
                {
                    sortedNumbers = numbers[i];
                    Console.WriteLine(sortedNumbers);
                }

            }
            Console.WriteLine("Die Zahlen der Größe nach sortiert sehen so aus:");
            Console.WriteLine(sortedNumbers);

        }
    }
}