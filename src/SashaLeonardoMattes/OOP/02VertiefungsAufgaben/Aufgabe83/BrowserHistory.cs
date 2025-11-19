using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe83
{

    public class Browserhistory
    {
        public string? Name;
        public DateTime visitDate;
        public Browserhistory(string name, DateTime date)
        {
            Name = name;
            visitDate = date;
        }

        public override string ToString()
        {
            return $"\n----------------------------------------------------------\nDu bist jetzt auf der Website: {Name}\nUrsprünglicher Aufruf: {visitDate}\n----------------------------------------------------------\n";
        }

    }
}