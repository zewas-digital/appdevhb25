using System.Net.Http.Headers;
using Appdevhb25.NoahHois.Aufgabe71;

namespace Appdevhb25.NoahHois.Aufgabe71
{
    public class ProgramAbstrakteFahrzeuge
    {

        public static void Start()
        {
            Fahrzeuge[] fahrzeuge = new Fahrzeuge[5];
            Auto firstAuto = new Auto(4, "Blau", "FK234", 20_000);
            Auto secondAuto = new Auto(4, "Grün", "D235", 14_000);
            Auto thirdAuto = new Auto(2, "Weiß", "B291", 5_000);
            Motorrad firstMotorrad = new Motorrad(200, 20_000, "Gelb", "FK290", 2_000);
            Motorrad secondMotorrad = new Motorrad(100, 10_500, "Blau", "D9210", 1_000);
            fahrzeuge[0] = firstAuto;
            fahrzeuge[1] = secondAuto;
            fahrzeuge[2] = thirdAuto;
            fahrzeuge[3] = firstMotorrad;
            fahrzeuge[4] = secondMotorrad;

            foreach (Fahrzeuge i in fahrzeuge)
            {
                i.PrintDataSheet();
                i.Drive(0);
                System.Console.WriteLine(i);
            }

        }
    }
}