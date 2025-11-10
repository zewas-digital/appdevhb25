using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe73
{
    public class Objektiv : Hardware
    {
        private float _brennWeite;
        public float BrennWeite
        {
            get
            {
                return _brennWeite;
            }
            set
            {
                _brennWeite = value;
            }
        }

        private string _kameraObjektiv;
        public string KameraObjektiv
        {
            get
            {
                return _kameraObjektiv;
            }
            set
            {
                _kameraObjektiv = value;
            }
        }

        public Objektiv(string seriennumer,string modell,float brennWeite):base(modell, seriennumer)
        {
            BrennWeite = brennWeite;
        }

        

        public void ObjektivPrinter()
        {
            System.Console.WriteLine($"Objektiv: {BrennWeite}");
        }
        public override string ToString()
        {
            return $"{base.ToString()} Brennweite: {BrennWeite}";
        }

    }
}