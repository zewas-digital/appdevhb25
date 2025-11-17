namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe79
{
    public class Serie
    {
        public int SerienID { get; init; }
        public string SerienName { get; init; }
        public List<Tuple<string, string>> Cast;

        public Serie(int serienID, string serienName)
        {
            SerienID = serienID;
            SerienName = serienName;
            Cast = new List<Tuple<string, string>>();
        }

        public void CastListeAusgeben()
        {
            Console.WriteLine("Cast von " + SerienName + ":");
            foreach (var castmember in Cast)
            {
                Console.WriteLine(castmember.Item1 + " " + castmember.Item2);
            }
        }

        public override string ToString()
        {
            return $"{SerienID}. {SerienName}";
        }
    }
}