using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe28
{
    public class Teilnehmer
    {
        public static void Aufzaehlung()
        {
            string[] teilnehmer = new string[10];
            teilnehmer[0] = "Peter";
            teilnehmer[1] = "Peterine";
            teilnehmer[2] = "Petra";
            teilnehmer[3] = "Petrus";
            teilnehmer[4] = "Peters";
            teilnehmer[5] = "Paul";
            teilnehmer[6] = "Pferd";
            teilnehmer[7] = "Pfeffer";
            teilnehmer[8] = "Paulus";
            teilnehmer[9] = "Peterian";

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                System.Console.WriteLine($"{i+1}. {teilnehmer[i]}");
                
            }
        }
        


      

        
    }
}