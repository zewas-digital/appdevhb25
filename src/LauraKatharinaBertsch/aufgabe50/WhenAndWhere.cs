namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe50
{
    public class WhenAndWhere
    {
        public static void Start()
        {
            showsDate();
            showsTime();
            showsDateAndTime();
            showsDateAndTimeAndTimezone();
            showsSeconds();
        }
        public static void showsDate()
        {
            DateTime date = new DateTime(2025, 10, 21);
            Console.WriteLine(date.ToString("d MMM yyyy"));
        }
        public static void showsTime()
        {
            DateTime moment = DateTime.Now;
            Console.WriteLine(moment.ToString("h:mm:ss"));
        }
        public static void showsDateAndTime()
        {
            DateTime moment = DateTime.Now;
            Console.WriteLine(moment.ToString("dd MMM HH:mm:ss"));
        }
        public static void showsDateAndTimeAndTimezone()
        {
            DateTime moment = DateTime.Now;
            Console.WriteLine(moment.ToString("HH:mm:ss.ffffzzz"));
        }
        public static void showsSeconds()
        {
            DateTime moment = DateTime.Now;
            Console.WriteLine(moment.ToString("ss.ffff"));
        }

    }
}