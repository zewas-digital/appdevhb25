using System.Text.RegularExpressions;

namespace Appdevhb25.NoahHois.BonusAufgabe6
{
    public class ReplaceStringRegex
    {
        public static void Start()
        {
            string input = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            // 1.
            string patternP1 = "[a-z]";
            Regex regexP1 = new Regex(patternP1);
            string replacedStringP1 = regexP1.Replace(input, "");
            Console.WriteLine(replacedStringP1);

            // 2.
            string patternP2 = "[A-Z]";
            Regex regexP2 = new Regex(patternP2);
            string replacedStringP2 = regexP2.Replace(input, "");
            Console.WriteLine(replacedStringP2);

            // 3.
            string patternP3 = " ";
            Regex regexP3 = new Regex(patternP3);
            string replacedStringP3 = regexP3.Replace(input, "");
            Console.WriteLine(replacedStringP3);

            // 4.
            string patternP4 = "!";
            Regex regexP4 = new Regex(patternP4);
            string replacedStringP4 = regexP4.Replace(input, "");
            Console.WriteLine(replacedStringP4);
        }
    }
}