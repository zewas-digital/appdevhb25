using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe66
{

    public class Person
    {
        public double Height;
        public DateTime BirthDate;
        public string? Name;
        public double Weight;

        public void PrintPerson()
        {
            System.Console.WriteLine($"Name: {Name} Geburtsdatum: {BirthDate:d} Größe: {Height} Gewicht: {Weight}"); //:d ändert Format
        }

        public void WriteBirthDay()
        {
            TimeSpan age = DateTime.Now - this.BirthDate;
            System.Console.WriteLine($"Alter von {this.Name}: {age.Days/365}");
        }

       
        
    }
}