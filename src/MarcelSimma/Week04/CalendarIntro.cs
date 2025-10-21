using System.Globalization;

namespace Appdevhb25.MarcelSimma
{
    public class CalendarIntro
    {
        public static void Start()
        {
            /*
            Verarbeitung von Daten in C#
            ============================

            Wie kann ich ein Datum angeben?
            08:20 Uhr

            08:20 AM
            08:21:22.432

            01.02.2025 Tag.Monat.Jahr
            Monat.Tag.Jahr
            21/10/2025

            05.03.01

            */












            Zeitpunkt();
            // Zeitspanne();
        }

        public static void Zeitpunkt()
        {
            // Struktur für einen Zeitstempel
            DateTime dt1 = new DateTime(); // 01/01/0001 00:00:00
            DateTime dt2 = new DateTime(2025, 10, 21); // Jahr, Monat, Tag

            Console.WriteLine(dt1.ToString());
            Console.WriteLine(dt2.ToString());

            Console.WriteLine(dt2.ToString("dd.MMMM.yy"));
            Console.WriteLine(dt2.ToString("MM-yyyy"));

            Console.WriteLine("\n--------------------");

            DateTime moment = DateTime.Now;

            // https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-8.0

            Console.WriteLine(moment.ToString());
            // heutiges Datum mit Uhrzeit im Zeitpunkt der Ausführung

            Console.WriteLine("\n--------------------");

            DateTime today = DateTime.Today;
            Console.WriteLine(today.ToString());
            // heutiges Datum mit Uhrzeit 00:00:00

            Console.WriteLine("\n--------------------");
            DateTime morgen = today.AddDays(1);
            // Ein Tag in Millisekunden = 24*60*60*1000
            System.Console.WriteLine(morgen.ToString());
            
            if (morgen > today)
            {
                System.Console.WriteLine("Morgen ist größer als heute.");
            }

            Console.WriteLine("\n--------------------");

            // Kultureller Kontext
            // de ... Sprachkürzel nach ISO-639-1
            // https://de.wikipedia.org/wiki/Liste_der_ISO-639-Sprachcodes
            // AT ... Ländercode nach ISO-3166-2
            // https://de.wikipedia.org/wiki/ISO-3166-1-Kodierliste

            /*
            Unterschiede USA Österreich
            - kein AM und PM
            - andere Währung
            - Zeitzonen
            - Beginnt die Woche am Sonntag oder Montag?
            - Dezimalzeichen , .
            - 1000er Punkt . 1.000.000; 1,000,000.00; 1'000'000,00
            - Datumsformat .-/ Reihenfolge von Tag, Monat und Jahr
            - Geschwindigkeit km/h, mph
            - verschiedene Einheiten
            - Sprache

            */
            
            // de ist die Sprache
            // AT ist das Land
            CultureInfo austrian = new CultureInfo("de-AT");
            DayOfWeek dow = austrian.DateTimeFormat.FirstDayOfWeek;
            Console.WriteLine(dow);
            // 10,00 €
            // € 10,00

            DayOfWeek day = DayOfWeek.Sunday;
            DateTimeFormatInfo dtfi = austrian.DateTimeFormat;
            Console.WriteLine(dtfi.GetDayName(day));
            Console.WriteLine(austrian.DateTimeFormat.GetDayName(day));

            //tt.mm.yyyy
            //05.03.2001
            //20.10.2025

            // ToString mit vordefinierten Formaten
            // https://learn.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=net-8.0#system-datetime-tostring
            Console.WriteLine(moment.ToString("d"));
            Console.WriteLine(moment.ToString("d", austrian));
            Console.WriteLine(moment.ToString("t"));
            Console.WriteLine(moment.ToString("t", austrian));
            Console.WriteLine(moment.ToString("F"));
            Console.WriteLine(moment.ToString("F", austrian));

            // TODO
            // Teste verschiedene Formate und kulturelle Kontexte
            // + Gib ein Datum im Format Donnerstag, 24. Oktober 2024 aus
            // + Welche Kürzel gibt es für Jahr, Monat, Tag, Stunde, Minute, Sekunde
        }


        public static void Zeitspanne()
        {
            // Struktur für eine Zeitspanne
            TimeSpan ts = new TimeSpan(25, 20, 55); // Stunden, Minuten, Sekunden
            DateTime jetzt = DateTime.Now;

            jetzt.AddHours(25.5);

            Console.WriteLine(jetzt.ToString());

            DateTime spaeter = jetzt.Add(ts);
            Console.WriteLine(spaeter.ToString());

            // Beginn der Unix-Epoche
            // 1.1.1970 00:00 UTC
            DateTimeOffset dto = new DateTimeOffset(jetzt.ToUniversalTime());
            long seconds = dto.ToUnixTimeSeconds();
            Console.WriteLine(seconds);
            Console.WriteLine("\n--------------------");
        }
    }
}