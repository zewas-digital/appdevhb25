namespace Appdevhb25.JulianMatt.Aufgabe44
{
    public class Hessenhervorheben
    {

        public static void Start44()
        {
            string hessenTxt = StringMaker();
            WriteHessentxt(hessenTxt);
        }

        public static string StringMaker()
        {
            string hessenTxt = "Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise, Verhältnis des Künstlers zum Leben. Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines „Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen, im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch, die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren; Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";
            return hessenTxt;
        }

        public static void WriteHessentxt(string txt)
        {
            // Macht jedes mall wenn Hesse vorkommt Hesse zu HESSE.
            txt = txt.Replace("Hesse", "HESSE");
            Console.WriteLine("Der Text");
            Console.WriteLine(txt);
            while (true)
            {
                int wordCount = 0;
                Console.WriteLine();

                // Lasst den user ein weiteres Wort groß machen.
                Console.WriteLine("Soll ich ein weiteres Wort ihrer Wahl groß schreiben");
                string userIpnut = Console.ReadLine();
                txt = txt.Replace(userIpnut, userIpnut.ToUpper());
                Console.WriteLine("Hier ist ihr geupdateter Text");
                Console.WriteLine(txt);

                Console.WriteLine();

                // Zählt die Anzahl der Zeilen.
                Console.WriteLine("Anzahl der Zeichen: " + txt.Length);

                Console.WriteLine();

                // Zählt wie viele Wörter im Text sind.

                string[] txtArray = txt.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < txtArray.Length; i++)
                {
                    if (txtArray[i] == "")
                    {
                        wordCount += 0;
                    }
                    else
                    {
                        wordCount += 1;
                    }
                }
                Console.WriteLine("Es sind " + wordCount + " Wörter");

                Console.WriteLine();

                // Gibt aus wie oft ein bestimmtes wort vorkomme

                Console.WriteLine("Geben sie ein Wort ein bei dem sie überprüfen wollen wie oft es vorkommt.");
                userIpnut = Console.ReadLine();
                wordCount = 0;
                for (int i = 0; i < txtArray.Length; i++)
                {
                    if (txtArray[i] == userIpnut || txtArray[i] == userIpnut.ToLower() || txtArray[i] == userIpnut.ToUpper())
                    {
                        wordCount += 1;
                    }
                }

                Console.WriteLine("Ihr ausgewähltes Wort hat sich " + wordCount + " wiederholt");


                Console.WriteLine();

                // Git die wörter einzelnt von hinten nach vorne aus.

                Thread.Sleep(2000);
                Console.WriteLine("Wörter von hinten nach vorne einzelnd ausgegeben:");
                for (int i = 0; i < txtArray.Length; i++)
                {
                    Console.WriteLine(new string(txtArray[i].Reverse().ToArray()));
                }
            }
        }
    }
}