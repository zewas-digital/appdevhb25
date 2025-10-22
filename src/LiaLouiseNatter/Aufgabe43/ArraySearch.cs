using System;
using System.Globalization;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe43
{
    public class Arrayearch
    {
        public static void Start()
        {
            string[] names = ArrayMaker();
            UserSearch(names);
        }

        public static string[] ArrayMaker()
        {
            string[] names = { "Peter", "Herbert", "Otto", "Lion", "Johanna", "Ida", "Luisa", "Lia", "Selina", "Karl" };
            for (int i = 0; i < names.Length; i++)
            {
                System.Console.WriteLine(names[i]);
            }
            return names;
           
        }

        public static void UserSearch(string[] names)
        {
            while (true)
            {
                try
                {
                    System.Console.Write("Suche nach einem Namen oder nach einer Silbe: ");
                    string searched = Console.ReadLine();
                    string namesString = String.Concat(names);

                    int indexOf = namesString.IndexOf(searched);


                    if (indexOf == -1)
                    {
                        System.Console.WriteLine("Your Char is not in the Array, try again!");
                    }
                    else
                    {
                        System.Console.WriteLine(indexOf);
                        break;
                    }
                }
                catch
                {
                    System.Console.WriteLine("Your Char is not in the Array, try again!");
                }
            }  
        }
    }
}

