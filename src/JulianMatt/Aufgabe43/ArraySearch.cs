using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe43
{
    public class ArraySearch
    {

        public static void Start43()
        {
            string[] input = StringMaker();
            LookForArray(input);
        }

        public static string[] StringMaker()
        {
            string[] input;

            input = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Geben sie ein Wort ein: ");
                input[i] = Console.ReadLine();
                Console.WriteLine();
            }
            return input;
        }

        public static void LookForArray(string[] input)
        {
            while (true)
            {
                Console.WriteLine("Die Möglichen wörter bei dennen sie den index nachschauen können:");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(input[i] + ",   ");
                }

                Console.WriteLine();
                Console.WriteLine("Bei welchem Wort möchten sie den Speicherindex nachschauen und fals sie aufhören wollen geben sie einfach exit ein");
                string searchFor = Console.ReadLine();

                if ( searchFor == "exit")
                {
                    break;
                }
                Console.WriteLine(); 

                bool gefunden = false;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i].ToLower().Contains(searchFor.ToLower()))
                    {
                        Console.WriteLine("Gefunden: '"+input[i]+"' an Index "+i+" ");
                        gefunden = true;
                    }
                }

                if (gefunden == false)
                {
                    Console.WriteLine("Fehler: Wort wurde nicht gefunden!");
                }

                Console.WriteLine();


            }
        }
       
    }



}