using System.Formats.Asn1;
using System.Globalization;
using System.Xml.Serialization;

namespace Appdevhb25.JulianMatt.Aufgabe75
{
    public class Person
    {
        private double _hight;

        public double Hight
        {
            get { return _hight; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("Du kannst nicht so klein sein");
                }
                else if (value < 3)
                {
                    value *= 100;
                    _hight = value;
                }
                else
                {
                    _hight = value;
                }

            }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Mann kann nicht Jünger als 0 sein");
                }
                else
                {
                    _age = value;
                }
            }
        }
        public string Name;
        private double _wieght;

        public double Wieght
        {
            get { return _wieght; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("Du kannst nicht unter 0,1 kg wiegen");
                }
                else
                {
                    _wieght = value;
                }
            }
        }

        public Person( string name, int age, double hight, double wieght)
        {
            Name = name;
            Age = age;
            Hight = hight;
            Wieght = wieght;
        }
    }
}