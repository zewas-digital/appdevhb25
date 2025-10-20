using System;
using System.Reflection;
using System.Security.Principal;
using Appdevhb25.NoahHois.Aufgabe3;

namespace Appdevhb25.NoahHois.Aufgabe34
{
    public class HesseHervorheben
    {
        public static void Start34()
        {
            int sum = 0;
            string main = "Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise, Verhältnis des Künstlers zum Leben. Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines „Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen, im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch, die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren; Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";
            string[] mainArray = main.Split(" ");

            main = main.Replace("Hesse", "HESSE");

            Console.WriteLine(main);

            Console.WriteLine("Gib bitte ein Wort vom Text ein: ");
            string? input = Console.ReadLine();

            main = main.Replace(input, input.ToUpper());

            Console.WriteLine("Ihr abverändeter Text: ");
            Console.WriteLine(main);

            Console.WriteLine(" Es sind insgesamt: " + main.Length + " Zeichen");

            Console.WriteLine();

            Console.WriteLine("Es sind insgesamt: " + mainArray.Length + " Wörter");

            Console.WriteLine();

            Console.WriteLine("Gib bitte ein Wort vom Text ein: ");
            input = Console.ReadLine();

            Console.WriteLine();
            sum = 0;
            bool specificWord = false;
            for (int i = 0; i < mainArray.Length; i++)
            {
                if (input == mainArray[i])
                {
                    sum += 1;
                    specificWord = true;
                }
            }
            Console.WriteLine(sum);
            if (specificWord == false)
            {
                Console.WriteLine("Das Wort konnte nicht identifiziert werden.");
            }

            for (int i = main.Length; i > 0; i--)
            {
                Console.Write(main[i - 1]);
            }
            Console.WriteLine();
        }
    }
}