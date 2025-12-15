using System.Runtime.ConstrainedExecution;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe31
{
    public class RandomNumberArray
    {
        public static void Start()
        {
            // Länge des Arrays vom Nutzer abfragen
            Console.WriteLine("Schreibe irgendeine random Zahl");
            string input = Console.ReadLine() ?? string.Empty;
            int anzahlDerElemente = Convert.ToInt32(input);

            int[] randomNumberArray = new int[anzahlDerElemente];

            // Array mit Elementen befüllen
            Console.WriteLine("Schreibe " + anzahlDerElemente + " random Zahlen zwischen 0 und 100");


            // Array auf der Konsole ausgeben
            for (int i = 0; i < randomNumberArray.Length; i++)
            {

                string temp = Console.ReadLine() ?? string.Empty;
                int zahl = Convert.ToInt32(temp);
                randomNumberArray[i] = zahl;
            }

            // Kleinste Zahl suchen
            int smallest = randomNumberArray[0];

            for (int j = 1; j < randomNumberArray.Length; j++)
            {
                if (randomNumberArray[j] < smallest)
                {
                    smallest = randomNumberArray[j];
                }
            }
            Console.WriteLine("Die kleinste Zahl ist: " + smallest);

            int sum = 0;
            for (int j = 0; j < randomNumberArray.Length; j++)
            {
                sum = sum + randomNumberArray[j];
            }
            Console.WriteLine("Der Summe aller Zahlen ist: " + sum);

            int biggest = 0;
            for (int j = 0; j < randomNumberArray.Length; j++)
            {
                if (randomNumberArray[j] > biggest)
                {
                    biggest = randomNumberArray[j];
                }
            }
            Console.WriteLine("Die größte Zahl ist: " + biggest);
            Console.WriteLine("Der Durchschnitt aller Werte ist: " + sum / anzahlDerElemente);

            Console.WriteLine("Anzahl der Elemente: " + anzahlDerElemente);






        }
    }
}