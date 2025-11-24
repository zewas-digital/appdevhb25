namespace Appdevhb25.NoahHois.Aufgabe83
{
    public class History
    {
        public string Name;
        public DateTime DateAndTime;

        public History(string name, DateTime dateAndTime)
        {
            Name = name;
            DateAndTime = dateAndTime;
        }
        public string ToString()
        {
            return $"Name der Website: {Name}, Datum und Uhrzeit: {DateAndTime.ToString()}";
        }
    }
}