// Program.cs
using System;
using System.ComponentModel;
using Appdevhb25.MarcelSimma.week02;

namespace Appdevhb25.MarcelSimma
{
    internal class Program
    {

        /*
        Die static void Main-Funktion bleibt IMMER in der Program.cs. 
        */

        static void Main(string[] args)
        {
            Console.Clear();
            //Aufgabe01.PrintA.Start();
            //Aufgabe02.Malreihen.Start();
            //Aufgabe05.PrintLine.Start();

            /*
            Aufgabe06.Methoden.PrintVorname("Marcel");
            Aufgabe06.Methoden.PrintRectangle(6, 2);
            Console.WriteLine();
            Aufgabe06.Methoden.PrintRectangle(3, 4);
            Console.WriteLine();
            Aufgabe06.Methoden.PrintRectangle(10, 5);
            
            int summe = Aufgabe06.Methoden.Add(6, 5);
            Console.WriteLine(summe);
            */

            /* 
            Teil von WiederholungMethodenUndSchleifen.cs
            kombinierte Ausgabe mit $ und @ ist auch möglich 
            */

            /*
            Aufgabe09.WiederholungMethodenUndSchleifen.Start();
            Aufgabe09.WiederholungMethodenUndSchleifen.PrintX(7);

            Console.WriteLine($@"
            {Aufgabe09.WiederholungMethodenUndSchleifen.Compoare(11)}
            {Aufgabe09.WiederholungMethodenUndSchleifen.Compoare(11)}
            {Aufgabe09.WiederholungMethodenUndSchleifen.Compoare(11)}
            ");
            */

            //ConsoleInput.ConsoleInput.Start();
            Round.Start(55.55555, 2);

        }
    }
}