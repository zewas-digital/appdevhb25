namespace Appdevhb25.SheilaMayJaro.Aufgabe84
{
    public class CameraLens : ISubject
    {
        private int _focalLengthmin = 14; //Brennweite Minimum in mm
        public int FocalLengthMin
        {
            get
            {
                return _focalLengthmin;
            }
            set
            {
                if (value > _focalLengthmin)
                {
                    _focalLengthmin = value;
                }
                else
                {
                    System.Console.WriteLine("Brennweite kann nicht kleiner eingestellt werden.");
                }
            }
        }
        private int _focalLengthmax = 200; //Brennweite Maximum in mm
        public int FocalLengthMax
        {
            get
            {
                return _focalLengthmax;
            }
            set
            {
                if (value < _focalLengthmax)
                {
                    _focalLengthmax = value;
                }
                else
                {
                    System.Console.WriteLine("Brennweite kann nicht größer eingestellt werden.");
                }
            }
        }

        public string? InventoryNumber { get; set; }

        public string GetSubjectInfo()
        {
           return "Das ist ein Kameraobjektiv";
        }
    }
}