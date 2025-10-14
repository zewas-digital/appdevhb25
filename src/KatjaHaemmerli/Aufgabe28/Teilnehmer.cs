using System.Collections;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe20;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe28
{
    // Erstelle eine Methode, welche eine Kommazahl (Parameter 0) auf eine bestimmte Anzahl an Nachkommastellen genau (Parameter 1) kaufmännisch rundet. 
    public class TeilehmerListe
    {
        public static void Teilnehmer()
        {
            string[] teilnehmer = new string[11];

            teilnehmer[0] = "Jona";
            teilnehmer[1] = "Kerim";
            teilnehmer[2] = "Julian";
            teilnehmer[3] = "Sheila";
            teilnehmer[4] = "Laura";
            teilnehmer[5] = "Noah";
            teilnehmer[6] = "Seline";
            teilnehmer[7] = "Sabrina";
            teilnehmer[8] = "Lia";
            teilnehmer[9] = "Sasha";
            teilnehmer[10] = "Katja";

            // for (int i = 0; i < teilnehmer.Length; i++)
            // {
            //     Console.WriteLine($"{i + 1}. {teilnehmer[i]}");
            // }

            int zaehler = 0;
            foreach (string name in teilnehmer)
            {
                zaehler++;
                Console.WriteLine($"{zaehler}. {name}");
            }

        }
    }
}