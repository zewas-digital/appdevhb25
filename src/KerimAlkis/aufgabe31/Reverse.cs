namespace Appdevhb25.KerimAlkis.Aufgabe31
{
    public class Reverse
    {
        public static void Start()
        {
            Console.WriteLine("Gib ein Wort ein");
            string input = Console.ReadLine();

            char[] elements = input.ToCharArray();
            Array.Reverse(elements);
            string reverse = new string(elements);
            

            System.Console.WriteLine("Reverse: " + reverse);
        }
    }
}