using System.Runtime.ConstrainedExecution;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe86
{
    public class Callcenter
    {
        Queue<Anruf> verpassteAnrufe = new Queue<Anruf>();

        public void Anrufen(Anruf anruf)
        {
            verpassteAnrufe.Enqueue(anruf);
        }

        public void AnrufeAbarbeiten()
        {
            int counter = 0;
            foreach(Anruf anruf in verpassteAnrufe)
            {
                counter++;
                System.Console.WriteLine($"{counter}. Name: {anruf.Name}, Tel: {anruf.Telefonnummer}, Datum: {anruf.Datum}");
            }
        }


    }
}