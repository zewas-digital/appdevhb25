using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe75
{

    public class Person
    {
        public string? Name;
        public int Age;
        public int Height;
        public int Wheight;

         public Person()
        {

        }
        
        public Person(string name, int age, int height, int wheight)
        {
            Name = name;
            Age = age;
            Height = height;
            Wheight = wheight;
        }
    }
}