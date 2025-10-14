namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe41
{
    public class CinemaRevenue
    {
        public static void Start()
        {
            Console.WriteLine("Wir haben ein Kino und berechnen unseren Umsatz");



            Random random1 = new Random();
            int randomNumber1 = random1.Next(2, 7);
            int[] tickets1 = new int[randomNumber1];

            for (int i = 1; i < randomNumber1; i++)
            {
                Random randomNumb1 = new Random();
                int randomTicket1 = randomNumb1.Next(1, 100);
                tickets1[i] = randomTicket1;
                Console.WriteLine("Raum 1: Vorstellung " + i + ": " + "Anzahl der verkauften Tickets: "+tickets1[i]);
            }
            Console.WriteLine();

            Random random2 = new Random();
            int randomNumber2 = random2.Next(2, 7);
            int[] tickets2 = new int[randomNumber2];

            for (int i = 1; i < randomNumber2; i++)
            {
                Random randomNumb2 = new Random();
                int randomTicket2 = randomNumb2.Next(1, 100);
                tickets2[i] = randomTicket2;
                Console.WriteLine("Raum 2: Vorstellung " + i + ": " + "Anzahl der verkauften Tickets: "+tickets2[i]);
            }
            Console.WriteLine();

             Random random3 = new Random();
            int randomNumber3 = random3.Next(2, 7);
            int[] tickets3 = new int[randomNumber3];

            for (int i = 1; i < randomNumber3; i++)
            {
                Random randomNumb3 = new Random();
                int randomTicket3 = randomNumb3.Next(1, 100);
                tickets3[i] = randomTicket3;
                Console.WriteLine("Raum 3: Vorstellung " + i + ": " + "Anzahl der verkauften Tickets: "+tickets3[i]);
            }
            Console.WriteLine();

             Random random4 = new Random();
            int randomNumber4 = random4.Next(2, 7);
            int[] tickets4 = new int[randomNumber4];

            for (int i = 1; i < randomNumber4; i++)
            {
                Random randomNumb4 = new Random();
                int randomTicket4 = randomNumb4.Next(1, 100);
                tickets4[i] = randomTicket4;
                Console.WriteLine("Raum 4: Vorstellung " + i + ": " + "Anzahl der verkauften Tickets: "+tickets4[i]);
            }
            Console.WriteLine();

             Random random5 = new Random();
            int randomNumber5 = random5.Next(2, 7);
            int[] tickets5 = new int[randomNumber5];

            for (int i = 1; i < randomNumber5; i++)
            {
                Random randomNumb5 = new Random();
                int randomTicket5 = randomNumb5.Next(1, 100);
                tickets5[i] = randomTicket5;
                Console.WriteLine("Raum 5: Vorstellung " + i + ": " + "Anzahl der verkauften Tickets: "+tickets5[i]);
            }
            Console.WriteLine();
        }
    }
}