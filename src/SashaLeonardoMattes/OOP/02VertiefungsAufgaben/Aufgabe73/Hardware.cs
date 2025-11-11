using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe73
{

    public class Hardware
    {
        public string? Model;
        public string? SerialNumber;
        
        public Hardware(string model, string serialnumber)
        {
            Model = model;
            SerialNumber = serialnumber;
        }
        
    }
}