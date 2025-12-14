using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;


namespace Appdevhb25.SashaLeonardoMattes.Aufgabe103
{

    public class Book
    {
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public int Releaseyear { get; set; }
        public string? Publisher { get; set; }
        public string? Language { get; set; }
        public int Author { get; set; }

    }
}
