using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Appdevhb25.NoahHois.BonusAufgabe9
{
    public class DrawCalendar
    {

        const int CellWidth = 10;
        public static void Start()
        {
            // ─ │ ┌ ┐ └ ┘ ├ ┤ ┬ ┴ ┼|│
            Console.WriteLine("Welches Jahr: ");
            string inputYear = Console.ReadLine();
            int integerInputYear = Convert.ToInt32(inputYear);

            Console.WriteLine("Welcher Monat: ");
            string inputMonth = Console.ReadLine();
            int integerInputMonth = Convert.ToInt32(inputMonth);

            Console.WriteLine("Welcher Tag: ");
            string inputDay = Console.ReadLine();
            int integerInputDay = Convert.ToInt32(inputDay);

            DateTime date = new DateTime(integerInputYear, integerInputMonth, integerInputDay);

            DateTime firstOfMonth = new DateTime(integerInputYear, integerInputMonth, 1);

            DateTime endDate = firstOfMonth.AddMonths(1).AddDays(-1);


            // Berechnung für den ersten Tag in der Tabelle
            int daysInMonthBefore = 0;
            if (firstOfMonth.DayOfWeek == DayOfWeek.Sunday)
            {
                daysInMonthBefore = CellWidth;
            }
            else
            {
                daysInMonthBefore = (int)firstOfMonth.DayOfWeek - 1;
            }

            DateTime firstOfTable = firstOfMonth.AddDays(-daysInMonthBefore);

            // Berechnung letzter Tag in der Tabelle
            int daysInMonthAfter = 0;
            if (endDate.DayOfWeek == DayOfWeek.Sunday)
            {
                daysInMonthAfter = 0;
            }
            else
            {
                daysInMonthAfter = 7 - (int)endDate.DayOfWeek;
            }
            DateTime lastOfTable = endDate.AddDays(daysInMonthAfter);

            TimeSpan daysOfTable = lastOfTable.Subtract(firstOfTable);

            //Ausgabe
            Console.WriteLine();
            Console.WriteLine(date.ToString("yyyy MMMM"));

            // Tabellenkopf zeichnen
            Console.WriteLine($"┌{new string('─', CellWidth)}┬{new string('─', CellWidth)}┬{new string('─', CellWidth)}┬{new string('─', CellWidth)}┬{new string('─', CellWidth)}┬{new string('─', CellWidth)}┬{new string('─', CellWidth)}┐");
            DateTime endOfFirstWeek = firstOfTable.AddDays(6);
            DateTime x = firstOfTable;
            while (x <= endOfFirstWeek)
            {
                Console.Write($"│{string.Format("{0, " + (CellWidth - 1) + "}", x.ToString("ddd"))} ");
                x = x.AddDays(1);
            }
            Console.WriteLine("│");

            //Tabelle zeichnen
            DateTime i = firstOfTable;
            Console.WriteLine($"├{new string('─', CellWidth)}┼{new string('─', CellWidth)}┼{new string('─', CellWidth)}┼{new string('─', CellWidth)}┼{new string('─', CellWidth)}┼{new string('─', CellWidth)}┼{new string('─', CellWidth)}┤");
            while (i <= lastOfTable)
            {
                if (integerInputMonth == i.Month)
                {
                    Console.Write($"│{string.Format("{0, " + (CellWidth - 1) + "}", i.Day)}");
                    if (integerInputDay == i.Day)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write($"│{new string(' ', CellWidth)}");
                }
                if (i.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine("│");
                    if (i != lastOfTable)
                    {
                        Console.WriteLine($"├{new string('─', CellWidth)}┼{new string('─', CellWidth)}┼{new string('─', CellWidth)}┼{new string('─', CellWidth)}┼{new string('─', CellWidth)}┼{new string('─', CellWidth)}┼{new string('─', CellWidth)}┤");
                    }
                    else
                    {
                        Console.WriteLine($"└{new string('─', CellWidth)}┴{new string('─', CellWidth)}┴{new string('─', CellWidth)}┴{new string('─', CellWidth)}┴{new string('─', CellWidth)}┴{new string('─', CellWidth)}┴{new string('─', CellWidth)}┘");
                    }
                }
                i = i.AddDays(1);
            }
        }
    }
}