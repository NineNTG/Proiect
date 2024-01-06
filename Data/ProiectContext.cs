using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect.Models;

namespace Proiect.Data
{
    public class ProiectContext : DbContext
    {
        public ProiectContext (DbContextOptions<ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect.Models.Produs> Produse { get; set; } = default!;

        public DbSet<Proiect.Models.Partener>? Partener { get; set; }

        public DbSet<Proiect.Models.Transport>? Transport { get; set; }

        public DbSet<Proiect.Models.Angajat>? Angajat { get; set; }
    }
}
