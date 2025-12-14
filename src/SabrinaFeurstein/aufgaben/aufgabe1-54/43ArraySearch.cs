using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class ArraySearch
    {
        public static void Search()
        {
            string[] array = ["eins", "zwei", "drei", "vier", "fünf", "sechs", "sieben", "acht", "neun", "zehn"];
            bool search = false;

            do
            {
                Console.Write("Gesuchten Wert eingeben: ");
                string input = Console.ReadLine()!;
                for (int i = 0; i < array.Length; i++)
                {
                    search = array[i].Contains(input);
                    if (search)
                    {
                        Console.WriteLine($"Wort: {array[i]}, Speicherindex: {i}");
                        break;
                    }
                }
                if (!search)
                    Console.WriteLine("Wert nicht gefunden!");
            } while (!search);
                
            }
        }
    }