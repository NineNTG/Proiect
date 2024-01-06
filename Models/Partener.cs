namespace Proiect.Models
{
    public class Partener
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public ICollection<Produs>? Produse { get; set; }
        public ICollection<Transport>? Transporturi { get; set; }
    }
}
