using System.Runtime.InteropServices;

namespace Appdevhb25.KerimAlkis.Aufgabe32
{
    public class ArraySearch
    {
        public static void Start()
        {
            string langerstring = "Horizont Insekt Abschleppen Dekorieren Lotos Draht Paaren Linien Sieben Stange";
            string[] elements = langerstring.Split(" ");



            Console.WriteLine("Gib ein Wert ein");
            string input = Console.ReadLine();

            bool checker = false;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Contains(input))
                {
                    Console.WriteLine("Speicherindex im Array: " + i + " Speicherindex: " + elements[i].IndexOf(input));
                    checker = true;
                }
            }
            if(checker == false)
            {
                Console.WriteLine("Leider wurde nichts gefungen");
            }

        }
    }
}