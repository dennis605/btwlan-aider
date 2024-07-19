using System;
using System.Collections.Generic;

namespace Verwaltungsanwendung
{
    public class PatientenVerwaltung
    {
        private List<Patient> PatientenListe = new List<Patient>();

        public void Hinzufuegen(Patient patient)
        {
            PatientenListe.Add(patient);
            Console.WriteLine("Patient hinzugefügt.");
        }

        public void Bearbeiten(int id, Patient neuerPatient)
        {
            var patient = PatientenListe.Find(p => p.Id == id);
            if (patient != null)
            {
                patient.Name = neuerPatient.Name;
                patient.Alter = neuerPatient.Alter;
                patient.Diagnose = neuerPatient.Diagnose;
                Console.WriteLine("Patient bearbeitet.");
            }
        }

        public void Loeschen(int id)
        {
            PatientenListe.RemoveAll(p => p.Id == id);
            Console.WriteLine("Patient gelöscht.");
        }

        public void Anzeigen()
        {
            foreach (var patient in PatientenListe)
            {
                Console.WriteLine($"ID: {patient.Id}, Name: {patient.Name}, Alter: {patient.Alter}, Diagnose: {patient.Diagnose}");
            }
        }
    }
}
