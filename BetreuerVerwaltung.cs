using System;
using System.Collections.Generic;

namespace Verwaltungsanwendung
{
    public class BetreuerVerwaltung
    {
        private List<Betreuer> BetreuerListe = new List<Betreuer>();

        public void Hinzufuegen(Betreuer betreuer)
        {
            BetreuerListe.Add(betreuer);
            Console.WriteLine("Betreuer hinzugefügt.");
        }

        public void Bearbeiten(int id, Betreuer neuerBetreuer)
        {
            var betreuer = BetreuerListe.Find(b => b.Id == id);
            if (betreuer != null)
            {
                betreuer.Name = neuerBetreuer.Name;
                betreuer.Fachgebiet = neuerBetreuer.Fachgebiet;
                Console.WriteLine("Betreuer bearbeitet.");
            }
        }

        public void Loeschen(int id)
        {
            BetreuerListe.RemoveAll(b => b.Id == id);
            Console.WriteLine("Betreuer gelöscht.");
        }

        public void Anzeigen()
        {
            foreach (var betreuer in BetreuerListe)
            {
                Console.WriteLine($"ID: {betreuer.Id}, Name: {betreuer.Name}, Fachgebiet: {betreuer.Fachgebiet}");
            }
        }
    }
}
