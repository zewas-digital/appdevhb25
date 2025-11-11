namespace Appdevhb25.LiaLouiseNatter.Aufgabe72
{
    public class Objektiv
    {
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

        public Objektiv(string kameraObjektiv)
        {
            KameraObjektiv = kameraObjektiv;
        }

        public void ObjektivPrinter()
        {
            System.Console.WriteLine($"Objektiv: {KameraObjektiv}");
        }

    }
}