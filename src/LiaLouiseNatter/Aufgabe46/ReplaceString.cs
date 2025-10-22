using System;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe46
{
    public class ReplaceString
    {
        public static void Start()
        {
            string textGuterTag = text();
            Replacer(textGuterTag);
            DeleteLower(textGuterTag);
            DeleteUpper(textGuterTag);
            DeleteSpace(textGuterTag);
            DeleteExclemation(textGuterTag);
        }

        public static string text()
        {
           string textGuterTag = @"Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            return textGuterTag;
        }

        public static void Replacer(string textGuterTag)
        {
            string toReplace = "wird";
            string replaceWith = "war und ist";
            if (textGuterTag.Contains(toReplace))
            {
                textGuterTag = textGuterTag.Replace(toReplace, replaceWith);
            }
            System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine(textGuterTag);

        }

        public static void DeleteLower(string textGuterTag)
        {
            string regex = "[a-z]";
            textGuterTag = Regex.Replace(textGuterTag, regex, "");
            System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine(textGuterTag);
        }

        public static void DeleteUpper(string textGuterTag)
        {
            string regex = "[A-Z]";
            textGuterTag = Regex.Replace(textGuterTag, regex, "");
            System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine(textGuterTag);
        }

        public static void DeleteSpace(string textGuterTag)
        {
            string regex = " ";
            textGuterTag = Regex.Replace(textGuterTag, regex, "");
            System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine(textGuterTag);
        }

        public static void DeleteExclemation(string textGuterTag)
        {
            string regex = "!";
            textGuterTag = Regex.Replace(textGuterTag, regex, "");
            System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine(textGuterTag);
        }
        // regex = regualr expression, Zum Manipulieren, suchen, ...
        


        


    }
}

