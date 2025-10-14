namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe38
{
    public class PascalDreieck
    {
        public static void Start()
        {

            Console.WriteLine("Gib eine Zahl zwischen 1 und 20 ein");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[,] twoDArray = new int[lenght, lenght];


            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        twoDArray[i, j] = 1;
                    }
                    else
                    {
                        twoDArray[i, j] = twoDArray[i - 1, j] + twoDArray[i, j - 1];
                    }
                }
            }

            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    Console.Write(twoDArray[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}