using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe68
{
    public class AufgabeFotoapparat
    {
        /*Aufgabe:
        Erstelle eine Fotoapparat Klasse.
        Mit zumindest folgenden Attributen (es dürfen auch gerne mehr sein), Brennweite min/max, Model, Hersteller und Megapixel.
        Erstelle für die Attribute getter und setter mit sinnvollen Bedingungen für gültige Werte.
        Erstelle weiters die Methode takePhoto(), die ein Foto schießt (Mach einfach eine nette Ausgabe)
        Erstelle verschiedene Instanzen der Fotoapparat Klasse und Teste diese ausgiebig (setzen/lesen der Attribute über setter und getter).
        Gib in der Konsole ein einfaches Datenblatt mit den Eigenschaften pro Kamera aus.*/
        public static void Start()
        {
            Fotoapparat fotoapparat = new Fotoapparat();            
            fotoapparat.Brennweite = 55.5;
            fotoapparat.MacheEinFoto();
            fotoapparat.AusgabeBrennweite();            
        }
    }
}