using System;
using System.ComponentModel;

namespace Appdevhb25.MarcelSimma.Aufgabe39 {
    public class CountLetters
    {
        public static void Start()
        {

            string text = "Hallo!";

            char[] textInChar = text.ToCharArray();

            for (int i = 0; i < textInChar.Length; i++)
            {
                System.Console.WriteLine(textInChar[i] + " ASCII-Code: " + (int)textInChar[i]);
            }

        }
    }
}