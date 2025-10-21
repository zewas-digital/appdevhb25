using System.Text.RegularExpressions;

namespace Appdevhb25.KerimAlkis.Bonusaufgabe14
{
    public class ValidateEmail
    {
        public static void Start()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Email-Checker");

                string email = Console.ReadLine();

                string pattern = @"^[A-Za-z0-9._%+][A-Za-z0-9._%+-]+[A-Za-z0-9._%+]@[A-Za-z0-9][A-Za-z0-9-]+[A-Za-z0-9]\.[A-Za-z0-9]{2,}$";

                Console.WriteLine((Regex.IsMatch(email, pattern)));
                Console.ReadKey();

            } while (true);
        }
    }
}