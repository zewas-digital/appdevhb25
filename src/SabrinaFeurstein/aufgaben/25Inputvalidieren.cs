using System;


namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class InputValidieren

    {
        public static int intval()
        {
            while (true)
            {
                Console.Write("Gib eine ganze Zahl ein: ");
                string input = Console.ReadLine()!;

                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe.");
                }
            }
        }

        public static double doubleval()
        {
            while (true)
            {
                Console.Write("Gib eine Kommazahl ein: ");
                string input = Console.ReadLine()!;

                if (double.TryParse(input, out double number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe.");
                }
            }
        }
        
        public static bool boolval()
        {
            while (true)
            {
                Console.Write("Gib 'true' oder 'false' ein: ");
                string input = Console.ReadLine()!;

                if (bool.TryParse(input, out bool value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe.");
                }
            }           
        }
    }
}