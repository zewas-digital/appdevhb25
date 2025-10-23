namespace Appdevhb25.KerimAlkis.Aufgabe26
{
    public class CopyReverse
    {
        public static void Start()
        {
            ArrayReverser();
        }

        public static Array ArrayReverser()
        {
            Random random = new Random();
            int[] randomArray = new int[10];
            System.Console.Write("Your Original Random Array: ");
            for (int i = 0; i < 10; i++)
            {
                randomArray[i] += random.Next(1, 9);
                System.Console.Write(randomArray[i]);
            }
            System.Console.WriteLine();
            
            int[] ReverseArray = new int[randomArray.Length];
            System.Console.WriteLine();
            System.Console.Write("Your new Random Array: ");
            for (int i = randomArray.Length - 1; i >= 0; i--)
            {
                ReverseArray[randomArray.Length - i - 1] = randomArray[i];
                System.Console.Write(randomArray[i]);
            }
        
            return randomArray;
            
                 
        }

    }    
}