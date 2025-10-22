using System;
using System.ComponentModel;

namespace Appdevhb25.MarcelSimma {
    public class RepetitionStringMethodsDocumentation
    {

        /*
        Aufgabe 44.4 sinngemäß: Gib die Anzahl der Wörter aus. 
        */

        public static void Start()
        {

            Console.Clear();
            string text = "Dies ist ein     Satz. ";

            // Elemente ohne Inhalte ("") sind im Array enthalten. Daher 9 Elemente
            string[] splitted = text.Split(" ", StringSplitOptions.None);

            // Elemente ohne Inhalte ("") sind nicht im Array enthalten. Daher nur 4 Elemente = 4 Wörter
            string[] splitted2 = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            // --> Schau dir die beiden Arrays im Debug-Mode an.

            System.Console.WriteLine(splitted.Length); // 9
            System.Console.WriteLine(splitted2.Length); // 4


            // Aufruf der Methode mit einem Argument für den optionalen Parameter.
            WeekdayAndTime("Dienstag", "abend");
            // Aufruf der Methode ohne ein Argument für den optionalen Parameter. In diesem Fall wird der Standardwert für den optionalen Parameter verwendet. 
            WeekdayAndTime("Montag");
        }

        public static void WeekdayAndTime(string weekday, string time = "morgen")
        // Indem ich time mit einem Standardwert versehe wird dieser Parameter als optional markiert.
        {
            System.Console.WriteLine(weekday + time);
        }
    }
}