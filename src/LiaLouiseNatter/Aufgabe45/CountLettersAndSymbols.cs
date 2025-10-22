using System;
using System.Globalization;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe45
{
    public class CountLettersAndSymbols
    {
        public static void Start()
        {
            string hesseText = text();
            CharCounter(hesseText);
            
        }

        public static string text()
        {
            string hesseText =
            @"            The quick brown fox jumps over the lazy dog. 
            You can't get rid of me! Assign the address of number to a pointer.";
            return hesseText;
        }

        public static void CharCounter(string hesseText)
        {
            int[] counter = new int[128];

            foreach (char c in hesseText)
            {
                if (c < 128)
                {
                    counter[c]++;
                }
                else
                {
                    System.Console.WriteLine("Fehler");
                }
            }

            for(int i = 0; i < counter.Length; i++)
            {
                if(counter[i] > 0)
                {
                    System.Console.WriteLine($"{(char)i} : {counter[i]}, ASCII Wert: {Convert.ToInt32(hesseText[i])}");
                }
            }
        }

    }
}    

