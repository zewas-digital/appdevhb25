using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace Appdevhb25.SheilaMayJaro.Aufgabe87
{
    public class Absence
    {
        private DateTime _startTime;
        private DateTime _endTime;
        public DateTime StartTime
        {
            get { return _startTime; }
            private set { _startTime = value; }
        }
        public DateTime EndTime
        {
            get { return _endTime; }
            private set { _endTime = value; }
        }
        public Absence()
        {

        }
        public Absence(DateTime startTime, DateTime endTime)
        {
            _startTime = startTime;
            _endTime = endTime;
        }
        public TimeSpan HoursOfAbsence()
        {
            //Summe der Abwesenheitsstunden einer Person ausrechnen
            TimeSpan absenceHours = EndTime - StartTime;
            return absenceHours;
        }
    }
}