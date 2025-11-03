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

            In welchem Format kann ich ein Datum angeben?
              - Österreich: 08:20 Uhr
              - Ostösterreich, zb Wien: ein viertel neun = 8:15

              - USA: 08:20 AM
              - mit Millisekunden: 08:21:22.432

              - Reihenfolge von Tag, Monat und Jahr
                  - 01.02.2025 Tag.Monat.Jahr
                  - 02.01.2025 Monat.Tag.Jahr
                  - 05.03.01 --> Was ist jetzt Tag, Monat oder Jahr?
                  - 05.20.99 --> 20.05.1999; Herleitung durch Ausschlussverfahren
              - Trennzeichen: 21/10/2025
              - Welcher Kalender wird verwendet? Gregorianisch, Julianisch, etc. 


            Dieses Problem wird gelöst, indem man ein konkretes Datum in die vergangene Zeit seit einem bestimmten Nullpunkt umrechnet. 

            Der Nullpunkt nach der Unix-Zeit ist der 01.01.1970 00:00 Uhr
              - Jedes Datum wird als die Anzahl der vergangenen Millisekunden seit diesem Nullpunkt gespeichert.
              - Daten vor dem 01.01.1970 sind die negative Anzahl an Millisekunden bezogen auf den 01.01.1970.
              - Wenn ich eine Zeit in Millisekunden habe, muss ich immer wissen von welchem Nullpunkt aus diese berechnet wurde. Es gibt verschiedene Nullpunkte.

            Nullpunkt in C#:
              - Anzahl der Ticks, die seit dem Nullpunkt vergangen sind; ein Tick entspricht 100 Nanosekunden; 1 Nanosekunde ist der 10^-9. Teil einer Sekunde; 1 ns = 0,000000001 s
              - Nullpunkt in C# ist der 01.01.0001 um 00:00 Uhr

            */

<<<<<<< HEAD











            //Zeitpunkt();
            Zeitspanne();
=======
            //Zeitpunkt();
            //Zeitspanne();
>>>>>>> 47015c44c54dbec522f645ab31336c080bd6f0eb
            //ZeitInput();
        }

        public static void Zeitpunkt()
        {
            /*
            Zeitpunkte werden in ein DateTime-Objekt gespeichert.
            
            Unterschied variable vom Typ Integer und Objekt?
            --> Eine Variable kann nur einen Wert = einen Stift speichern.
            --> Ein Objekt ist wie eine Schachtel. In dieser Schachtel sind mehrere Stifte gespeichert. 
            
            Initalisierung eines DateTime Objekts mit dem Keyword "new" gefolgt von einem Konstruktor.
            */
            DateTime dt1 = new DateTime(); // 01/01/0001 00:00:00.000
            DateTime dt2 = new DateTime(2020, 02, 28); // 28/02/2020 00:00:00.000
            /*
            Wie finde ich heraus welche Konstruktoren/Eigenschaften/Methoden es für DateTime gibt?
              - im VS Code: Vorschläge beim Tippen
              - C#-Dokumentation von Microsoft: https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-8.0
              - Objekt im Debug Mode anschauen (Attribute + deren aktueller Wert)
            */

            // DayOfWeek ist eine Eigenschaft (ein Stift mit einer bestimmten Farbe) im dt2-Objekt vom Typ DateTime.
            System.Console.WriteLine(dt2.DayOfWeek);

            Console.WriteLine("\n--------------------");

            Console.WriteLine(dt1.ToString());
            Console.WriteLine(dt2.ToString());

            Console.WriteLine(dt2.ToString("dd.MMMM.yy"));
            Console.WriteLine(dt2.ToString("d.MMMM.yy"));
            // Zwei "d"s sorgen dafür, dass der Tag mit führendn nullen angezeigt wird.
            // Ein "d" zeigt den Tag ohne führende nullen an.

            Console.WriteLine(dt2.ToString("MM-yyyy"));

            Console.WriteLine("\n--------------------");

            DateTime moment = DateTime.Now;

            Console.WriteLine(moment.ToString());
            // heutiges Datum mit Uhrzeit im Zeitpunkt der Ausführung

            Console.WriteLine("\n--------------------");

            DateTime today = DateTime.Today;
            Console.WriteLine(today.ToString());
            // heutiges Datum mit Uhrzeit 00:00:00

            Console.WriteLine("\n--------------------");
            DateTime morgen = today.AddDays(1);
            // Ein Tag in Millisekunden = 24 h * 60 min * 60 sek * 1000 millisek
            System.Console.WriteLine(morgen.ToString());

            // Daten kann ich mit den bekannten Operatoren vergleichen 
            if (morgen > today)
            {
                System.Console.WriteLine("Morgen ist größer als heute.");
            }

            Console.WriteLine("\n--------------------");
            dt2 = dt2.AddDays(1);
            System.Console.WriteLine(dt2.ToString());
            
            // Die DateTime-Objekte erkennen automatisch den Wechsel von Monaten, Jahren und kann Schaltjahre berücksichtigen
            dt2 = dt2.AddDays(1);
            System.Console.WriteLine(dt2.ToString());
            Console.WriteLine("\n--------------------");


            // Kultureller Kontext
            // de ... Sprachkürzel nach ISO-639-1
            // https://de.wikipedia.org/wiki/Liste_der_ISO-639-Sprachcodes
            // AT ... Ländercode nach ISO-3166-2
            // https://de.wikipedia.org/wiki/ISO-3166-1-Kodierliste

            /*
            Unterschiede USA und Österreich
            - kein AM und PM; 0 bis 12 oder 0 bis 24 Stunden
            - andere Währung
            - Zeitzonen
            - Beginnt die Woche am Sonntag oder Montag?
            - Dezimalzeichen , .
            - 1000er Punkt . 1.000.000; 1,000,000.00; 1'000'000,00
            - Datumsformat .-/ Reihenfolge von Tag, Monat und Jahr
            - Geschwindigkeit km/h, mph
            - verschiedene Einheiten
            - Sprache
            - Angabe des Währungszeichen: 10,00 € oder € 10,00

            */

            // de ist die Sprache
            // AT ist das Land
            // Warum beides? Schweiz hat vier Sprachen in einem Land
            CultureInfo austrian = new CultureInfo("de-AT");
            DayOfWeek dow = austrian.DateTimeFormat.FirstDayOfWeek;
            Console.WriteLine(dow);
            System.Console.WriteLine(dt2.ToString(austrian));
            Console.WriteLine("\n--------------------");
            

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
            /*
            Ein Zeitpunkt (DateTime) ist ein konkretes Datum mit einer konkreten Uhrzeit in Ticks seit dem Nullpunkt.
            Eine Zeitspanne (TimeSpan) ist die Anzahl der Ticks zwischen zwei konkreten Zeitpunkten.
            Weitere Infos zu TimeSpan: https://learn.microsoft.com/en-us/dotnet/api/system.timespan.-ctor?view=net-8.0

            Initialisierung einer Zeitspanne:
            */
            TimeSpan ts = new TimeSpan(25, 20, 55); // Stunden, Minuten, Sekunden
            DateTime jetzt = DateTime.Now;

            // Die Methode Add
            jetzt.AddHours(-25.5);
            // ein positiver Wert wird hinzugefügt (Zukunft)
            // ein negativer Wert wird abgezogen (Vergangenheit)

            Console.WriteLine(jetzt.ToString());

            DateTime spaeter = jetzt.Add(ts);
            Console.WriteLine(spaeter.ToString());

            // Beginn der Unix-Epoche
            // 1.1.1970 00:00 UTC
            DateTimeOffset dto = new DateTimeOffset(jetzt.ToUniversalTime());
            long seconds = dto.ToUnixTimeMilliseconds();
            Console.WriteLine(seconds);
            Console.WriteLine("\n--------------------");
        }

        public static void ZeitInput()
        {
            //Variant1();
            //Variant2();
            //Variant3();

        }

        public static void Variant1()
        {
            // Variante 1: drei Integer einlesen
            Console.WriteLine("Bitte gib ein Jahr ein:");

            string yearAsString = Console.ReadLine();
            int year = Convert.ToInt32(yearAsString);

            Console.WriteLine("Bitte gib einen Monat ein:");
            string monthAsString = Console.ReadLine();
            int.TryParse(monthAsString, out int month);
            // Datentyp.TryParse() hat zwei Rückgabewerte
            // Der klassische return-Rückgabewert gibt uns einen Boolean, der uns angibt, ob die Umwandlung erfolgreich war.
            // Der zweite Rückgabewert mit dem Keyword out speichert den umgewandelten Wert in die Variable month.

            Console.WriteLine("Bitte gib einen Tag ein:");
            int.TryParse(Console.ReadLine(), out int day);

            int hour = 0;
            do
            {
                Console.WriteLine("Bitte gib die Stunde ein (0-23): ");
            } while (!int.TryParse(Console.ReadLine(), out hour));
            // Wieso do-while-Schleife? Eingabeaufforderung soll mindestens einmal ausgeführt werden.
            // Die (nicht) erfolgreiche Umwandlung in einen Integer ist die Abbruchbedingung. 
            // int.TryParse() gibt false zurück, wenn die Konvertierung erfolglos war.
            // Die Schleife wird nur solange ausgeführt, wie die Bedingung true ist. Deswegen invertiere ich den Rückgabewert von int.TryParse() mit !.

            DateTime result = new DateTime(year, month, day, hour, 0, 0);
            Console.WriteLine("Das eingegebene Datum ist: " + result.ToString("dddd, dd.MM.yyyy HH:mm"));
        }

        public static void Variant2()
        {
            // Varaiante 2: ganzes Datum einlesen und mit CultureInfo verarbeiten
            string inputAsString = Console.ReadLine();
            DateTime.TryParse(inputAsString, new CultureInfo("de-AT"), out DateTime result);
            Console.WriteLine("Das eingegebene Datum ist: " + result.ToString("dddd, dd.MM.yyyy HH:mm"));
            // Wie soll die Eingabe 05.03.01 interpretiert werden?
        }

        public static void Variant3()
        {
            string inputAsString = Console.ReadLine();
            // Variante 3 für die Fortgeschrittenen (Bonus)
            try
            {
                DateTime result = DateTime.ParseExact(inputAsString, "dd.MM.yyyy", new CultureInfo("de-AT"));
                Console.WriteLine("Das eingegebene Datum ist: " + result.ToString("dddd, dd.MM.yyyy HH:mm"));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Das Datum hat nicht das richtige Format.");
            }
        }
    }
}