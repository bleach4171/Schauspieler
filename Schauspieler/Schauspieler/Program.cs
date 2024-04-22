using System;

namespace Schauspiel
{
    class Schauspieler
    {
        // Variablen Daten
        private string Vorname;
        private string Nachname;
        private string Spitzname;
        private string Geburtsort;
        private string Geburtsdatum;
        private string Nationalitaet;
        private double Groesse;

        // Konstruktor, der Vorname und Nachname übernimmt und die anderen Felder initialisiert
        public Schauspieler(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
            Spitzname = "";
            Geburtsort = "";
            Geburtsdatum = "";
            Nationalitaet = "";
            Groesse = 0.0;
        }

        // Konstruktor, der Vorname, Nachname, Spitzname und Größe übernimmt und die anderen Felder initialisiert
        public Schauspieler(string vorname, string nachname, string spitzname, double groesse)
        {
            Vorname = vorname;
            Nachname = nachname;
            Spitzname = spitzname;
            Geburtsort = "";
            Geburtsdatum = "";
            Nationalitaet = "";
            Groesse = groesse;
        }

        // Konstruktor, der alle Felder übernimmt
        public Schauspieler(string vorname, string nachname, string spitzname, string geburtsort, string geburtsdatum, string nationalitaet, double groesse)
        {
            Vorname = vorname;
            Nachname = nachname;
            Spitzname = spitzname;
            Geburtsort = geburtsort;
            Geburtsdatum = geburtsdatum;
            Nationalitaet = nationalitaet;
            Groesse = groesse;
        }

        // Konstruktor, der nichts übernimmt und alle Felder initialisiert
        public Schauspieler()
        {
            // Konstruktor mit nichts
            Vorname = "";
            Nachname = "";
            Spitzname = "";
            Geburtsort = "";
            Geburtsdatum = "";
            Nationalitaet = "";
            Groesse = 0;
        }

        // Getter und Setter Methoden für den Zugriff auf die Felder

        // Getter für den Vornamen
        public string get_Vorname()
        {
            return Vorname;
        }

        // Setter für den Vornamen
        public void set_Vorname(string vorname)
        {
            Vorname = vorname;
        }

        // Getter für den Nachnamen
        public string get_Nachname()
        {
            return Nachname;
        }

        // Setter für den Nachnamen
        public void set_Nachname(string nachname)
        {
            Nachname = nachname;
        }

        // Getter für den Spitznamen
        public string get_Spitzname()
        {
            return Spitzname;
        }

        // Setter für den Spitznamen
        public void set_Spitzname(string spitzname)
        {
            Spitzname = spitzname;
        }

        // Getter für den Geburtsort
        public string get_Geburtsort()
        {
            return Geburtsort;
        }

        // Setter für den Geburtsort
        public void set_Geburtsort(string geburtsort)
        {
            Geburtsort = geburtsort;
        }

        // Getter für das Geburtsdatum
        public string get_Geburtsdatum()
        {
            return Geburtsdatum;
        }

        // Setter für das Geburtsdatum
        public void set_Geburtsdatum(string geburtsdatum)
        {
            Geburtsdatum = geburtsdatum;
        }

        // Getter für die Nationalität
        public string get_Nationalitaet()
        {
            return Nationalitaet;
        }

        // Setter für die Nationalität
        public void set_Nationalitaet(string nationalitaet)
        {
            Nationalitaet = nationalitaet;
        }

        // Getter für die Größe
        public double get_Groesse()
        {
            return Groesse;
        }

        // Setter für die Größe
        public void set_Groesse(double groesse)
        {
            Groesse = groesse;
        }
    }

    class Start
    {
        static void Main(string[] args)
        {
            // neues Objekt
            Schauspieler schauspieler = new Schauspieler();

            schauspieler.set_Vorname("Christian");
            schauspieler.set_Nachname("Bale");
            schauspieler.set_Geburtsort("Haverfordwest, United Kingdom");
            schauspieler.set_Geburtsdatum("30-01-1974");
            schauspieler.set_Nationalitaet("British");
            schauspieler.set_Groesse(1.83);

            Console.WriteLine(schauspieler.get_Vorname());
            Console.WriteLine(schauspieler.get_Nachname());
            Console.WriteLine(schauspieler.get_Geburtsort());
            Console.WriteLine(schauspieler.get_Geburtsdatum());
            Console.WriteLine(schauspieler.get_Nationalitaet());
            Console.WriteLine(schauspieler.get_Groesse());
            
            

            // Pause machen damit nicht automatisch schließt
            Console.ReadKey();
        }
    }
}