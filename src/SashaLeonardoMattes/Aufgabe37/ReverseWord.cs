using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe37
{

    public class ReverseWord
    {

        public static void StartReverseWord()
        {
            Console.WriteLine("----------Aufgabe 37----------");

            System.Console.WriteLine("Gib ein Wort ein: ");
            string word = Helper.checkUserInputString();
            char[] chars = word.ToCharArray();

            Array.Reverse(chars);
            

            foreach (var character in chars)
            {
                System.Console.Write(character);
            }

        }
        
        
    }
}
