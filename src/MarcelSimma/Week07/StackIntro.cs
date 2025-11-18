using System.Globalization;

namespace Appdevhb25.MarcelSimma.Week07
{
    public class StackIntro
    {
        public static void Start()
        {
            Stack<string> numbers = new Stack<string>();

            numbers.Push("one");
            numbers.Push("zwei");
            numbers.Push("drei");

           string temp = numbers.Pop();
            System.Console.WriteLine(temp);

            System.Console.WriteLine(numbers.Pop());

            System.Console.WriteLine(numbers.Contains("one"));
            
            
        }
    }
}

