using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Transporturi
{
    public class IndexModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public IndexModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        public IList<Transport> Transport { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Transport != null)
            {
                Transport = await _context.Transport
                .Include(t => t.Angajat)
                .Include(t => t.Partener).ToListAsync();
            }
        }
    }
}
