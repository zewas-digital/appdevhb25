using System;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class ReplaceStringRegex
    {
        public static void Start()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            string textNew = Regex.Replace(text, "^w..d$", "war und ist");
            string textOhneKlein = Regex.Replace(text, "[a-z]", "");
            string textOhneGross = Regex.Replace(text, "[A-Z]", "");
            string textOhneLeer = Regex.Replace(text, "\\s", "");
            string textOhneRuf = Regex.Replace(text, "\\W", "");

            Console.WriteLine();
            Console.WriteLine(textNew);
            Console.WriteLine();
            Console.WriteLine(textOhneKlein);
            Console.WriteLine();
            Console.WriteLine(textOhneGross);
            Console.WriteLine();
            Console.WriteLine(textOhneLeer);
            Console.WriteLine();
            Console.WriteLine(textOhneRuf);
            Console.WriteLine();
        }
    }
}