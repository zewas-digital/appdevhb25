namespace Appdevhb25.JonaSchnell.Aufgabe21
{
    public class Aufgabe21

    {

        public static void Start21()
        {
            Console.WriteLine("Das sind die Zahlen von 1-20 Faktorial.");
            long numbers = 1;
            long a1 = 0;
            int i = 1;
            while (a1 < 20)
            {
                a1 = a1 + 1;
                numbers = numbers * a1;
                Console.Write(i + "!" + " = ");
                if (numbers < 10)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 100)
                {
                    for (int j = 0; j < 19; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 1000)
                {
                    for (int j = 0; j < 18; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 10000)
                {
                    for (int j = 0; j < 17; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 100000)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 1000000)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 10000000)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 100000000)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 1000000000)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 10000000000)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 100000000000)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 1000000000000)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 10000000000000)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 100000000000000)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 1000000000000000)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 10000000000000000)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 100000000000000000)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else if (numbers < 1000000000000000000)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(numbers);
                i++;
            }
        }
    }
}
