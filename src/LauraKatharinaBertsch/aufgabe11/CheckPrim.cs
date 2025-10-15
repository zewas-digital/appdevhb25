namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe11
{
    public class CheckPrim
    {
        public static int Start(int number)
        {
            if (number > 1)
            {
                if (number == 2)
                {
                    return +1;
                }
                else if (number % 2 == 0)
                {
                    return -1;
                }
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return -1;
                    }
                   
                }
                return +1;

            }return 0;
        }
    }
}