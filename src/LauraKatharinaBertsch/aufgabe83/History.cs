using System.Data.Common;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe83
{
    public class History
    {
        public DateTime CreatedAt;
        public string WebsiteName;

        public History(string websiteInput)
        {
            CreatedAt = DateTime.Now;
            WebsiteName = websiteInput;
        }
        public override string ToString()
        {
            return WebsiteName + ", geöffnet am: " + CreatedAt.ToString("dd.MM.yyyy HH:mm") + " Uhr";
        }
    }
}