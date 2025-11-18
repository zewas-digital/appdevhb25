namespace Appdevhb25.JulianMatt.Aufgabe83
{
    public class HistoryObjekte
    {
        public string URL;

        public DateTime TimeWhenVisited;

        public override string ToString()
        {
            return ($"Die jetzige Websie ist: {URL} um {TimeWhenVisited}");
        }

    }
}