namespace Proiect.Models
{
    public class Transport
    {
        public int ID { get; set; }
        public string Data { get; set; }
        public string Status { get; set; }
        public int? PartenerID { get; set; }
        public Partener? Partener { get; set; }
        public int? AngajatID { get; set; }
        public Angajat? Angajat { get; set; }
    }
}
