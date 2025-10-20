using System;
using System.ComponentModel;
using System.Text;

namespace Appdevhb25.MarcelSimma.Aufgabe39 {
    public class CountLetters
    {
        public static void Start()
        {

            Console.Clear();

            /*
            Aufgabe 45: Erstelle eine Methode, das ausgibt, wie oft einzelne Buchstaben und Zeichen im Text vorkommen.
            */



            /*
            1. Aufgabe durchlesen und verstehen.
            2. Offene Fragen klären. 
            3. Teilaufgaben definieren, EVA-Prinzip
            3.1. Eingabe (text, der untersucht werden soll)
            3.2. Verarbeitung
            3.3. Ausgabe (Liste, die angibt, wie oft ein bestimmtes Zeichen vorkommt.)

            3.1. Eingabe
            */

            string text = "Das ist ein Satz.";

            /*
            3.2. Verarbeitung

            Zusammenhang in der ASCII-Tabelle zwischen Int und Char
            */

            int[] asciiTable = new int[128];

            /*
            foreach (char elem in text)
            {
                asciiTable[(int)elem]++;
                //System.Console.WriteLine(elem + " " + (int)elem);
            }
            */

            // Alternative zur obenstehenden foreach-Schleife
            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];

                asciiTable[(int)currentLetter]++;
            }
            
            // 32 < i < 127: Die Befehle in der ASCII-Tabelle werden übersprungen.
            for (int i = 32; i < asciiTable.Length - 1; i++)
            {
                // nur gefundene Zeichen ausgeben
                if (asciiTable[i] > 0)
                {
                    System.Console.WriteLine(asciiTable[i] + " " + (char)i);
                }
            }

        }
    }
}