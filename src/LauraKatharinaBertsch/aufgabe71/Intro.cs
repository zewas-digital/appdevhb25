namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe71
{
    public class Intro
    {
        public static void Start()
        {
            AbstrakteFahrzeuge[] autos = new AbstrakteFahrzeuge[3];
            autos[0] = new Auto(5);
            autos[1] = new Auto(3);
            autos[2] = new Auto(4);

            foreach (AbstrakteFahrzeuge auto in autos)
            {
                Console.WriteLine(autos[0]);
                auto.DruckeDatenblatt();
                auto.Fahren(1);
                Console.WriteLine();
            }

            AbstrakteFahrzeuge[] motorraeder = new AbstrakteFahrzeuge[3];
            motorraeder[0] = new Motorrad(50, 10000);
            motorraeder[1] = new Motorrad(70, 20200);
            motorraeder[2] = new Motorrad(55, 10999);

            foreach (AbstrakteFahrzeuge motorrad in motorraeder)
            {
                Console.WriteLine(motorraeder[0]);
                motorrad.ToString();
                motorrad.DruckeDatenblatt();
                motorrad.Fahren(2);
                Console.WriteLine();
            }

            Auto.PrintAnzahlDerProduziertenAutos();
            Console.WriteLine("Der durchschnittliche Umsatz der Motorräder: " + Motorrad.BerechneDurchschnittsumsatz());
            AbstrakteFahrzeuge.PrintAnzahlDerProduziertenFahrzeuge();

        }
    }
}