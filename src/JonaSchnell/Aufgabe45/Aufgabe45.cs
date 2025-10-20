using System;
using System.ComponentModel;

namespace Appdevhb25.JonaSchnell.Aufgabe45
{
    public class Aufgabe45
    {
        public static void Start45()
        {
            string text = "The quick brown fox jumps over the lazy dog. You can't get rid of me! Assign the address of number to a pointer.";

            for (int i = 33; i <= 126; i++)
            {
                int count = 0;

                foreach (char elem in text)
                {
                    if (elem == (char)i)
                    {
                        count++;
                    }
                }
                Console.WriteLine((char)i + " = " + count);
            }
        }
    }
}