namespace Appdevhb25.KerimAlkis.Aufgabe23
{
    public class Teilnehmer3
    {
        public static void Start()
        {
            Aufzaehlung3();
        }
        public static void Aufzaehlung3()
        {
            System.Console.Write("How many Participants do you have? ");
            int numbert;
            while (!int.TryParse(Console.ReadLine(), out numbert))
            {
                Console.WriteLine("Enter a valid number!");

            }



            string[] teilnehmer = new string[numbert];



            for (int i = 0; i < numbert; i++)
            {
                System.Console.Write($"Person{i + 1}: ");
                string? eingabe = Console.ReadLine();
                teilnehmer[i] = eingabe ?? "";

            }

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                System.Console.Write($"{teilnehmer[i]},");
            }
        }
    }    
}