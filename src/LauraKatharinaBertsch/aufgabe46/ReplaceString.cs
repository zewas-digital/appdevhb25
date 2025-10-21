namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe46
{
    public class ReplaceString
    {
        public static void Start()
        {
            substitute();
            withoutSmallLetters();
            withoutBigLetters();
            withoutSpace();
            withoutCallSign();
        }
        public static void substitute()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string replace = text.Replace("wird", "war und ist");
            Console.WriteLine(replace);
        }
        public static void withoutSmallLetters()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            for (int i = 0; i < text.Length; i++)
            {
                if ((int)text[i] < 97 || (int)text[i] > 122)
                {
                    Console.Write(text[i]);
                }
            }
            Console.WriteLine();
        }
        public static void withoutBigLetters()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            for (int i = 0; i < text.Length; i++)
            {
                if ((int)text[i] >= 97 && (int)text[i] <= 122 || (int)text[i] == 32 || (int)text[i] == 33)
                {
                    Console.Write(text[i]);
                }
            }
            Console.WriteLine();
        }
        public static void withoutSpace()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            for (int i = 0; i < text.Length; i++)
            {
                if ((int)text[i] != 32)
                {
                    Console.Write(text[i]);
                }
            }
            Console.WriteLine();
        }
        public static void withoutCallSign()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            for (int i = 0; i < text.Length; i++)
            {
                if ((int)text[i] != 33)
                {
                    Console.Write(text[i]);
                }
            }
            Console.WriteLine();
        }
    }
}