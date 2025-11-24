using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Appdevhb25.SheilaMayJaro.Aufgabe87
{
    public class AbsenceList
    {
        private Dictionary<string, List<Absence>> CollectionOfAbsences { get; init; } = new Dictionary<string, List<Absence>>();
        public void AddAbsenceEntry(string lastName, Absence absence)
        {

            if (CollectionOfAbsences.ContainsKey(lastName))
            {
                CollectionOfAbsences[lastName].Add(absence);
            }
            else
            {
                CollectionOfAbsences.Add(lastName, new List<Absence>() { absence });
            }
        }
        public TimeSpan HoursOfAbsence(string name)
        {
            TimeSpan absenceHours = new TimeSpan();
                foreach (Absence absence in CollectionOfAbsences[name])
                {
                    absenceHours += absence.HoursOfAbsence();
                }
            return absenceHours;
        }
    }
}