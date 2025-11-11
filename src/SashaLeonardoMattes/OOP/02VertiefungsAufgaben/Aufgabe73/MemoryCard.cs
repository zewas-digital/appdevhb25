using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe73
{

    public class MemoryCard: Hardware
    {
        public int Size;

        public MemoryCard(int size, string model, string serialNumber):base(model, serialNumber)
        {
            Size = size;   
        }
    }
}