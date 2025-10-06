namespace Appdevhb25.KerimAlkis.Bonusaufgabe03
{
    public class PrintChristmasTree
    {
        public static void Start()
        {
            int inputSize;
            do
            {
                Console.Clear();
                Console.WriteLine("Size: ");
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    inputSize= inputNumber; break;
                }
            } while (true);


            PrintChristmasTree1(inputSize);
        }
        public static void PrintChristmasTree1(int size)
        {
            bool stop = false;
            for (int y = 0; stop == false; y++)
            {
                for (int x = -size+1; x < size; x++)
                {
                    if (x <= y && x >= 0 - y)
                    {
                        if (x == size - 1)
                        {
                            Console.Write("X");
                            stop = true;


                            int zaehlerKugel = 1;
                            do
                            {
                                System.Console.WriteLine();
                                for (int i = -size; i <= -1; i++)
                                {
                                    Console.Write("0");
                                    Console.Write(" ");
                                }
                                zaehlerKugel++;

                            } while (zaehlerKugel <= size / 3 / 3);

                            int zaehlerStamm = 1;
                            do
                            {
                                System.Console.WriteLine();
                                for (int i = -size + 1; i <= size; i++)
                                {
                                    if (i >= -2 && i <= 2)
                                    {
                                        Console.Write("+");
                                    }
                                    else { Console.Write(" "); }
                                }
                                zaehlerStamm++;
                            } while (zaehlerStamm <= (size / 3 / 3) * 2);
                        }
                        else { Console.Write("X"); }
                    }
                    else { Console.Write(" "); }
                }
                System.Console.WriteLine();
            }
            
        }
    }
}