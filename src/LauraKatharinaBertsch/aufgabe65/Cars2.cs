namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe65
{
    public class Car()
    {



        private double _kilometerstand;

        public double Kilometerstand
        {
            get
            {
                return _kilometerstand;
            }
            set
            {
                if (value > _kilometerstand)
                {
                    _kilometerstand = value;
                }
                else
                {
                    Console.WriteLine("Der Kilometerstand darf nicht kleiner werden.");
                }
            }
        }
        public void Fahren(int distanz)
        {
            Console.WriteLine("Kilometerstand vorher: " + Kilometerstand);
            Kilometerstand = Kilometerstand + distanz;
            Console.WriteLine("Distanz: " + distanz);
            Console.WriteLine("Kilometerstand nachher: " + Kilometerstand);
        }
    }
}