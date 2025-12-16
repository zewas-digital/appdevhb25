using System;
using System.Net.Sockets;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe89
{
    
    public  class Auto89
    {
        string Fahrgestell;
        List<Reifen89> reifen = new List<Reifen89>();        

        public Auto89(string fahrgestell, int reifen)
        {
            Fahrgestell = fahrgestell;            
        }
    }
}