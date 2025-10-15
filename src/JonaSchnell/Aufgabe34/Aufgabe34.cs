using System.ComponentModel;

namespace Appdevhb25.JonaSchnell.Aufgabe34
{
    public class Aufgabe34
    {


        public static void Start34()
        {
            ArrayChanger();
        }

        public static Array ArrayChanger()
        {
            Random random = new Random();
            int[] randomArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                randomArray[i] += random.Next(1, 9);
                System.Console.WriteLine(randomArray[i]);
            }
            System.Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(randomArray[i]);
            }
            return randomArray;
        }
    }
}
