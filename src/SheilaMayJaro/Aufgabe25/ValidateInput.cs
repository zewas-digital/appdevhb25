using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe25
{
    public class ValidateInput
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 25)");
            PrintValidateInput();
            PrintValidateInputTwo();
            PrintValidateInputThree(); 

        }
        public static int PrintValidateInput()
        {
            string input = Console.ReadLine() ?? string.Empty;
            int number;
            while (int.TryParse(input, out number) == false)
            {
                Console.WriteLine("Geben Sie bitte eine Zahl ein.");
                input = Console.ReadLine() ?? string.Empty;
            }
            return number;

        }
        public static decimal PrintValidateInputTwo()
        {
            string input = Console.ReadLine() ?? string.Empty;
            decimal number;
            while (decimal.TryParse(input, out number) == false)
            {
                Console.WriteLine("Geben Sie bitte eine Gleitkommazahl ein.");
                input = Console.ReadLine() ?? string.Empty;
            }
            return number;
        }
        public static bool PrintValidateInputThree()
        {
            string input = Console.ReadLine() ?? string.Empty;
            bool name;
            while (bool.TryParse(input, out name) == false)
            {
                Console.WriteLine(@"Geben Sie ""true"" oder ""false"" ein.");
                input = Console.ReadLine() ?? string.Empty;
            }
            return name; 
        }
    }
}
