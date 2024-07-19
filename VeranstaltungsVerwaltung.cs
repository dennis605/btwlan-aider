using System;
using System.Collections.Generic;

namespace Verwaltungsanwendung
{
    public class VeranstaltungsVerwaltung
    {
        private List<Veranstaltung> VeranstaltungsListe = new List<Veranstaltung>();

        public void Hinzufuegen(Veranstaltung veranstaltung)
        {
            VeranstaltungsListe.Add(veranstaltung);
            Console.WriteLine("Veranstaltung hinzugefügt.");
        }

        public void Bearbeiten(int id, Veranstaltung neueVeranstaltung)
        {
            var veranstaltung = VeranstaltungsListe.Find(v => v.Id == id);
            if (veranstaltung != null)
            {
                veranstaltung.Titel = neueVeranstaltung.Titel;
                veranstaltung.Datum = neueVeranstaltung.Datum;
                veranstaltung.Beschreibung = neueVeranstaltung.Beschreibung;
                Console.WriteLine("Veranstaltung bearbeitet.");
            }
        }

        public void Loeschen(int id)
        {
            VeranstaltungsListe.RemoveAll(v => v.Id == id);
            Console.WriteLine("Veranstaltung gelöscht.");
        }

        public void Anzeigen()
        {
            foreach (var veranstaltung in VeranstaltungsListe)
            {
                Console.WriteLine($"ID: {veranstaltung.Id}, Titel: {veranstaltung.Titel}, Datum: {veranstaltung.Datum}, Beschreibung: {veranstaltung.Beschreibung}");
            }
        }
    }
}
