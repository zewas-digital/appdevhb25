namespace Appdevhb25.SheilaMayJaro.Aufgabe79
{
    public class Series
    {
        //Konstruktoren nur mit Übergabe vom Namen und der ID 
        private string? _title;
        private int _iDNumber;

        private double _rating; 

        public Actor actor = new Actor(); 
        public string? Title
        {
            get{return _title;}
            private set{_title = value;}
        }
        public int IDNumber
        {
            get{return _iDNumber;}
            private set{_iDNumber = value;}
        }
        public double Rating
        {
            get{return _rating;}
            set{_rating = value;}
        }
        public Series(string title, int IDNumber)
        {
            _title = title; 
            _iDNumber = IDNumber;
        }
        public Series()
        {
            
        }
    }
}