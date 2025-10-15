using System.Runtime.CompilerServices;
using System.Xml;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe27
{
    public class Generationen
    {
        public static void Start()
        {
            Console.WriteLine("Schreibe deinen Namen und dein Alter");
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());

            string output = "";

            if (age <= 97 && age >= 80)
            {
                output = "Generation Silent";
            }
            if (age <= 79 && age >= 61)
            {
                output = "Baby Boomer";
            }
            if (age <= 60 && age >= 45)
            {
                output = "Generation X";
            }
            if (age <= 44 && age >= 29)
            {
                output = "Millenials";
            }
            if (age <= 28 && age >= 15)
            {
                output = "Generation Z";
            }
            if (age <= 14 && age >= 0)
            {
                output = "Alpha";
            }
            Console.WriteLine($"{name} {age}: {output}");
        }

    }
}