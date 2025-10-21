using System;
namespace Appdevhb25.SheilaMayJaro.Aufgabe43
{
    internal class ArraySearch
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 43)");
            //Erstelle ein Array mit mindestens 10 verschiedenen Werten. 
            //Der Nutzer soll über die Konsole einen Wert im Array suchen können. 
            // Wird der Wert gefunden, wird sein Speicherindex ausgegeben. 
            // Wird der Wert nicht gefunden, kommt eine Fehlermeldung. 
            //Der Nutzer soll auch nach einzelnen Silben suchen können. 

            //Arbeiten nach dem EVA-Prinzip 
            //Array mit Wörtern erstellen
            System.Console.WriteLine("Ein Wort finden.");
            string[] words = ["Blume", "Kürbis", "Baum", "Traum", "Nebel", "Buch", "Igel", "Laub", "Rabe", "Halloween"];

            //Eingabe 
            System.Console.WriteLine("Gib ein Wort ein:");
            string? word = Console.ReadLine();
            //? - Null-Operator gibt alle Worte, die als string zulässig sind UND zusätzlich null zurück 

            int indexOfFoundWord = -1;
            //Da alle positiven Zahlen Indizes sind 
            // Laut Aufgabenbeschreibung eine Fehlermeldung kommen soll, wenn es nicht gefunden wird, daher benötigt man eine Variable, die außerhalb liegt
            // -1 bedeutet, dass das Wort nicht gefunden wurde

            //Verarbeitung - Schleife um das eingegebene Wort zu finden 
            for (int i = 0; i < words.Length; i++)
            {
                if (word == words[i]) //da der Speicherindex ausgegeben werden soll, benutzt man eine for-Schleife 
                {
                    indexOfFoundWord = i;
                    break; //sobald das Wort gefunden ist, muss nicht weiter gesucht werden und die Schleife kann beendet werden 
                }
            }

            //Ausgabe des Wortes - einmal mit foreach-Schleife und einmal mit for-Schleife

            // foreach (string elem in words) 
            // {
            //     indexOfFoundWord++; 
            //     if (word == elem)
            //     {
            //         break;
            //     }
            // }

            if (indexOfFoundWord == -1)
            {
                //Ausgabe soll eine Fehlermeldung enthalten
                System.Console.WriteLine("Wort nicht enthalten.");
            }
            else
            {
                System.Console.WriteLine($"Das Wort {word} ist enthalten. Wortindex: {indexOfFoundWord + 1}");
            }

            System.Console.WriteLine("------------------------------------");
            //dasselbe, um eine Silbe zu finden 
            System.Console.WriteLine("Eine Silbe finden: ");

            string? syllable = Console.ReadLine();
            int indexOfFoundSyllable = -1;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Trim().ToLower().Contains(syllable.ToLower()))
                //.Trim() schneidet das Wort ab 
                //.ToLower() macht alle Buchstaben klein, man könnte auch .ToUpper verwenden, das macht alle Buchstaben groß - Case-Insensitiv 
                //.Contains() bedeutet beinhalten, es schaut ob syllable in words enthalten ist - da es nur ein Teil ist
                {
                    System.Console.WriteLine($"Die Silbe {syllable} ist in {words[i]} enthalten.");
                    //kein break; da die Silbe in mehreren Worten enthalten sein kann 
                    indexOfFoundSyllable = i;
                }
            }
            //Fehlermeldung, wenn die Silber nicht gefunden wird
            if (indexOfFoundSyllable == -1)
            {
                System.Console.WriteLine($"Die Silbe {syllable} ist in keinem der Wörter enthalten.");
            }
        }
    }
}