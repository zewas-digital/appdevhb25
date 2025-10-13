namespace Appdevhb25.KerimAlkis.Bonusaufgabe09
{
    public class BubbleSort
    {
        public static void Start()
        {
            Console.WriteLine("BubbleSort-Algorithmus");
            Console.WriteLine("Wie viele Zahlen willst du generieren");

            int number = 0;
            do
            {
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    number = inputNumber; break;
                }
                else { Console.WriteLine("Versuchs Nochmal"); }
            } while (true);

            Random rndZahl = new Random();

            int[] numberArray = new int[number];

            for (int i = 0; i < number; i++)
            {
                numberArray[i] = rndZahl.Next(0, 100);
            }

            Console.WriteLine();
            Console.WriteLine("Auflistung:");
            foreach(int zahl in numberArray)
            {
                Console.WriteLine(zahl);
            }

            BubbleSorting(numberArray);

            Console.WriteLine("Auflistung:");
            foreach(int zahl in numberArray)
            {
                Console.WriteLine(zahl);
            }



        }
        

        public static int[] BubbleSorting(int[] numberArray)
        {
            for(int i = 0; i < numberArray.Length-1; i++)
            {
                for(int j = 0; j < numberArray.Length-1-i; j++)
                {
                    if(numberArray[j] > numberArray[j + 1])
                    {
                        int temp = numberArray[j + 1];
                        numberArray[j + 1] = numberArray[j];
                        numberArray[j] = temp;
                    }
                }
            }

            return numberArray;
        }
    }    
}