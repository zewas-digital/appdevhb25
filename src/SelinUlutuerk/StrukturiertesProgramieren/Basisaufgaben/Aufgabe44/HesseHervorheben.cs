using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe44
{
    class HesseHervorheben
    {
        public static void Start()
        {
            string satz = "Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise, Verhältnis des Künstlers zum Leben. Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines „Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen, im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch, die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren; Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";

            string[] satzinArray = satz.Split(" ");

            // 1. "Hesse" in Uppercase
            string hesse = "Hesse";
            for (int i = 0; i < satzinArray.Length; i++)
            {
                if (satzinArray[i].Contains(hesse))
                {
                    Console.Write(hesse.ToUpper() + " ");
                }
                else
                {
                    Console.Write(satzinArray[i] + " ");
                }
            }


            // 2. jedes Wort in Uppercase

            Console.Write($"\n\n{satz.ToUpper()}");


            // 3. anzahl der Zeichen
            char[] satzAsChar = satz.ToCharArray();
            Console.Write($"\n\nDie Anzahl der Zeichen beträgt {satzAsChar.Length}.\n");


            // 4. Anzahl der Wörter
            Console.Write($"\nDie Anzahl der Wörter beträgt {satzinArray.Length}.\n");


            // 5. Anzahl bestimmtes Wort
            Console.WriteLine("\nWelches Wort soll gesucht werden?");
            string? wort = Console.ReadLine();

            int anzahlWort = satzinArray.Count(w => w == wort);
            Console.WriteLine($"\nDie Anzahl des Wortes {wort} beträgt {anzahlWort}.\n");


            // 6. Wörte einzeln von hinten nach vorne
            // for (int i = 0; i < satzAsChar.Length; i++)
            // {
            //     Console.Write(satzAsChar[satzAsChar.Length - i - 1]);
            // }

            // Console.WriteLine("\n");

            foreach (string worte in satzinArray)
            {
                for (int i = worte.Length - 1; i >= 0; i--)
                {
                    Console.Write(worte[i]);
                }
                Console.Write(" ");
            }

        }
    }
}