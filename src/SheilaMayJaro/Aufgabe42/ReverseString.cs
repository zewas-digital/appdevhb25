using System; 
namespace Appdevhb25.SheilaMayJaro.Aufgabe42
{
    public class ReverseString
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 42)");
            string word = "Blume";
            char[] chars = word.ToCharArray();
            Console.WriteLine(word);
            Console.Write(PrintStringReverse(chars));
            System.Console.WriteLine();
            System.Console.WriteLine("Fügen Sie ein Wort ein.");
            string userInput = Console.ReadLine();
            char[] charsUserInput = userInput.ToCharArray();
            Console.WriteLine(userInput);
            Console.Write(PrintStringReverse(charsUserInput)); 
             

        }
        public static char[] PrintStringReverse(char[] array)
        {
            char[] charReversed = new char[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                charReversed[i] = array[array.Length - i - 1];
            }
            return charReversed;
        }
    }
}