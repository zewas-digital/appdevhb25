using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class CountLettersAndSymbols
    {
        public static void Start()
        {
            string text = "The quick brown fox jumps over the lazy dog. You can't get rid of me! Assign the address of number to a pointer.";
            char[] zeichen = text.ToCharArray();

            for (int j = 33; j <= 122; j++)
            {
                int anzahl = 0;
                for (int i = 0; i < zeichen.Length; i++)
                {
                    if (zeichen[i] == j)
                        anzahl++;
                }
                if (anzahl != 0)
                    Console.WriteLine($"{(char)j}: {anzahl}");
            }
        }
    }
}