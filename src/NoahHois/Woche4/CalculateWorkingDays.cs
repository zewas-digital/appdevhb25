namespace Appdevhb25.NoahHois.Aufgabe40
{
    public class CalculateWorkingDays
    {
        public static void Start()
        {



            Console.WriteLine("Gib bitte ein Jahr ein: ");
            string inputYears = Console.ReadLine();
            int inputToIntYears = Convert.ToInt32(inputYears);

            Console.WriteLine("Für welchen Monat würdest du gerne die Arbeitstage wissen? Eingabe: ");
            string inputMonths = Console.ReadLine();
            int inputToIntMonths = Convert.ToInt32(inputMonths);

            int lastDayOfMonth = DateTime.DaysInMonth(inputToIntYears, inputToIntMonths);
            DateTime date = new DateTime(inputToIntYears, inputToIntMonths, 1);

            int dayOfMonth = 0;
            int foundWorkingDays = 0;

            while (dayOfMonth < lastDayOfMonth)
            {
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    foundWorkingDays++;
                }
                date = date.AddDays(1);
                dayOfMonth++;
            }
            Console.WriteLine($"Arbeitstage: {foundWorkingDays}");
        }
    }
}