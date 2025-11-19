using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe84
{

    public interface IObject
    {
        public string InventoryNumber { get; set; }
        public string GetObjectInfo();        
    }
}
