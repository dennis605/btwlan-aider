using System;
using System.Collections.Generic;

namespace Verwaltungsanwendung
{
    public class TagesplanVerwaltung
    {
        private List<Tagesplan> TagesplanListe = new List<Tagesplan>();

        public void Erstellen(Tagesplan tagesplan)
        {
            TagesplanListe.Add(tagesplan);
            Console.WriteLine("Tagesplan erstellt.");
        }

        public void HinzufuegenVeranstaltung(int tagesplanId, Veranstaltung veranstaltung)
        {
            var tagesplan = TagesplanListe.Find(t => t.Id == tagesplanId);
            if (tagesplan != null)
            {
                tagesplan.Veranstaltungen.Add(veranstaltung);
                Console.WriteLine("Veranstaltung zum Tagesplan hinzugefügt.");
            }
        }

        public void Bearbeiten(int id, Tagesplan neuerTagesplan)
        {
            var tagesplan = TagesplanListe.Find(t => t.Id == id);
            if (tagesplan != null)
            {
                tagesplan.PatientId = neuerTagesplan.PatientId;
                tagesplan.Datum = neuerTagesplan.Datum;
                tagesplan.Veranstaltungen = neuerTagesplan.Veranstaltungen;
                Console.WriteLine("Tagesplan bearbeitet.");
            }
        }

        public void Loeschen(int id)
        {
            TagesplanListe.RemoveAll(t => t.Id == id);
            Console.WriteLine("Tagesplan gelöscht.");
        }

        public void Anzeigen(int patientId, DateTime datum)
        {
            foreach (var tagesplan in TagesplanListe)
            {
                if (tagesplan.PatientId == patientId && tagesplan.Datum.Date == datum.Date)
                {
                    Console.WriteLine($"Tagesplan ID: {tagesplan.Id}, Datum: {tagesplan.Datum}");
                    foreach (var veranstaltung in tagesplan.Veranstaltungen)
                    {
                        Console.WriteLine($"  Veranstaltung: {veranstaltung.Titel}, Datum: {veranstaltung.Datum}, Beschreibung: {veranstaltung.Beschreibung}");
                    }
                }
            }
        }
    }
}
