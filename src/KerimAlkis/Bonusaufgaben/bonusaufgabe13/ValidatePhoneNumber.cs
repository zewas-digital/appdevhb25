using System.Text.RegularExpressions;

namespace Appdevhb25.KerimAlkis.Bonusaufgabe13
{
    public class ValidatePhoneNumber
    {
        public static void Start()
        {   
            Console.WriteLine("Nummer-Checker:");
            do
            {
                string nummer = Console.ReadLine();
                
                string pattern = @"^((\+|00)([0-9]{1,3})|0)[\s\-\(]?([0-9]{1,5})[\s\-\)]?([0-9]{3,10})$";

                Console.WriteLine((Regex.IsMatch(nummer, pattern)));

            } while (true);
        }
    }
}