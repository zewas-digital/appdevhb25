namespace Appdevhb25.SheilaMayJaro.Aufgabe73
{
    public class CameraLens : Hardware
    //Brennweite
    {
        public int _focalLength; 
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

        public CameraLens(string model, string serialNumber, int focalLength) : base(model, serialNumber)
        {
            _focalLength = focalLength;
        }
        
        public override string ToString()
        {
            return
            $"Modell: {Model,10}\nSeriennummer: {SerialNumber,5}\nBrennweite: {_focalLength}";
        }
    }
}