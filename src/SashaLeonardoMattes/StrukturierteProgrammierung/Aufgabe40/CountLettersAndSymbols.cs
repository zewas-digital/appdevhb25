using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe40
{

    public class CountLettersAndSymbols
    {

        public static void StartCountLettersAndSymbols()
        {
            Console.WriteLine("----------Aufgabe 40----------");

            System.Console.WriteLine("Gib ein Wort ein: ");

            string text = "The quick brown fox jumps over the lazy dog. You can't get rid of me! Assign the address of number to a pointer.";

            int[] amountFound = new int[128];

            char[] chars = text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                amountFound[Convert.ToInt16(chars[i])]++;
            }

            for (int i = 0; i < amountFound.Length; i++)
            {
                char c = Convert.ToChar(i);
                string displayChar;

                if (char.IsControl(c))
                {
                    displayChar = Regex.Escape(c.ToString()); //für Sonderzeichen (tab, zeilenumbruch, ...)
                    System.Console.WriteLine("Vorkommnisse \'" + displayChar + "\': " + amountFound[i] + " Integer Wert: " + i);

                }
                else
                {
                    System.Console.WriteLine("Vorkommnisse \'" + Convert.ToChar(i) + "\': " + amountFound[i] + " Integer Wert: " + i);
                }
                
            }

        }


    }
}
