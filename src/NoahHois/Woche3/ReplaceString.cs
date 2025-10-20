namespace Appdevhb25.NoahHois.aufgabe36
{
    public class ReplaceString
    {
        public static void Start36()
        {
            string input = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            string inputP1 = input.Replace("wird", "war und ist");
            Console.WriteLine("1. " + inputP1);

            string inputP2 = string.Empty;
            foreach (char c in input)
            {
                if (!char.IsAsciiLetterLower(c))
                {
                    inputP2 += c; // inputP2 += c == inputP2 = inputP2 + c
                }
            }
            Console.WriteLine("2. " + inputP2);

            string inputP3 = string.Empty;
            foreach (char c in input)
            {
                if (!char.IsAsciiLetterUpper(c))
                {
                    inputP3 += c;
                }
            }
            Console.WriteLine("3. " + inputP3);

            string inputP4 = string.Empty;
            foreach (char c in input)
            {
                if (!char.IsWhiteSpace(c))
                {
                    inputP4 += c;
                }
            }
            Console.WriteLine("4. " + inputP4);

            /*
            string inputP4 = input.Replace(" ", "");
            Console.WriteLine("4. " + inputP4);
            */

            string inputP5 = input.Replace("!", "");
            Console.WriteLine("5. " + inputP5);
        }
    }
}