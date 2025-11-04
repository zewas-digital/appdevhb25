using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Appdevhb25.KerimAlkis.Aufgabe33
{
    public class HesseHervorheben
    {
        public static void Start()
        {
            string hesse = "Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise, Verhältnis des Künstlers zum Leben. Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines „Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen, im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch, die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren; Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";

            string inputWordToUpper = "Hesse";

            hesse = hesse.Replace(inputWordToUpper, "HESSE");
            Console.WriteLine(hesse);


            int countZeichen = 0;

            foreach (char elem in hesse)
            {
                countZeichen++;
            }
            System.Console.WriteLine();
            Console.WriteLine("ZeichenAnzahl: " + countZeichen);

            string[] worte = hesse.Split(" ");

            int countWoerter = 0;
            foreach (string elem in worte)
            {
                if (int.TryParse(elem, out int i) == false)
                {
                    countWoerter++;
                }
            }
            Console.WriteLine("WoerterAnzahl: " + countWoerter);

            string compare = "Geboren";
            int countAnzahl = 0;
            foreach (string elem in worte)
            {
                if (elem.Contains(compare))
                {
                    countAnzahl++;
                }
            }
            Console.WriteLine("Das Wort: " + compare + " kommt " + countAnzahl + " Mal vor.");

            

            foreach (string elem in worte)
            {
                foreach (char c in elem.ToCharArray().Reverse())
                {
                    Console.Write(c);
                }
                System.Console.WriteLine();
            }




        }
    }
}