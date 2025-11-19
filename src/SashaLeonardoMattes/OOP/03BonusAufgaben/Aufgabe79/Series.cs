using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe79
{

    public class Series
    {
        public string? Name { get; set; }
        public string? ID { get; set; }
        public List<(string firstName, string lastName)> actors = new List<(string, string)>();

        public Series(string id, string name)
        {
            ID = id;
            Name = name;
        }

    }

}