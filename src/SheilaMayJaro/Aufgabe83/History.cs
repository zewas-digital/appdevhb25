namespace Appdevhb25.SheilaMayJaro.Aufgabe83
{
    public class History
    {
        private string? _websiteName;
        private DateTime _websiteDateTime = DateTime.Now;
        public string? WebsiteName
        {
            get{return _websiteName;}
            set{_websiteName = value;}
        }
        public DateTime WebsiteDateTime
        {
            get{return _websiteDateTime;}
            private set{_websiteDateTime = value;}
        }
        public override string ToString()
        {
            return $"Vorherige Website '{WebsiteName}' besucht zum Zeitpunkt {_websiteDateTime}";
        }
    }
}