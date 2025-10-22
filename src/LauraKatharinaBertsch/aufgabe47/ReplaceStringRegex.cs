using System.Text.RegularExpressions;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe47
{
    public class ReplaceStringReggex
    {
        public static void Start()
        {
            withoutSmallLetters();
            withoutBigLetters();
            withoutSpace();
            withoutCallSign();
        }

        public static void withoutSmallLetters()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string pattern = "[a-z]";
            Regex reggex = new Regex(pattern);
            string result = reggex.Replace(text, "");
            Console.WriteLine(result);
        }
        public static void withoutBigLetters()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string patter = "[A-Z]";
            Regex regex = new Regex(patter);
            string result = regex.Replace(text, "");
            Console.WriteLine(result);
        }
        public static void withoutSpace()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string patter = "[ ]";
            Regex regex = new Regex(patter);
            string result = regex.Replace(text, "");
            Console.WriteLine(result);
        }
        public static void withoutCallSign()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string patter = "[!]";
            Regex regex = new Regex(patter);
            string result = regex.Replace(text, "");
            Console.WriteLine(result);
        }
    }
}