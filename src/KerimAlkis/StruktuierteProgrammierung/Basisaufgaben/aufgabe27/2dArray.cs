namespace Appdevhb25.KerimAlkis.Aufgabe27
{
    public class Array2d
    {
        public static void Start()
        {
            Console.WriteLine("Wie viele Zeilen und Spalten willst du generieren");

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

            int[,] numberArray = new int[number,number];

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    numberArray[i, j] = rndZahl.Next(0, 10);
                }
            }

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(numberArray[i, j] + " ");
                }
                Console.WriteLine();
            }


            System.Console.WriteLine();

            int[] zeilenSumme = new int[number];
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    zeilenSumme[i] += numberArray[i, j];
                }
            }
            foreach (int zahl in zeilenSumme)
            {
                Console.WriteLine(zahl);
            }

            System.Console.WriteLine();

            int[] spaltenSumme = new int[number];
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    spaltenSumme[i] += numberArray[j, i];
                }
            }
            foreach (int zahl in spaltenSumme)
            {
                Console.WriteLine(zahl);
            }
            

        }
    }
}