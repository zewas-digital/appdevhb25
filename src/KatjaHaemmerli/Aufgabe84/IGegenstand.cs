using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe84
{
    public interface IGegenstand
    {
        string Marke {get; set;}
        string Farbe {get; set;}
        string Seriennummer {get; set;}

         public void AusgabeDerAttributte();       
        
    }
}