using System;
using System.Windows.Forms;

namespace Verwaltungsanwendung
{
    public partial class MainForm : Form
    {
        private PatientenVerwaltung patientenVerwaltung = new PatientenVerwaltung();
        private BetreuerVerwaltung betreuerVerwaltung = new BetreuerVerwaltung();
        private VeranstaltungsVerwaltung veranstaltungsVerwaltung = new VeranstaltungsVerwaltung();
        private TagesplanVerwaltung tagesplanVerwaltung = new TagesplanVerwaltung();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPatientenVerwalten_Click(object sender, EventArgs e)
        {
            // Öffnen Sie das Patientenverwaltungsformular
        }

        private void btnBetreuerVerwalten_Click(object sender, EventArgs e)
        {
            // Öffnen Sie das Betreuerverwaltungsformular
        }

        private void btnVeranstaltungenVerwalten_Click(object sender, EventArgs e)
        {
            // Öffnen Sie das Veranstaltungsverwaltungsformular
        }

        private void btnTagesplaeneVerwalten_Click(object sender, EventArgs e)
        {
            // Öffnen Sie das Tagesplanverwaltungsformular
        }
    }
}
