namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe24
{
    public class Runden
    {
        public static void Start()
        {
            Console.WriteLine("Schreibe eine Kommazahl rein");
            var zahl = Console.ReadLine() ?? string.Empty;
            double meineZahl = Convert.ToDouble(zahl);
            string s = meineZahl.ToString("F2");
            double meineZahlR = double.Parse(s);
            Console.WriteLine("Das ist deine Zahl gerundet: " + meineZahlR);

        }




    }
}