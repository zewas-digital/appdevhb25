using System.Globalization;
using System.Runtime.InteropServices.ObjectiveC;
using System.Xml.Serialization;

namespace Appdevhb25.JulianMatt.Aufgabe72
{
    public class Objekt
    {
        public string ObjModel;

        public int Zoom;

        public double SaveTaker;
        public Objekt(string objModel, int zoom, double saveTaker)
        {
            ObjModel = objModel;
            Zoom = zoom;
            SaveTaker = saveTaker;
        }
        
        public static double Objektiv()
        {
            System.Console.WriteLine("Welches Objektiv möchten sie benutzen?");
            Objekt[] objektiv = new Objekt[4];
            objektiv[0] = new Objekt("Standard Objektiv", 200, 0.5);
            objektiv[1] = new Objekt("Weitwinkel Objektiv", 50, 0.2);
            objektiv[2] = new Objekt("Tele Objektiv", 500, 0.6);
            objektiv[3] = new Objekt("Makro Objektiv", 100, 0.3);

            for (int i = 0; i < objektiv.Length; i++)
            {
                System.Console.WriteLine($"[{i + 1}]: {objektiv[i].ObjModel} mit Zoom von {objektiv[i].Zoom}mm und Speicherverbrauch von {objektiv[i].SaveTaker}GB pro Foto");
            }

            int choosing = Convert.ToInt32(Console.ReadLine());
            
            return objektiv[choosing - 1].SaveTaker;
        }
    }
}