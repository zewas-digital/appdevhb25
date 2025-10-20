using System;
using System.Globalization;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe44
{
    public class HesseHervorheben
    {
        public static void Start()
        {
            string hesseText = text();
            VorkomnisseHesse(hesseText);
            BeliebigesUppercase(hesseText);
            AnzZeichen(hesseText);
            string[] satzInArray = AnzWoerter(hesseText);
            AnzBestWort(hesseText, satzInArray);
            HintenNachVorne(hesseText);
        }

        public static string text()
        {
            string hesseText =
            @"            Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: 
            Widerstand gegen konventionelle Normen, geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ 
            Lebensweise, Verhältnis des Künstlers zum Leben. Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) 7
            als auch von orientalischer Meditation (Siddhartha) beeinflusst; vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an 
            der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, an einer Welt der Maschinen und der 
            Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines „Reichs des Geistes und der Seele“ als 
            Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte der gegen 
            Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) 
            und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer 
            Hesse-Renaissance. Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen 
            Texten wiederfand (Steppenwolf).\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der 
            Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen, im elfenbeinernen Turme gelebt – aber das erste und 
            brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch, die Persönlichkeit, 
            das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren; 
            Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";
            return hesseText;
        }

        public static void VorkomnisseHesse(string hesseText)
        {
            string upperHEsse = "Hesse";
            if (hesseText.Contains(upperHEsse))
            {
                hesseText = hesseText.Replace(upperHEsse, upperHEsse.ToUpper());
            }
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Alle Vorkomnisse von 'Hesse' in Uppercase");
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine(hesseText);
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

        public static void BeliebigesUppercase(string hesseText)
        {
            System.Console.WriteLine("Suchen Sie sich ein Wort aus das in Uppercase geschrieben werden soll: ");
            string wishedWord = Console.ReadLine();
            if (hesseText.Contains(wishedWord))
            {
                hesseText = hesseText.Replace(wishedWord, wishedWord.ToUpper());
            }
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine($"Alle Vorkomnisse von '{wishedWord}' in Uppercase");
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine(hesseText);
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


        }

        public static void AnzZeichen(string hesseText)
        {
            int anzahlZeichen = hesseText.Length;
            System.Console.WriteLine($"Der text ist {anzahlZeichen} Zeichen Lang.");
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

        }

        public static string[] AnzWoerter(string hesseText)
        {
            string[] satzInArray = hesseText.Split(" ");
            int anzWoerter = satzInArray.Length;
            System.Console.WriteLine($"Der text ist {anzWoerter} Woerter Lang.");
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            return satzInArray;
        }

        public static void AnzBestWort(string hesseText, string[] satzInArray)
        {
            System.Console.WriteLine("Suchen Sie sich ein Wort von dem die Anzahl gesucht werden soll: ");
            string wishedWord = Console.ReadLine();
            
            int count = 0;
            foreach (string word in satzInArray)
            {
                if (word == wishedWord)
                {
                    count++;
                }
            }
            System.Console.WriteLine($"Das Wort {wishedWord} kommt {count} mal im Text vor.");
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }
        
        public static void HintenNachVorne(string hesseText)
        {
            string[] words = hesseText.Split(' ');
            System.Console.WriteLine("Jedes Wort rückwärts:");
            foreach(string word in words)
            {
                char[] arr = word.ToCharArray();
                Array.Reverse(arr);
                string revWord = new string(arr);
                System.Console.WriteLine(revWord);
            }
            System.Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}

