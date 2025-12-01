namespace Appdevhb25.JonaSchnell.Aufgabe84
{
    public class Interface()
    {
        public static void Start()
        {
            IGegenstand meinAuto = new Auto();
            IGegenstand meinMotorrad = new Motorrad();
            meinAuto.InventarNummer();
            meinMotorrad.InventarNummer();
        }
    }

    public interface IGegenstand
    {
        void InventarNummer();
    }

    public class Auto : IGegenstand
    {
        public void InventarNummer()
        {
            System.Console.WriteLine("ABC123");
        }
    }
    
    public class Motorrad : IGegenstand
    {
        public void InventarNummer()
        {
            System.Console.WriteLine("DEF456");
        }
    }
}