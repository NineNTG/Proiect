namespace Proiect.Models
{
    public class Angajat
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Telefon { get; set; }
        public string Data_Angajare { get; set; }
        public ICollection<Transport>? Transporturi { get; set; }
    }
}
