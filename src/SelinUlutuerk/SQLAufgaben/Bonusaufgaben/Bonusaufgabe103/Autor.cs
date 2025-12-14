using System;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe103
{
    class Autor
    {
        public int ID { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }


        public Autor(int id, string vorname, string nachname)
        {
            ID = id;
            Vorname = vorname;
            Nachname = nachname;
        }
        
        public override string ToString()
        {
            return $"{ID}: {Vorname} {Nachname}";
        }
    }
}