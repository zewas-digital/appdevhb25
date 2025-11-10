using System;

namespace Appdevhb25.OliverBedogg.aufgabe73
{

    public class Fotoapparat : Hardware
    {
        private Objektiv _objektiv { get; set; }
        public Objektiv Objektiv
        {
            get { return _objektiv; }
        }
        /* 
            Setter verwenden,
            wenn das Wechseln des Objektivs nur eine einfache Zuweisung ist und keine komplexen Abläufe nötig sind.
            Alle Validierungen und Nebenwirkungen (wie Events, Logging, Zustand prüfen) können durchaus im Setter umgesetzt werden:

            public Objektiv Objektiv
            {
                get { return _objektiv; }
                set
                {
                    if (!IstKompatibel(value))
                        throw new InvalidOperationException("Objektiv nicht kompatibel!");
                    
                    // Ggf. Event auslösen, Zustand ändern etc.
                    _objektiv = value;
                }
            }
        */
        private Speicherkarte _speicherkarte { get; set; }
        public Speicherkarte Speicherkarte
        {
            get { return _speicherkarte; }
        }
        public int AnzahlFotos { get; private set; }

        public Fotoapparat(string seriennummer, string modell) : base(seriennummer, modell)
        {
            AnzahlFotos = 0;
        }

        public void WechsleObjektiv(Objektiv neuesObjektiv)
        {
            /*
                Eine Methode macht vor allem dann Sinn, 
                wenn der Vorgang mehrere Schritte umfasst, komplexe Logik benötigt oder andere Objekte mit einbezogen werden. 

                - Wenn das Wechseln einen „Prozess“ darstellt, etwa Zwischenschritte, Animationen, Reihenfolgen oder komplexe Logik.
                - Wenn mehrere Parameter erforderlich sind oder mehrere abhängige Zustände geändert werden.
                - Wenn das Wechseln nicht jederzeit oder nur unter Bedingungen erlaubt ist (z. B. Objektiv vorher entfernen).

                if (neuesObjektiv == null)
                    throw new ArgumentNullException(nameof(neuesObjektiv));

                if (_objektiv != null)
                    ObjektivEntfernen();  // z. B. Zustand setzen, Event triggern

                if (!IstKompatibel(neuesObjektiv))
                    throw new InvalidOperationException("Objektiv nicht kompatibel!");

                _objektiv = neuesObjektiv;
                // Weitere Aktionen wie Logging, Statusaktualisierung etc.
            */
            _objektiv = neuesObjektiv;
        }

        public void WechsleSpeicherkarte(Speicherkarte neueSpeicherkarte)
        {
            _speicherkarte = neueSpeicherkarte;
        }

        public void Foto()
        {
            if (_objektiv == null)
            {
                Console.WriteLine("Kein Objektiv montiert! Foto nicht möglich.");
                return;
            }

            if (_speicherkarte == null)
            {
                Console.WriteLine("Keine Speicherkarte eingelegt! Foto nicht möglich.");
                return;
            }

            _speicherkarte.SpeichereDaten(5); // Beispiel: 5MB pro Foto
            AnzahlFotos++;
        }

        public int AnzahlVerfuegbarerFotos()
        {
            if (_speicherkarte == null)
            {
                Console.WriteLine("Keine Speicherkarte eingelegt!");
                return 0;
            }

            int freierSpeicher = _speicherkarte.Speichergroesse - _speicherkarte.BelegterSpeicher;
            return freierSpeicher / 5; // Beispiel: 5MB pro Foto
        }
    }
}