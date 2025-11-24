using System;
using System.Globalization;
using System.Security.Cryptography;
using System.IO;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe80
{
    class Abwesenheit
    {
        public DateTime Start { get; set; }
        public DateTime Ende { get; set; }
        public string? Fehlgrund { get; set; }
        public bool Entschuldigt { get; set; }

        public double DauerInStunden => (Ende - Start).TotalHours;

        public Abwesenheit(DateTime start, DateTime ende, string fehlgrund, bool entschuldigt)
        {
            Start = start;
            Ende = ende;
            Fehlgrund = fehlgrund;
            Entschuldigt = entschuldigt;
        }

        public override string ToString()
        {
            return $"{Start:g} - {Ende:g}, Grund: {Fehlgrund}, Entschuldigt {Entschuldigt}";
        }
    }
    class Teilnehmer
    {
        public string Vorname { get; private set; }
        public string Nachname { get; private set; }
        public double Stundensatz { get; private set; }

        public List<Abwesenheit> Abwesenheiten { get; } = new List<Abwesenheit>();

        public Teilnehmer(string vorname, string nachname, double stundensatz)
        {
            Vorname = vorname;
            Nachname = nachname;
            Stundensatz = stundensatz;
        }


        public double EntstandeneKosten()
        {
            double summe = 0;

            foreach (var a in Abwesenheiten)
            {
                // nur unentschuldigte Abwesenheiten werden dazu gezählt
                // if(!a.Entschuldigt)
                // {
                //     summe+= a.DauerInStunden * Stundensatz;
                // }

                summe += a.DauerInStunden * Stundensatz;
            }

            return summe;
        }

        public override string ToString()
        {
            return $"{Vorname} {Nachname}\t(Stundensatz: {Stundensatz} €/h)";
        }
    }

    static class ListenAbrufen
    {
        public static void Speichern(List<Teilnehmer> teilnehmerListe, string pfad)
        {
            using (var sw = new StreamWriter(pfad))
            {
                // Teilnehmerloop
                foreach (var t in teilnehmerListe)
                {
                    sw.WriteLine($"T;{t.Vorname};{t.Nachname};{t.Stundensatz.ToString(CultureInfo.InvariantCulture)}");

                    // Abwesenheitsloop
                    foreach (var a in t.Abwesenheiten)
                    {
                        sw.WriteLine($"A;{a.Start:dd.MM.yyyy HH:mm};{a.Ende:dd.MM.yyyy HH:mm};{a.Fehlgrund};{a.Entschuldigt}");
                    }
                }
            }
        }

        public static List<Teilnehmer> Laden(string pfad)
        {
            // erstellen von neuer Liste
            var liste = new List<Teilnehmer>();

            // falss file leer
            if (!File.Exists(pfad))
                return liste;

            // Variable für Teilnehmer
            Teilnehmer? aktuellerTeilnehmer = null;


            foreach (var zeile in File.ReadAllLines(pfad))
            {
                // überspringen von Leerzeichen
                if (string.IsNullOrWhiteSpace(zeile))
                    continue;

                // aufteilung der Liste
                var parts = zeile.Split(';');

                if (parts[0] == "T")
                {
                    // Daten zuordnen
                    string vorname = parts[1];
                    string nachname = parts[2];
                    double stundensatz = double.Parse(parts[3], CultureInfo.InvariantCulture);

                    // hinzufügen von neuem Teilnehmer
                    aktuellerTeilnehmer = new Teilnehmer(vorname, nachname, stundensatz);
                    liste.Add(aktuellerTeilnehmer);
                }
                else if ("A" == parts[0] && aktuellerTeilnehmer != null)
                {
                    // Datumsformat für einfachere Eingabe
                    var format = "dd.MM.yyyy HH:mm";

                    // Daten zuordnen
                    DateTime start = DateTime.ParseExact(parts[1], format, CultureInfo.InvariantCulture);
                    DateTime ende = DateTime.ParseExact(parts[2], format, CultureInfo.InstalledUICulture);
                    string fehlgrund = parts[3];
                    bool entschuldigt = bool.Parse(parts[4]);

                    // hinzufügen zu Abwesenheiten Liste
                    var abw = new Abwesenheit(start, ende, fehlgrund, entschuldigt);
                    aktuellerTeilnehmer.Abwesenheiten.Add(abw);
                }
            }
            return liste;
        }
    }
}
