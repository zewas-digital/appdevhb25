using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe44
{
    public  class Hessehervorheben
    {
        public static void Hesse()
        {
            // 1. Aufgabe alle "Hesse" in Grossbuchstaben ausgeben
            string textHesseKlein = @"Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: 
            Widerstand gegen konventionelle Normen, geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer 
            und „sinnlicher“ Lebensweise, Verhältnis des Künstlers zum Leben. 
            Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; 
            vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, 
            an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet 
            das neue Ideal eines „Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. 
            Hesses Werke waren mehrmals Identifikationstexte der gegen Gesellschaftszwänge aufbegehrenden 
            jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) und im Jugendprotest der späten sechziger Jahre. 
            Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. 
            Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, 
            die sich in seinen Texten wiederfand (Steppenwolf).\r\n\r\nHesse über sich selbst: 
            „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, 
            wie meine politischen Kritiker meinen, im elfenbeinernen Turme gelebt 
            – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, 
            sondern der einzelne Mensch, die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).
            \r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren; Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";
            // Aufgabe 1: alle "Hesse" in Grossbuchstaben ausgeben 
            string textHesseGross = textHesseKlein.Replace("Hesse", "HESSE");

            Console.WriteLine(textHesseGross);

            // Aufgabe 2: Erweitere das Programm so, dass jedes beliebige Wort in Uppercase dargstellt werden kann.
            System.Console.WriteLine("Pls enter a word wich you like to returne fully in capital letters.");
            string? userInput = System.Console.ReadLine();
            string wortInText = textHesseKlein.Replace(userInput, userInput.ToUpper());
            // string userInputInUpperCase = "";
            // System.Console.WriteLine($"{userInputInUpperCase}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine($"User input in Grossbuchstaben: {wortInText}");
            Console.ForegroundColor = ConsoleColor.White;         
        
            // Aufgabe 3: Anzahl Zeichen ausgeben
            int zeichenAnzahl = 0;

            for (int i = 0; i < textHesseKlein.Length; i++)
            {
                zeichenAnzahl++;
            }
            System.Console.WriteLine($"Anzahl Zeichen: {zeichenAnzahl}");
            
            // Aufgabe 4: Anzahl Wörter ausgeben 
            
            int wortAnzahl = textHesseKlein.Split(' ').Length; // Teilen des Strings nach Leerzeichen und Zählen der Wörter

            Console.WriteLine("Die Anzahl der Wörter ist: " + wortAnzahl);

            // Aufgabe 5: gib aus wie oft bestimmte Wörter vorkommen
            int anzahlBuecher = 0;
            for (int i = 0; i < textHesseKlein.Length; i++)
            {
                // Wenn Wort: "Bücher" vorkommt dann zähle das Wort
                if (textHesseKlein == "Bücher")
                {
                    anzahlBuecher++;
                }
            }
            System.Console.WriteLine(anzahlBuecher);

            // Aufgabe 6: die Wöter von hinten nach vorne ausgeben            
            char[] charArray = textHesseKlein.ToCharArray();
            Array.Reverse(charArray);
            string reversedText = new string(charArray);
            Console.WriteLine($"TextReversed1: {reversedText}");  

            // Aufgabe 6: die Wöter von hinten nach vorne ausgeben mit For - Schleife
            for (int i = textHesseKlein.Length - 1; i >= 0; i--)
            {
                Console.Write(textHesseKlein[i]);
            }
            System.Console.WriteLine($"TextReversed2: {reversedText}");
            
        }
    }
}