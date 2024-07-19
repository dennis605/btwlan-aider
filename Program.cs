using System;
using System.Collections.Generic;

namespace Verwaltungsanwendung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zur Verwaltungsanwendung!");

            // Beispielhafte Nutzung der Verwaltungsfunktionen
            PatientenVerwaltung patientenVerwaltung = new PatientenVerwaltung();
            BetreuerVerwaltung betreuerVerwaltung = new BetreuerVerwaltung();
            VeranstaltungsVerwaltung veranstaltungsVerwaltung = new VeranstaltungsVerwaltung();
            TagesplanVerwaltung tagesplanVerwaltung = new TagesplanVerwaltung();

            // Hier können Sie die Verwaltungsfunktionen aufrufen und testen
        }
    }
}
