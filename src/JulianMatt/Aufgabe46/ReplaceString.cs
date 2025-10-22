namespace Appdevhb25.JulianMatt.Aufgabe46
{
    public class ReplaceString
    {

        public static void Start46()
        {
            string txt = StringMaker();
            Writetxt(txt);
        }

        public static string StringMaker()
        {
            // string hessenTxt = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            // return hessenTxt;
            return "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
        }

        public static void Writetxt(string txt)
        {
            txt = txt.Replace("wird", "war und ist");
            Console.WriteLine("Der Text");
            Console.WriteLine(txt);
            Console.WriteLine();

            string ohneKlein = txt;
            foreach (char c in ohneKlein)
            {
                if (char.IsLower(c))
                {
                    ohneKlein = ohneKlein.Replace(c, ' ');
                }
            }

            Console.WriteLine("Text ohne Kleinbuchstaben:");
            Console.WriteLine(ohneKlein);
            Console.WriteLine();


            string ohneGross = txt;
            foreach (char c in ohneGross)
            {
                if (char.IsUpper(c))
                {
                    ohneGross = ohneGross.Replace(c, ' ');
                }
            }
            Console.WriteLine("Text ohne Großbuchstaben:");
            Console.WriteLine(ohneGross);
            Console.WriteLine();


            string ohneLeerzeichen = txt.Replace(" ", "");
            Console.WriteLine("Text ohne Leerzeichen:");
            Console.WriteLine(ohneLeerzeichen);
            Console.WriteLine();

            string ohneAusrufer = txt.Replace("!", "");
            Console.WriteLine("Text ohne Ausrufezeichen:");
            Console.WriteLine(ohneAusrufer);
        }



    }
}