namespace Appdevhb25.KerimAlkis.Aufgabe08
{
    public class PrintTriangle2
    {
        public static void Start(int breite, int hoehe)
        {
            

            //1. Dreieck
            int breite2 = breite;
            for (int i = 0; i < hoehe; i++)
            {
                for (int y = 0; y < breite2; y++)
                {
                    Console.Write("X");
                }
                breite2 -= 1;
                Console.WriteLine();
            }

            Console.WriteLine();

            

            //2. Dreieck
            int zaehler2 = 0;
            for (int i = 0; i < hoehe; i++)
            {
                for (int y = 0; y < breite; y++)
                {
                    if (y < zaehler2)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                }
                zaehler2++;
                Console.WriteLine();
            }


            Console.WriteLine();

            //3. Dreieck
            int zaehler3 = breite;
            for (int i = 0; i < hoehe; i++)
            {
                for (int y = 0; y < breite; y++)
                {
                    if (y < zaehler3 - 1)
                    {
                        Console.Write(" ");
                    }
                    else { Console.Write("X"); }
                }
                zaehler3--;
                Console.WriteLine();
            }

            Console.WriteLine();

            //4. Dreieck
            int zaehler4 = 0;
            for (int i = 0; i < hoehe; i++)
            {
                for (int y = 0; y < breite; y++)
                {
                    if (y <= zaehler4)
                    {
                        Console.Write("X");
                    }
                    else { Console.Write(" "); }
                }
                zaehler4++;
                Console.WriteLine();
            }
            
        }
    }
}