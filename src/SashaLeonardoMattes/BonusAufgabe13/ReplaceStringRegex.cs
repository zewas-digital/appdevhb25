using System;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Text.RegularExpressions;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe13
{

    public class ReplaceStringRegex
    {

        public static void StartReplaceStringRegex()
        {
            Console.WriteLine("----------Bonusaufgabe 13---------");

            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string result;

            System.Console.WriteLine("wird mit war und ist ersetzen:");
            result = Regex.Replace(text, "wird", "war und ist");
            System.Console.WriteLine(result);

            System.Console.WriteLine("Lösche alle Kleinbuchstaben:");
            result = Regex.Replace(text, "[a-z]", "");
            System.Console.WriteLine(result);

            System.Console.WriteLine("Lösche alle Großbuchstaben:");
            result = Regex.Replace(text, "[A-Z]", "");
            System.Console.WriteLine(result);

            System.Console.WriteLine("Ohne Leerzeichen:");
            result = Regex.Replace(text, "\\s", "");
            System.Console.WriteLine(result);


            System.Console.WriteLine("Ohne Rufezeichen: ");
            result = Regex.Replace(text, "!", "");
            System.Console.WriteLine(result);
        }


    }
}
