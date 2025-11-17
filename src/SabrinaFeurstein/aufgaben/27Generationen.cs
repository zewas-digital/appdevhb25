using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Generationen

    {
        public static void gen()
        {
            // Stand: 2025
            Console.WriteLine();
            Console.Write("Name eingeben: ");
            string name = Console.ReadLine()!;

            Console.Write("Alter eingeben: ");
            int alter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write($"{name} {alter}: ");

            if (alter <= 97 && alter >= 80)
            {
                Console.WriteLine("Generation Silent");
            }
            if (alter <= 79 && alter >= 61)
            {
                Console.WriteLine("Generation Boomer");
            }
            if (alter <= 60 && alter >= 45)
            {
                Console.WriteLine("Generation X");
            }
            if (alter <= 44 && alter >= 29)
            {
                Console.WriteLine("Generation Y");
            }
            if (alter <= 28 && alter >= 15)
            {
                Console.WriteLine("Generation Z");
            }
            if (alter <= 14 && alter >= 1)
            {
                Console.WriteLine("Generation Alpha");
            }
            if (alter < 0)
            {
                Console.WriteLine("Generation Beta");
            }
        }

        public static void jahr()
        {
            // Stand: 2025
            Console.WriteLine();
            Console.Write("Name eingeben: ");
            string name = Console.ReadLine()!;

            Console.Write("Alter eingeben: ");
            int alter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write($"{name} {alter}: ");

            int jahr = 2025;

            if (alter <= (jahr - 1928) && alter >= (jahr - 1945))
            {
                Console.WriteLine("Generation Silent");
            }
            if (alter <= (jahr - 1946) && alter >= (jahr - 1964))
            {
                Console.WriteLine("Generation Boomer");
            }
            if (alter <= (jahr - 1965) && alter >= (jahr - 1980))
            {
                Console.WriteLine("Generation X");
            }
            if (alter <= (jahr - 1981) && alter >= (jahr - 1996))
            {
                Console.WriteLine("Generation Y");
            }
            if (alter <= (jahr - 1997) && alter >= (jahr - 2010))
            {
                Console.WriteLine("Generation Z");
            }
            if (alter <= (jahr - 2011) && alter >= (jahr - 2024))
            {
                Console.WriteLine("Generation Alpha");
            }
            if (alter < (jahr - 2025))
            {
                Console.WriteLine("Generation Beta");
            }
        }

    }
}