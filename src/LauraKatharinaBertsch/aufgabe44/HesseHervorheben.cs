using System.Security.Cryptography;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe44
{
    public class HesseHervorheben
    {
        public static void Start()
        {
            doesHesseToUpper();
            doesWordToUpper();
            countsSymbols();
            countsWords();
            countsSameWords();
            wordsBackward();
        }
        public static void doesHesseToUpper()
        {

            Console.WriteLine("Der Hesse Text wird angezeigt:");

            string text = @"Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, 
geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise, Verhältnis des Künstlers zum Leben. 
Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; 
vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, 
an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines 
„Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte 
der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) 
und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. 
Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).
\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen,
im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch,
die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren;
Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";

            string hesseToUpper = text.Replace("Hesse", "HESSE");
            Console.WriteLine(hesseToUpper);

            Console.WriteLine();
        }
        public static void doesWordToUpper()
        {
            string text = @"Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, 
geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise, Verhältnis des Künstlers zum Leben. 
Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; 
vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, 
an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines 
„Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte 
der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) 
und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. 
Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).
\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen,
im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch,
die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren;
Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";

            Console.WriteLine("Welches Wort soll groß geschrieben werden?");
            string randomWord = Console.ReadLine() ?? string.Empty;
            string wordToUpper = text.Replace(randomWord, randomWord.ToUpper());
            Console.Clear();
            Console.WriteLine(wordToUpper);

            Console.WriteLine();
        }
        public static void Words()
        {
            string[] text = [@"Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, 
geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise, Verhältnis des Künstlers zum Leben. 
Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; 
vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, 
an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines 
„Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte 
der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) 
und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. 
Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).
\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen,
im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch,
die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren;
Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen."];
        }
        public static void countsSymbols()
        {
            string text = @"Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, 
geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise, Verhältnis des Künstlers zum Leben. 
Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; 
vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, 
an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines 
„Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte 
der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) 
und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. 
Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).
\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen,
im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch,
die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren;
Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";
            int zeichen = 0;
            for (int i = 0; i < text.Length; i++)
            {
                zeichen = zeichen + 1;
            }
            Console.WriteLine("So viele Zeichen hat der Text: " + zeichen);
        }
        public static void countsWords()
        {
            string text = @"Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, 
geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise, Verhältnis des Künstlers zum Leben. 
Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; 
vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, 
an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines 
„Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte 
der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) 
und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. 
Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).
\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen,
im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch,
die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren;
Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";
            string[] words = text.Split(" ");

            Console.WriteLine("So viele Wörter hat der Text: " + words.Length);
        }
        public static void countsSameWords()
        {
            string text = @"Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, 
geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise, Verhältnis des Künstlers zum Leben. 
Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; 
vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, 
an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines 
„Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte 
der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) 
und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. 
Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).
\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen,
im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch,
die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren;
Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";
            text = text.ToLower();
            string[] words = text.Split(" ");
            int sameWords = 0;

            Console.WriteLine("Schreibe ein Wort rein, es wird dann gezählt, wie oft es im Text vorkommt");
            string word = Console.ReadLine() ?? string.Empty.ToLower();
            for (int i = 0; i < words.Length; i++)
            {
                if (word == words[i])
                {
                    sameWords = sameWords + 1;
                }
            }
            Console.WriteLine("Es gibt " + sameWords + " deines Wortes");
        }
        public static void wordsBackward()
        {
            Console.WriteLine("Die einzelnen Wörter werden rückwerts angezeigt:");

            string text = @"Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, 
geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise, Verhältnis des Künstlers zum Leben. 
Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; 
vor allem im „Steppenwolf“ übt Hesse vehemente Kritik an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, 
an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines 
„Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte 
der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) 
und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. 
Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).
\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen,
im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch,
die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren;
Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";
            string[] words = text.Split(" ");
            for (int i = 0; 1 < words.Length; i++)
            {
                char[] letters = words[i].ToCharArray();
                for (int j = letters.Length - 1; j >= 0; j--)
                {
                    Console.Write(letters[j]);
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}