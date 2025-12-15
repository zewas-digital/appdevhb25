// namespace Appdevhb25.KatjaHaemmerli.Aufgabe71
// {
//     public class Auto : Fahrzeug
//     {
//         double kilometerstand;
//         private string _model;
//         public string Model
//         {
//             get
//             {
//                 return _model;
//             }

//             private set // privat, weil von Aussen soll das Model nicht verändert werden dürfen.
//             {
//                 _model = value;
//             }

//         }
//         private string _farbe;
//         public string Farbe
//         {
//             get
//             {
//                 return _farbe;
//             }

//             private set // privat, weil von Aussen soll das Model nicht verändert werden dürfen.
//             {
//                 _farbe = value;
//             }

//         }

//         private double _preis;
//         public double Preis
//         {
//             get
//             {
//                 return _preis;
//             }
//             set
//             {
//                 _preis = value;
//             }
//         }

//         // Konstuktor
//         //GitHub Link: https://github.com/zewas-digital/appdevhb25/blob/main/src/MarcelSimma/Week05/VererbungIntro/Auto.cs
//         public Auto(string model, string farbe, double preis) : base.farbe
//     {
//         Model = model;
//         Farbe = farbe;
//         Preis = preis;
//     }
    
//     public override void Dateblatt()
//         {
//             System.Console.WriteLine($"Model: {Model}");
//             System.Console.WriteLine($"Farbe: {Farbe}");
//             System.Console.WriteLine($"Preis: {Preis}");
//         }

//         public override void Fahren(double distance)
//         {
//             kilometerstand += distance;
//             System.Console.WriteLine($"Der Kilometerstand des Autos beträgt: {distance}");
//         }



//     }
// }