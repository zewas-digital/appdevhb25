using System.Collections.Immutable;
using System.ComponentModel;

namespace Appdevhb25.JonaSchnell.AufgabenFirma
{
    public class Aufgabe1
    {
        public static void StartFirma1()
        {

            string satz = "Hallo Welt dies ist ein Satz der sehr lange aber einfach ist.";
            string[] satzInArray = SelfmadeSplitMethode(satz, " ");

            foreach (string wort in satzInArray)
            {
                System.Console.WriteLine(wort);
            }
        }
        public static string[] SelfmadeSplitMethode(string satz, string separator)
        {
            int begin = 0;
            int ende = satz.IndexOf(separator, begin);
            int i = 1;
            int length = CountWords(satz, separator) + 1;
            string[] substrings = new string[length];

            while (true)
            {

                if (ende >= 0 && ende <= satz.Length)
                {
                    string substring = satz.Substring(begin, ende - begin);

                    begin = ende + separator.Length;

                    ende = satz.IndexOf(separator, begin);

                    substrings[i] = substring;
                }
                else
                {
                    ende = begin;

                    string substring = satz.Substring(begin, satz.Length - ende);
                    substrings[i] = substring;
                    break;
                }
                i++;
            }
            return substrings;
        }

        /// <summary>
        /// "countWords" zählt die Wörter die im string "satz" vorkommen.
        /// </summary>.ToArray
        /// <param name="satz"></param>
        /// <param name="separator"></param>
        /// <returns> Gibt die Anzahl der Wörter in "satz" zurück. </returns>
        public static int CountWords(string satz, string separator)
        {
            //length muss mit 1 beginnen da es immer 1 wort mehr gibt als separatoren
            int length = 1;
            int newWordStarts = 0;
            while (newWordStarts <= satz.Length && newWordStarts >= 0)
            {
                int position = satz.IndexOf(separator, newWordStarts);
                if (position >= 0)
                {
                    //seperator gefunden
                    newWordStarts = separator.Length + position;
                    length++;
                }
                else
                {
                    //seperator nicht gefunden
                    break;

                }
            }
            return length;
        }
        // public static string[] SplitMethodeWithList(string satz, string separator)
        // {
        //     List<string> words = new List<string>();
        //     string[] wordsInArray = new string[satz.Length];
        //     int begin = 0;
        //     int ende = satz.IndexOf(separator, begin);
        //     while (true)
        //     {
        //         if (ende >= 0 && ende <= satz.Length)
        //         {
        //             words.Add(satz.Substring(begin, ende - begin));
        //             begin = ende + separator.Length;
        //             ende = satz.IndexOf(separator, begin);
        //         }
        //         else
        //         {
        //             ende = begin;
        //             words.Add(satz.Substring(begin, satz.Length - ende));
        //             words.Add(satz.Substring(ende, satz.Length - begin));
        //             break;
        //         }
        //         wordsInArray = words.ToArray();
        //     }
        //     return wordsInArray;
        //}
    }
}
