
using System.ComponentModel;
using System.Globalization;
using System.Xml.XPath;

namespace Appdevhb25.KerimAlkis.Bonusaufgabe15
{
    public class DrawCalendar
    {
        public static void Start()
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            DateTime datum;
            do
            {
                System.Console.WriteLine("Kalender");
                Console.Write("Gib ein Datum ein (Format: TT.MM.JJJJ): ");
                string input = Console.ReadLine();
                try
                {
                    datum = DateTime.ParseExact(input, "dd.MM.yyyy", austrian);
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Try again");
                }

            } while (true);

                int jahr = datum.Year;
                Zeichner(jahr, datum);
                // Zeichner1(jahr);
            }
        public static void Zeichner(int jahr,DateTime gesetztesDatum)
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            DateTime datum = new DateTime(jahr, 1, 1);

            string layout = $"{datum.Year} {datum.ToString("MMMM", austrian)}\n| Mo | Di | Mi | Do | Fr | Sa | So |";

            int vorherigeMonat = 1;
            System.Console.Write(layout);
            while (datum.Year == jahr)
            {
                if (datum.Month > vorherigeMonat)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine();
                    System.Console.Write($"{datum.Year} {datum.ToString("MMMM", austrian)}\n| Mo | Di | Mi | Do | Fr | Sa | So |");
                    vorherigeMonat++;
                }

                System.Console.WriteLine();
                System.Console.Write("|");

                for (int i = 1; i <= 7; i++)
                {
                    if (datum.Month != vorherigeMonat) { System.Console.Write("    |"); }
                    else if ((int)datum.DayOfWeek == i || (int)datum.DayOfWeek == 0 && i == 7)
                    {
                        if (datum == gesetztesDatum) { System.Console.Write(" " + datum.ToString("dd") + "*|"); datum = datum.AddDays(1); }
                        else { System.Console.Write(" " + datum.ToString("dd") + " |"); datum = datum.AddDays(1); }
                    }
                    else { System.Console.Write("    |"); }
                }
            }
        }
        public static void Zeichner1(int jahr)
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            DateTime datum = new DateTime(jahr, 1, 1);

            string layout = $"{datum.Year} {datum.ToString("MMMM", austrian)}\n| Mo | Di | Mi | Do | Fr | Sa | So |";

            int vorherigeMonat = 1;
            System.Console.Write(layout);
            while (datum.Year == jahr)
            {
                if (datum.Month > vorherigeMonat)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine();
                    System.Console.Write($"{datum.Year} {datum.ToString("MMMM", austrian)}\n| Mo | Di | Mi | Do | Fr | Sa | So |");

                    vorherigeMonat++;
                }
                System.Console.WriteLine();
                if (datum == DateTime.Today) { Console.Write("| " + datum.ToString("dd") + "*|"); datum = datum.AddDays(1); }
                else if (datum.Month > vorherigeMonat || datum.Year != jahr)
                { Console.Write("|    |"); }
                else if (datum.DayOfWeek == DayOfWeek.Monday) { Console.Write("| " + datum.ToString("dd") + " |"); datum = datum.AddDays(1); }
                else { Console.Write("|    |"); }


                if (datum == DateTime.Today) { Console.Write(" " + datum.ToString("dd") + "*|"); datum = datum.AddDays(1); }
                else if (datum.Month > vorherigeMonat || datum.Year != jahr)
                { Console.Write("    |"); }
                else if (datum.DayOfWeek == DayOfWeek.Tuesday) { Console.Write(" " + datum.ToString("dd") + " |"); datum = datum.AddDays(1); }
                else { Console.Write("    |"); }


                if (datum == DateTime.Today) { Console.Write(" " + datum.ToString("dd") + "*|"); datum = datum.AddDays(1); }
                else if (datum.Month > vorherigeMonat || datum.Year != jahr)
                { Console.Write("    |"); }
                else if (datum.DayOfWeek == DayOfWeek.Wednesday) { Console.Write(" " + datum.ToString("dd") + " |"); datum = datum.AddDays(1); }
                else { Console.Write("    |"); }


                if (datum == DateTime.Today) { Console.Write(" " + datum.ToString("dd") + "*|"); datum = datum.AddDays(1); }
                else if (datum.Month > vorherigeMonat || datum.Year != jahr)
                { Console.Write("    |"); }
                else if (datum.DayOfWeek == DayOfWeek.Thursday) { Console.Write(" " + datum.ToString("dd") + " |"); datum = datum.AddDays(1); }
                else { Console.Write("    |"); }


                if (datum == DateTime.Today) { Console.Write(" " + datum.ToString("dd") + "*|"); datum = datum.AddDays(1); }
                else if (datum.Month > vorherigeMonat || datum.Year != jahr)
                { Console.Write("    |"); }
                else if (datum.DayOfWeek == DayOfWeek.Friday) { Console.Write(" " + datum.ToString("dd") + " |"); datum = datum.AddDays(1); }
                else { Console.Write("    |"); }


                if (datum == DateTime.Today) { Console.Write(" " + datum.ToString("dd") + "*|"); datum = datum.AddDays(1); }
                else if (datum.Month > vorherigeMonat || datum.Year != jahr)
                { Console.Write("    |"); }
                else if (datum.DayOfWeek == DayOfWeek.Saturday) { Console.Write(" " + datum.ToString("dd") + " |"); datum = datum.AddDays(1); }
                else { Console.Write("    |"); }


                if (datum == DateTime.Today) { Console.Write(" " + datum.ToString("dd") + "*|"); datum = datum.AddDays(1); }
                else if (datum.Month > vorherigeMonat || datum.Year != jahr)
                { Console.Write("    |"); }
                else if (datum.DayOfWeek == DayOfWeek.Sunday) { Console.Write(" " + datum.ToString("dd") + " |"); datum = datum.AddDays(1); }
                else { Console.Write("    |"); }

            }
        }
    }
}