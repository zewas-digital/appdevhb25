using System;
using System.ComponentModel;

namespace Appdevhb25.JonaSchnell.Aufgabe45
{
    public class Aufgabe45
    {
        public static void Start45()
        {
            string text = "The quick brown fox jumps over the lazy dog. You can't get rid of me! Assign the address of number to a pointer.";

            char[] textInChar = text.ToCharArray();

            for (int i = 0; i < textInChar.Length; i++)
            {
                //Console.WriteLine(textInChar[i] + " ASCII_Code: " + (int)textInChar[i]);

                for (int j = 0; j < textInChar.Length; j++)
                {
                    int a = 0;
                    if (j == (int)textInChar[i])
                    {
                        a++;
                        Console.WriteLine(j);
                    }
                }
            }
        }
    }
}