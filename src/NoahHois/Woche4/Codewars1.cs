using System.Threading.Tasks.Dataflow;

namespace Appdevhb25.NoahHois.CodewarsAufgabe1
{
    public class Codewars1
    {
        public static bool Solution(string str, string ending)
        {
            str = "abc";
            ending = "bc";
            if (ending.Length > str.Length)
            {
                return false;
            }

            for (int i = 0; i < ending.Length; i++)
            {
                if (str[str.Length - 1 - i] != ending[ending.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
