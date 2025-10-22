using System;
using System.Runtime.CompilerServices;

namespace Appdevhb25.SheilaMayJaro.Aufgabe44
{
    public class HighlightHesse
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 44)");
            System.Console.WriteLine("Das Leben von Hesse:");
            string lifeOfHesse = @"
            Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. 
            Thematik der frühen Romane: Widerstand gegen konventionelle Normen, geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise, Verhältnis des Künstlers zum Leben. 
            Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; 
            vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, an einer Welt der Maschinen und der Kommerzialisierung. 
            Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines „Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. 
            Hesses Werke waren mehrmals Identifikationstexte der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: 
            nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) und im Jugendprotest der späten sechziger Jahre. 
            Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, 
            die sich in seinen Texten wiederfand (Steppenwolf).\r\n\r\n Hesse über sich selbst: 
            „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, 
            wie meine politischen Kritiker meinen, im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch, 
            die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren; 
            Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";

            System.Console.WriteLine(lifeOfHesse);
            System.Console.WriteLine();

            //1. Erstelle ein Programm, dass alle Vorkommnisse von "Hesse" in Uppercase darstellt.
            System.Console.WriteLine("Aufgabe 44.1)");
            System.Console.WriteLine("Das Leben Von HESSE:");
            string lifeOfHESSE = lifeOfHesse.Replace("Hesse", "HESSE");
            System.Console.WriteLine(lifeOfHESSE);
            System.Console.WriteLine();

            //2. Erweitere das Programm so, dass jedes beliebige Wort in Uppercase dargstellt werden kann.
            System.Console.WriteLine("Aufgabe 44.2)");

            string word = " der ";
            string newLifeOfHesse = lifeOfHesse.Replace(word, word.ToUpper(), StringComparison.CurrentCultureIgnoreCase);
            //String.Comparison.CurrentCultureIgnoreCase - vergleicht die Strings und Case-Insensitiv 
            System.Console.WriteLine(newLifeOfHesse);

            System.Console.WriteLine();
            System.Console.WriteLine("Geben Sie ein Wort ein, dass in Großbuchstaben zurückgegeben werden soll.");
            string? userInput = Console.ReadLine();
            string LifeOfHesseWithUserInput = lifeOfHesse.Replace(userInput, userInput.ToUpper(), StringComparison.CurrentCultureIgnoreCase);
            System.Console.WriteLine(LifeOfHesseWithUserInput);

            //3. Gib die Anzahl der Zeichen aus.
            System.Console.WriteLine();
            System.Console.WriteLine("Aufgabe 44.3)");
            char[] lifeOfHesseCharArray = lifeOfHesse.ToCharArray();
            int sumOfCharacters = 0;

            for (int i = 0; i < lifeOfHesseCharArray.Length; i++)
            {
                sumOfCharacters++;
            }
            System.Console.WriteLine($"Der Text hat {sumOfCharacters} Zeichen.");

            //4. Gib die Anzahl der Wörter aus.  
            System.Console.WriteLine();
            System.Console.WriteLine("Aufgabe 44.4)");
            string[] lifeOfHesseWordArray = lifeOfHesse.Split(" ");
            int sumOfWords = 0;

            for (int i = 0; i < lifeOfHesseWordArray.Length; i++)
            {
                sumOfWords++;
            }

            System.Console.WriteLine($"Es gibt {sumOfWords} Wörter im Text.");

            //5. Gib aus wie oft ein bestimmtes Wort vorkommt.  
            System.Console.WriteLine();
            System.Console.WriteLine("Aufgabe 44.5)");
            string word2 = "und";
            int sumOfWord = 0;
            for (int i = 0; i < lifeOfHesseWordArray.Length; i++)
            {
                if (lifeOfHesseWordArray[i] == word2)
                {
                    sumOfWord++;
                }
            }

            System.Console.WriteLine($"Das Wort '{word2}' kommt {sumOfWord} mal vor.");
            System.Console.WriteLine();
            System.Console.WriteLine("Bitte geben Sie das Wort ein, dessen Anzahl Sie herausfinden möchten:");
            string userInput2 = Console.ReadLine();

            for (int i = 0; i < lifeOfHesseWordArray.Length; i++)
            {
                if (lifeOfHesseWordArray[i] == userInput2)
                {
                    sumOfWord++;
                }
            }

            System.Console.WriteLine($"Das Wort '{userInput2}' kommt {sumOfWord} mal vor.");

            //6. Gib die Wörter einzeln von hinten nach vorne aus. Also die Wörter werden rückwärts ausgegeben, aber die Reihenfolge bleibt gleich
            System.Console.WriteLine();
            System.Console.WriteLine("Aufgabe 44.6)");

            for (int i = 0; i < lifeOfHesseWordArray.Length; i++)
            {
                string example = lifeOfHesseWordArray[i];
                char[] exampleArray = example.ToCharArray();
                char[] arrayReversed = new char[exampleArray.Length];
                for (int j = 0; j < exampleArray.Length; j++)
                {
                    arrayReversed[j] = exampleArray[exampleArray.Length - j - 1];
                }
                System.Console.WriteLine(arrayReversed);
            }


            char[] lifeOfHesseWordCharArray = new char[lifeOfHesseWordArray.Length];
            char[] lifeOfHesseWordCharArrayReversed = new char[lifeOfHesseWordArray.Length];
            for (int i = 0; i < lifeOfHesseWordArray.Length; i++)
            {
                lifeOfHesseWordCharArray = lifeOfHesseWordArray[i].ToCharArray();
                for (int j = 0; j < lifeOfHesseWordCharArray.Length; j++)
                {
                    lifeOfHesseWordCharArrayReversed[j] = lifeOfHesseWordCharArray[lifeOfHesseWordCharArray.Length - j - 1];
                }
            }
            System.Console.WriteLine(lifeOfHesseWordCharArrayReversed);


            System.Console.WriteLine();
            System.Console.WriteLine("Ausgabe des gesamten Text nur rückwärts");
            char[] lifeOfHesseCharArrayReversed = new char[lifeOfHesseCharArray.Length];
            for (int i = 0; i < lifeOfHesseCharArray.Length; i++)
            {
                lifeOfHesseCharArrayReversed[i] = lifeOfHesseCharArray[lifeOfHesseCharArrayReversed.Length - i - 1];
            }
            System.Console.WriteLine(lifeOfHesseCharArrayReversed);
            //gesamter Text ist rückwärts, aber ich brauche die einzelnen Wörter rückwärts. Ansonsten läuft der Text von vorne nach hinten 















        }
    }
}