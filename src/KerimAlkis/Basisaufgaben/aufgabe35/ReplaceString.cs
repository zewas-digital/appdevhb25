using Appdevhb25.KerimAlkis.Aufgabe00;

namespace Appdevhb25.KerimAlkis.Aufgabe35
{
    public class ReplaceString
    {
        public static void Start()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            string ersetze = text.Replace("wird", "war und ist");
            Console.WriteLine("1. " + ersetze);

            System.Console.WriteLine();
            string ohneKlein = text;
            foreach (char c in ohneKlein)
            {
                if (char.IsLower(c))
                {
                    ohneKlein = ohneKlein.Replace(c, ' ');
                }
            }
            Console.WriteLine("2. " + ohneKlein);

            System.Console.WriteLine();
            string ohneGross = text;
            foreach (char c in ohneGross)
            {
                if (char.IsUpper(c))
                {
                    ohneGross = ohneGross.Replace(c, ' ');
                }
            }
            Console.WriteLine("3. " + ohneGross);

            System.Console.WriteLine();
            string leerZeichen = "";
            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] != ' ')
                {
                    leerZeichen += text[i];
                }
            }
            Console.WriteLine("4. " + leerZeichen);


            System.Console.WriteLine();
            string aufrufeZeichen = "";
            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] != '!')
                {
                    aufrufeZeichen += text[i];
                }
            }
            Console.WriteLine("5. " + aufrufeZeichen);


            
            
        }
    }
}