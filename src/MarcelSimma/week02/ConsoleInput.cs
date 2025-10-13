namespace Appdevhb25.MarcelSimma.ConsoleInput
{
    public class ConsoleInput
    {
        public static void Start()
        {
            /* 
            Einfache Variante mit Convert.ToDatatype()
            ==========================================

            Problem: Error Handling; Wenn der User einen falschen Input liefert, stürzt das Programm ab.
            */

            string input = Console.ReadLine();
            Console.WriteLine("You entered: " + input);

            int zahl = Convert.ToInt32(Console.ReadLine());
            double gleitkommazahl = Convert.ToDouble(Console.ReadLine());
            bool wahrheitswert = Convert.ToBoolean(Console.ReadLine());


            /*
            Bessere Variante: Datatype.TryParse()
            =====================================
            */

            string ageInput = Console.ReadLine();
            // int.TryParse liefert true oder false als Rückgabewert
            // out int age liefert den geparsten Wert in die Variable age

            bool konvertierungWarErfolgreich = int.TryParse(ageInput, out int age);

            if (konvertierungWarErfolgreich)
            {
                Console.WriteLine("You are " + age + " years old.");
            }
            else
            {
                Console.WriteLine("Invalid age input.");
            }
            
            while (!int.TryParse(Console.ReadLine(), out int age2))
            {
                Console.WriteLine("Invalid age input. Please enter a valid number.");
            }

            /*
            Exkurs: out in C#
            */

            Console.WriteLine(sum(2, 3));
            berechne(2, 3, out int ergebnis);
            Console.WriteLine(ergebnis);
        }

        public static int sum(int a, int b)
        {
            return a + b;
        }

        /*
        Mit dem out Keyword kann ich weitere Rückgabewerte einer Methode definieren. 
        */
        
        public static void berechne(int a, int b, out int summe)
        {
            summe = a + b;
        }
        
    }
}