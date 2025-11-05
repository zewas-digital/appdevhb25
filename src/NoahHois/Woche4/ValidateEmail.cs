using System.Text.RegularExpressions;

namespace Appdevhb25.NoahHois.BonusAufgabe8
{
    public class ValidateEmail
    {
        public static void Start()
        {
            Console.WriteLine("Gib deine Telefonnummer ein: ");
            string? input = Console.ReadLine();
            input = "^[a-z,A-Z,0-9,.,_,%,+,-]+@([a-z,A-Z]+\\.){1,}[a-z]{2,}$";
            Regex email = new Regex(input);
            if (email.IsMatch(input))
            {
                Console.WriteLine("Die Telefonnummer ist gültig");
            }
            else
            {
                Console.WriteLine("Die Telefonnummer ist ungültig");
            }
        }
    }
}