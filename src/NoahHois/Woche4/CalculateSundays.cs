namespace Appdevhb25.NoahHois.Aufgabe39
{
    public class CalculateSundays
    {
        public static void Start()
        {
            DateTime todaysDate = DateTime.Now;
            int foundSundays = 0;

            while (foundSundays < 3)
            {
                if (todaysDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine($"Sonntag {++foundSundays}: " + todaysDate);

                }
                todaysDate = todaysDate.AddDays(1);
            }
        }

    }
}