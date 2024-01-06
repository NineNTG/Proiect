using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Proiect.Models
{
    public class Produs
    {
        public int ID { get; set; }
        [RegularExpression(@"^[A-Z]+[a-z\s]*$", ErrorMessage = "Numele trebuie sa inceapa cu majuscula, intre 1-50 litere")]
        [StringLength(50, MinimumLength = 1)]
        public string Nume { get; set; }
        [StringLength(3, MinimumLength = 1)]
        public string Cantitate { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Pret { get; set; }
        public string Data_Exp { get; set; }
        public int? PartenerID { get; set; }
        public Partener? Partener { get; set; }
    }
}
