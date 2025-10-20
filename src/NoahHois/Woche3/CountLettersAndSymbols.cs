using System;

namespace Appdevhb25.NoahHois.Aufgabe35
{
    public class CountLettersAndSymbols
    {
        public static void Start35()
        {
            string s = "The quick brown fox jumps over the lazy dog. You can't get rid of me! Assign the address of number to a pointer.";
            int[] characterCounter = new int[128];

            for (int i = 0; i < s.Length; i++)
            {
                char a = s[i];
                int currentCount = characterCounter[a];
                currentCount++;
                characterCounter[a] = currentCount;
            }

            for (int j = 0; j < characterCounter.Length; j++)
            {
                int currentCount = characterCounter[j];
                if (currentCount > 0)
                {
                    Console.WriteLine((char)j + " " + currentCount);
                }
            }
        }
    }
}