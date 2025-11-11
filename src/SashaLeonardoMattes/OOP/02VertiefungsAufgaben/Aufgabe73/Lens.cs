using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe73
{

    public class Lens: Hardware
    {
        public int FocalLength { get; set; }
        
        public Lens(string model, string serialNumber):base(model, serialNumber)
        {
            
        }
    }
}