namespace Appdevhb25.JulianMatt.Aufgabe80
{
    public class Participants
    {
        public string Name;
        public string LastName;

        private double _hourlyPaiment;

        public double HourlyPaiment
        {
            get { return _hourlyPaiment; }
            set
            {
                if (value > 14.81)
                {
                    System.Console.WriteLine("Invalider Input");
                }
                else
                {
                    _hourlyPaiment = value;
                }
            }
        }

        public double Absence;

        public Participants(string name, string lastName, double hourlyPaiment, double absence)
        {
            Name = name;
            LastName = lastName;
            HourlyPaiment = hourlyPaiment;
            Absence = absence;
        }
    }
}

