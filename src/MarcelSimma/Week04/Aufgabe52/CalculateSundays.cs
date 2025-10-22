namespace Appdevhb25.MarcelSimma.Aufgabe52
{
    public class CalculateSundays
    {
        public static void Start()
        {
            /* 
            Aufgabe 52: 

            Ermittle das Datum der nächsten drei Sonntage von heute weg. 
            Gib die Daten der drei Sonntage mit unterschiedlichen Formatierungen aus.

            1. Aufgabe lesen und verstehen
            2. offene Fragen klären
            3. Teilaufgabe definieren
            3.1. Eingaben
            3.2. Verarbeitung
            3.3. Ausgabe
            */

            // Basisüberlegung
            CalculateNextSunday();

            // Lösung mit While-Schleife
            CalculateSundaysWhile();

            // Lösung mit For-Schleife (Bonus)
            CalculateNextSundayFor();

        }

        public static void CalculateNextSunday()
        {
            /*
            3.1. Eingaben
            */

            DateTime today = DateTime.Now;

            /*
            3.2. Verarbeitung
            Welcher Wochentag ist heute?
            */

            Console.WriteLine((int)today.DayOfWeek);

            // Wir gehen solange einen Tag weiter, bis wir einen Sonntag gefunden haben.
            while (today.DayOfWeek != DayOfWeek.Sunday)
            {
                today = today.AddDays(1);
            }

            // Der Compiler sucht automatisch nach einer ToString()-Methode, wenn ich sie nicht hinschreibe. 
            // Ausgabe des ersten gefundenen Sonntags
            System.Console.WriteLine(today.ToString());

        }

        public static void CalculateSundaysWhile()
        {
            /*
            3.1. Eingaben
            */

            DateTime today = DateTime.Now;

            /*
            3.2. Verarbeitung
            */

            int foundSundays = 0;

            while (foundSundays < 3)
            {
                if (today.DayOfWeek == DayOfWeek.Sunday)
                {
                    // $"{foundSundays++}" --> Zuerst wird der Wert ausgegeben und anschließend um eines erhöht.
                    // $"{++foundSundays}" --> Der Wert wird zuerst um eines erhöht und anschließend ausgegeben.
                    System.Console.WriteLine($"Sonntag Nr. {++foundSundays}: " + today);

                }
                // Inkrement
                today = today.AddDays(1);
            }
        }

        public static void CalculateNextSundayFor()
        {
            /*
            3.1. Eingaben
            */

            DateTime today = DateTime.Now;

            /*
            3.2. Verarbeitung
            */
            
            // DayOfWeek ist ein Enum. Die Werte (Values) des Enums entsprechen Integern: https://learn.microsoft.com/en-us/dotnet/api/system.dayofweek?view=net-9.0
            int tmp = 7 - (int)today.DayOfWeek;

            // Berechnung und Ausgabe des 0. Sonntags
            DateTime nextSunday = today.AddDays(tmp);
            Console.WriteLine($"Sonntag Nr. 1: " + nextSunday);

            for (int i = 1; i < 3; i++)
            {
                nextSunday = nextSunday.AddDays(7);
                Console.WriteLine($"Sonntag Nr. {i + 1}: " + nextSunday);
            }

        }
    }
}