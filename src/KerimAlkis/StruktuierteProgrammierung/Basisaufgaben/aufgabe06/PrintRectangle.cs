namespace Appdevhb25.KerimAlkis.Aufgabe06
{
    public class PrintRectangle
    {
        public static void Start()
        {
            int hoehe = 10;
            int laenge = 5;
            string zeile = "";
            for (int i = 0; i < laenge; i++)
            {
                zeile += "x";
            }
            for (int i = 0; i < hoehe; i++)
            {
                Console.WriteLine(zeile);
            }
        }
    }
}