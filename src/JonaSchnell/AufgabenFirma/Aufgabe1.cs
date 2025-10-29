using System.ComponentModel;
using System.Reflection;

namespace Appdevhb25.JonaSchnell.AufgabenFirma
{
    public class Aufgabe1
    {
        public static void StartFirma1()
        {

            string satz = "Hallo Welt dies ist ein Satz.";
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

            while (ende <= satz.Length)
            {

                if (ende >= 0 && ende <= satz.Length)
                {
                    string substring = satz.Substring(begin, ende - begin);
                    Console.WriteLine(substring);
                    begin = ende + separator.Length;
                    ende = satz.IndexOf(separator, begin);
                }
                else
                {
                    ende = begin;
                    string substring = satz.Substring(begin, satz.Length - ende);
                    Console.WriteLine(substring);
                    break;
                }
                
            }
            return [];
        }
    }
}
