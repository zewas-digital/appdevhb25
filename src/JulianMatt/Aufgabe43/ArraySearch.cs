using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe43
{
    public class ArraySearch
    {

        public static void Start43()
        {
            string[] input = StringMaker();
            LookForArray(input);
        }

        public static string[] StringMaker()
        {
            string[] input;

            input = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Geben sie ein Wort ein: ");
                input[i] = Console.ReadLine();
                Console.WriteLine();
            }
            return input;
        }

        public static void LookForArray(string[] input)
        {
            while (true)
            {
                Console.WriteLine("Die Möglich wörter bei dennen sie den index nachschauen können:");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(input[i]+" ");
                }
            }
        }
       
    }



}