namespace Appdevhb25.KerimAlkis.Bonusaufgabe06
{
    public class BerechnungVonPi_Nilakantha
    {
        public static void Start()
        {
            Console.Write("How many Numbers of PI? ");
            int count = Convert.ToInt32(Console.ReadLine());
            double piNumber = CalculatePiV2(count);
            Console.WriteLine("Calculated Pi: " + piNumber);
        }


        public static double CalculatePiV2(int count)
        {
            double piNumber = 3.0;
            double plusminus = 1.0;
            int counter = 0;

            for (int i = 1; i <= count; i++)
            {
                double adder = (2 * i * (2 * i + 1) * (2 * i + 2));
                counter++;

                if (counter % 2 == 0)
                {
                    plusminus = -1.0;
                }
                else
                {
                    plusminus = 1.0;
                }

                piNumber += plusminus * (4 / adder);


            }
            return piNumber;
            
        }
    }
}