using System.Data.SqlTypes;

namespace Appdevhb25.SheilaMayJaro.Aufgabe84
{
    public class MemoryCard : ISubject
    {
        //8GB Speicherplatz -> 8000MB
        public double MaxStorageSpace { get; set; }
        private double _storageSpaceUsed = 0;
        public double StorageSpaceUsed
        {
            get
            {
                return _storageSpaceUsed; //gibt zurück wieviel Speicherplatz verbraucht ist
            }
            internal set
            {
                if (StorageSpaceUsed >= MaxStorageSpace - 1000) //Damit die Benachrichtigung kommt, dass man den Speicherplatz etwas leeren soll 
                {
                    System.Console.WriteLine("Geringer Speicherplatz");
                }
                _storageSpaceUsed = value;
            }
        }

        public string? InventoryNumber { get; set; }

        public double HowMuchStorageSpace()
        {
            return MaxStorageSpace - StorageSpaceUsed;
        }

        public string GetSubjectInfo()
        {
            return "Das ist eine Speicherkarte"; 
        }
    }
}