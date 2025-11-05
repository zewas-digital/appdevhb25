using System.Text.RegularExpressions;

namespace Appdevhb25.KerimAlkis.Bonusaufgabe12
{
    public class ReplaceStringRegex
    {
        public static void Start()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";


            string ersetze = Regex.Replace(text, "wird", "war und ist");
            Console.WriteLine("1. " + ersetze);

            string ohneKlein = Regex.Replace(text, "[a-z]", " ");
            Console.WriteLine("2. " + ohneKlein);

            string ohneGross = Regex.Replace(text, "[A-Z]", " ");
            Console.WriteLine("3. " + ohneGross);

            string ohneLeer = Regex.Replace(text, " ", "");
            Console.WriteLine("4. " + ohneLeer);

            string ohneRuf = Regex.Replace(text, "!", " ");
            Console.WriteLine("5. " + ohneRuf);
        }
        
    }
}