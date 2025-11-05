using System.Text.RegularExpressions;

namespace Appdevhb25.NoahHois.BonusAufgabe7
{
    public class ValidatePhoneNumber
    {
        public static void Start()
        {
            Console.WriteLine("Gib deine Telefonnummer ein: ");
            string? input = Console.ReadLine();
            input = "^(\\+|00)[0-9]{1,3}[ ,-]?[0-9]{1,5}?[ ,-]?[0-9]{3,10}";
            Regex phoneNumber = new Regex(input);
            if (phoneNumber.IsMatch(input))
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