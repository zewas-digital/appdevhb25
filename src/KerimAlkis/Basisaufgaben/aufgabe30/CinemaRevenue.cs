using System.Security.AccessControl;

namespace Appdevhb25.KerimAlkis.Aufgabe30
{
    public class CinemaRevenue
    {
        public static void Start()
        {
            int[][] kinoRaeume = new int[5][];

            kinoRaeume[0] = new int[2];
            kinoRaeume[1] = new int[3];
            kinoRaeume[2] = new int[4];
            kinoRaeume[3] = new int[5];
            kinoRaeume[4] = new int[6];

            Random rndZahl = new Random();

            for (int i = 0; i < kinoRaeume.GetLength(0); i++)
            {
                for (int j = 0; j < kinoRaeume[i].Length; j++)
                {
                    kinoRaeume[i][j] = rndZahl.Next(1, 100);
                }
            }
            System.Console.WriteLine();
            Console.WriteLine("Tickets pro Vorstellung");
            foreach (int[] z in kinoRaeume)
            {
                foreach (int tickets in z)
                {
                    Console.Write(tickets + " ");
                }
                System.Console.WriteLine();
            }
            
            Console.WriteLine("Verkaufte Tickets pro Raum");
            int zaehler = 1;
            int verkauftinsgesamt = 0;
            foreach (int[] raum in kinoRaeume)
            {
                int tickets = 0;
                foreach (int ticket in raum)
                {
                    tickets += ticket;
                }
                Console.WriteLine("Raum " + zaehler + ": " + tickets);
                zaehler++;
                verkauftinsgesamt += tickets;
            }
            Console.WriteLine("Insgesamt verkaufte Tickets: " + verkauftinsgesamt);
            System.Console.WriteLine();

            zaehler = 1;
            foreach (int[] raum in kinoRaeume)
            {
                int tickets = 0;
                foreach (int ticket in raum)
                {
                    tickets += ticket;
                }
                Console.WriteLine("Durchschnittlicher Verkauf an Tickets im Raum " + zaehler + ": " + (tickets / raum.Length - 1));
                zaehler++;
            }
            Console.WriteLine("Durchschnittlicher Verkau an Ticket insgesamt: " + (verkauftinsgesamt/kinoRaeume.GetLength(0)-1));

            System.Console.WriteLine();
            int meistverkauftinsgesamt = 0;
            int meistverkauftRaum = 0;
            int meistverkauftVorstellung = 0;
            for(int i = 0; i < kinoRaeume.GetLength(0); i++)
            {
                int meistverkauft = 0;
                int vorstellungzaehler = 0;
                for (int j = 0; j < kinoRaeume[i].Length; j++)
                {
                    if (kinoRaeume[i][j] > meistverkauft)
                    {
                        meistverkauft = kinoRaeume[i][j];
                        vorstellungzaehler = j + 1;
                    }
                }
                if(meistverkauft > meistverkauftinsgesamt)
                {
                    meistverkauftinsgesamt = meistverkauft;
                    meistverkauftRaum = i + 1;
                    meistverkauftVorstellung = vorstellungzaehler;
                }
                Console.WriteLine("Vorstellung mit meistverkauften Tickets im Raum " + (i+1) + " ist die Vorstellung " + vorstellungzaehler + " mit " + meistverkauft + " Tickets");
            }
            Console.WriteLine("Vorstellung mit meistverkauften Tickets insgesamt ist im Raum " + meistverkauftRaum + " die Vorstellung " + meistverkauftVorstellung + " mit " + meistverkauftinsgesamt + " Tickets");
            
            System.Console.WriteLine();
            meistverkauftinsgesamt = 100;
            meistverkauftRaum = 100;
            meistverkauftVorstellung = 100;
            for(int i = 0; i < kinoRaeume.GetLength(0); i++)
            {
                int meistverkauft = 100;
                int vorstellungzaehler = 100;
                for (int j = 0; j < kinoRaeume[i].Length; j++)
                {
                    if (kinoRaeume[i][j] < meistverkauft)
                    {
                        meistverkauft = kinoRaeume[i][j];
                        vorstellungzaehler = j + 1;
                    }
                }
                if(meistverkauft < meistverkauftinsgesamt)
                {
                    meistverkauftinsgesamt = meistverkauft;
                    meistverkauftRaum = i + 1;
                    meistverkauftVorstellung = vorstellungzaehler;
                }
                Console.WriteLine("Vorstellung mit wenigsten Tickets im Raum " + (i+1) + " ist die Vorstellung " + vorstellungzaehler + " mit " + meistverkauft + " Tickets");
            }
            Console.WriteLine("Vorstellung mit wenigsten Tickets insgesamt ist im Raum " + meistverkauftRaum + " die Vorstellung " + meistverkauftVorstellung + " mit " + meistverkauftinsgesamt + " Tickets");
            


        }
    }
}