using System;

namespace Appdevhb25.OliverBedogg.objektorientierung
{

    public class Person // public: überall zugreifbar
    {
        public string Name { get; set; } // öffentlich, überall sichtbar

        private int age; // private: nur innerhalb von Person sichtbar
        public int Age   // öffentliche Eigenschaft mit privatem Setter
        {
            get { return age; }
            private set { age = value; } // Setter ist nur intern sichtbar
        }

        protected string Secret = "Nur für abgeleitete Klassen sichtbar"; // protected

        internal string InternalInfo = "Nur im gleichen Assembly sichtbar"; // internal

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string GetSecret()
        {
            return Secret; // Zugriff auf protected Member innerhalb der Klasse
        }
    }
}