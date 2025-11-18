

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe79
{
    public class StreamingPlattform
    {
        public static Dictionary<Serie, int> serienList = new Dictionary<Serie, int>();

        public static void Initialize()
        {
            var serie1 = new Serie("Sendung mit der Maus", 1, "Armin Maiwald", "Christoph Biemann", "Ralph Caspers");
        }
        public static void AddEvaluate(Serie serie, int evaluate)
        {
            serienList.Add(serie, evaluate);
        }
        public static void InitializeSeries()
        {
            Serie serie1 = new Serie("SendungMitDerMaus", 1, "Armin Maiwald", "Christoph Biemann", "Ralph Caspers");
            AddEvaluate(serie1, 8);

            Console.WriteLine(serie1.ToString());

            Serie serie2 = new Serie("Pumuckl", 2, "Gustl Bayrhammer", "Hans Clarin", "Erni Singerl");
            AddEvaluate(serie2, 10);

            Console.WriteLine(serie2.ToString());

            Serie serie3 = new Serie("LaurasStern", 3, "Heilwig Weindorfer", "Ranja Bonalana", "Detlef Bierstedt");
            AddEvaluate(serie3, 6);

            Console.WriteLine(serie3.ToString());

            Serie serie4 = new Serie("ShaunDasSchaf", 4, "Justin Fletcher", "John Sparkes");
            AddEvaluate(serie4, 4);

            Console.WriteLine(serie4.ToString());

        }
    }
}