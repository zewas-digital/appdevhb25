using System;
using System.Text.RegularExpressions;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class ReplaceString
    {
        public static void Start()
        {
            string text = @"Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string textNew = text.Replace("wird", "war und ist");
            string textOhneKlein = "";
            string textOhneGross = "";

            foreach (char elem in text)
            {
                if (!char.IsLower(elem))
                    textOhneKlein += elem;
                if (!char.IsUpper(elem))
                    textOhneGross += elem;
            }

            string textOhneLeer = text.Replace(" ", null);
            string textOhneRuf = text.Replace("!", null);

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