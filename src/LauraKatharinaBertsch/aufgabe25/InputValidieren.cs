namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe25
{
    public class InputValidieren
    {
        public static void Start()
        {
            Console.WriteLine("Gib eine Zahl ein");

            string input = Console.ReadLine();
            while (true)
            {

                if (int.TryParse(input, out int number))
                {
                    Console.WriteLine("Die Eingabe zählt");
                    break;
                }
                else
                {
                    Console.WriteLine("Die Eingabe zählt nicht. Gib eine neue Zahl ein");
                    input = Console.ReadLine();
                }
            }

        }




    }
}