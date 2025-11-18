namespace Appdevhb25.SheilaMayJaro.Aufgabe77
{
    public class Aufgabe77
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 77)");
            /*
            Füge mindestens fünf Serien mit deinen Bewertungen hinzu.
            Implementiere folgende Funktionen:
                - Gib alle Serien samt Bewertung sortiert nach dem Namen zurück.
                - Gib alle Serien mit einer Bewertung über 8.0 zurück.
                - Ermittle, welche Serie die höchste Bewertung hat und gib sie zurück.
                - Ermögliche es dem Benutzer, eine Serie über ihren Namen zu suchen, um die Bewertung anzuzeigen (Tastatureingabe).
            */

            Series seriesList = new Series();
            seriesList.AddSeries("Haikyu", 8.5);
            seriesList.AddSeries("Bluey", 8.2);
            seriesList.AddSeries("The Amazing Digital Circus", 8.8);
            seriesList.AddSeries("Tagebücher der Apothekerin", 7.8);
            seriesList.AddSeries("With you in the Rain", 7.4);

            seriesList.DisplayDictionary();
            seriesList.SortSeriesByName();
            seriesList.HighRatingSeries();
            seriesList.BestSeries();
            seriesList.FindSeries(); 
            
        }
        
    }
}