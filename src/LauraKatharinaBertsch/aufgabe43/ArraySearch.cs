using System.Runtime.CompilerServices;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe43
{
    public class ArraySearch
    {
        public static void Start()
        {
            string[] words = new string[] { "Maus", "Torte", "Kleid", "Tiger", "Schnecke", "Erdbeere", "Wasser", "Libelle", "Zimtstange", "Blumenstrauß" };
            Console.WriteLine("Schreibe ein Wort");
            string word = Console.ReadLine();
            int indexOfWord = -1;
            for (int i = 0; i < words.Length; i++)
            {
                if (word.ToLower() == words[i].ToLower())
                {
                    indexOfWord = i;
                    break;
                }
            }
            if (indexOfWord == -1)
            {
                Console.WriteLine("Das Wort gibt es nicht");
            }
            else
            {
                Console.WriteLine("An dieser Stelle kommt das Wort: " + (indexOfWord + 1));
            }

            Console.WriteLine("Schreibe eine Silbe");
            string silbe = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower().Contains(silbe.ToLower()))
                {
                    Console.WriteLine("An dieser Stelle kommen die Silben vor: " + (i + 1));
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Diese Silbe kommt nirgends vor");
            }
        }
    }
}