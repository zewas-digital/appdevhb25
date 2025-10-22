using System;
using Appdevhb25.SabrinaFeurstein;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class HesseHervorheben
    {
        public static void Hervorheben()
        {
            string text = @"Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise, Verhältnis des Künstlers zum Leben. Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines „Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen, im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch, die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren; Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";
            string hesseOg = "Hesse";
            string ersatz = "ERSATZ";

            string textTemp = text.Replace(hesseOg, ersatz);
            string hesseGross = hesseOg.ToUpper();
            text = textTemp.Replace(ersatz, hesseGross);

            Console.WriteLine(text);
            Console.WriteLine();

            Console.Write("Wie viele Worte sollen in Großbuchstaben dargestellt werden? ");
            int anzahl = Convert.ToInt32(Console.ReadLine());
            int anzahlWort = 0;

            for (int i = 0; i < anzahl; i++)
            {
                Console.Write("Wort: ");
                string wordOg = Console.ReadLine();
                textTemp = text.Replace(wordOg, ersatz);
                string wordGross = wordOg.ToUpper();
                text = textTemp.Replace(ersatz, wordGross);
            }
            string[] words = text.Split(' ');
            string[] reversed = new string[words.Length];

            Console.Write("Welches Wort soll gezählt werden? ");
            string wort = Console.ReadLine();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(wort))
                    anzahlWort += 1;

                char[] wortTemp = words[i].ToCharArray();
                char[] reversedTemp = wortTemp.Reverse().ToArray();
                reversed[i] = new string(reversedTemp);
            }
            Console.WriteLine();
            Console.WriteLine("Wörter in Reverse: ");
            foreach (string elem in reversed)
                Console.WriteLine(elem);

            Console.WriteLine();
            Console.WriteLine(text);

            Console.WriteLine();
            Console.WriteLine("Anzahl der Zeichen: " + text.Count());
            Console.WriteLine("Anzahl der Wörter: " + words.Length);
            Console.WriteLine($"Anzahl des Wortes {wort}: " + anzahlWort);
        }
    }
}