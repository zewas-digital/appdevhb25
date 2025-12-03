using System;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe103
{
    class Buch
    {
        public string ISBN { get; set; }
        public string Titel { get; set; }
        public int Erscheinungsjahr { get; set; }
        public string Verlag { get; set; }
        public string Sprache { get; set; }
        public int Autor { get; set; }


        public Buch(string isbn, string titel, int erscheinungsjahr, string verlag, string sprache, int autor)
        {
            ISBN = isbn;
            Titel = titel;
            Erscheinungsjahr = erscheinungsjahr;
            Verlag = verlag;
            Sprache = sprache;
            Autor = autor;
        }
        
        public override string ToString()
        {
            return $"{ISBN} | {Titel} | {Erscheinungsjahr} | {Verlag} | {Sprache} | Autor: {Autor}";
        }
    }
}