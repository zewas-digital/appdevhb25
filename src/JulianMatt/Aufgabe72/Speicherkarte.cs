

namespace Appdevhb25.JulianMatt.Aufgabe72
{
    public class Speicherkarte
    {
        private double _saveKapacity;

        public double SaveKapacity
        {
            get { return _saveKapacity; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Der speicher kann nicht 0 sein");
                }
                else
                {
                    _saveKapacity = value;
                }
            }
        }

        public Speicherkarte(double saveKapacity)
        {
            SaveKapacity = saveKapacity;
        }

        public void TakeAPhoto()
        {

            System.Console.WriteLine("Wie viele Fotos wollen sie nehmen");
            double amountOfPictures = Convert.ToDouble(Console.ReadLine());


            double spaceThatWouldBeTaken = Objekt.Objektiv() * amountOfPictures;
            if (SaveKapacity - spaceThatWouldBeTaken < 0)
            {
                System.Console.WriteLine("Du hast dafür nicht genügend Speicher");
                return;
            }
            else
            {
                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.WriteLine($"Du hast {amountOfPictures} Foto/s geschossen");
                SaveKapacity -= spaceThatWouldBeTaken;
                System.Console.WriteLine("Es sind noch " + SaveKapacity + " GB frei");
            }

        }
    }
}
