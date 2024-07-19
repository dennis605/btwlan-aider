namespace Verwaltungsanwendung
{
    public class Tagesplan
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime Datum { get; set; }
        public List<Veranstaltung> Veranstaltungen { get; set; } = new List<Veranstaltung>();
    }
}
