using System;
using System.ComponentModel;

namespace Appdevhb25.MarcelSimma.Aufgabe39 {
    public class CountLetters
    {
        public static void Start()
        {
            // Ausgangstext
            string text = "Hallo!";

            // Umwandlung in ein Char-Array
            char[] textInChar = text.ToCharArray();

            // Jedes Zeichen (= Char) kann mit einem Cast in einen Integer umgewandelt werden. Dieser Wert entspricht dem Dezimalwert des Zeichens in der ASCII-Tabelle. 
            for (int i = 0; i < textInChar.Length; i++)
            {
                System.Console.WriteLine(textInChar[i] + " ASCII-Code: " + (int)textInChar[i]);
            }

        }
    }
}