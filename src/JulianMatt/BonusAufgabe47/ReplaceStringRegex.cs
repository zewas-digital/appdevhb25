using System.Text.RegularExpressions;

namespace Appdevhb25.JulianMatt.Bonusaufgabe47
{
    public class ReplaceStringRegex
    {

        public static void BonusStart47()
        {
            string txt = StringMaker();
            Writetxt(txt);
        }

        public static string StringMaker()
        {
            // string hessenTxt = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            // return hessenTxt;
            return "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
        }

        public static void Writetxt(string txt)
        {
            txt = txt.Replace("wird", "war und ist");
            Console.WriteLine("Der Text");
            Console.WriteLine(txt);
            Console.WriteLine();

            string pattern = "[a-z]";
            Regex regs = new Regex(pattern);
            string result = regs.Replace(txt, " ");
            Console.WriteLine("Text ohne Kleinbuchstaben:");
            Console.WriteLine(result);
            Console.WriteLine();


            pattern = "[A-Z]";
            regs = new Regex(pattern);
            result = regs.Replace(txt, " ");
            Console.WriteLine("Text ohne Großbuchstaben:");
            Console.WriteLine(result);
            Console.WriteLine();


            pattern = "[ ]";
            regs = new Regex(pattern);
            result = regs.Replace(txt, "");
            Console.WriteLine("Text ohne Leerzeichen:");
            Console.WriteLine(result);
            Console.WriteLine();

            pattern = "[!]";
            regs = new Regex(pattern);
            result = regs.Replace(txt, " ");
            Console.WriteLine("Text ohne Ausrufezeichen:");
            Console.WriteLine(result);
        }



    }
}