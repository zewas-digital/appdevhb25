using System;

namespace Appdevhb25.OliverBedogg.objektorientierung
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age) { }

        public string GetStudentSecret()
        {
            return Secret; // Zugriff auf protected Member aus der Basisklasse
        }
    }
}