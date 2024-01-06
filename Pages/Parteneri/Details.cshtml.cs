using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Parteneri
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public DetailsModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

      public Partener Partener { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Partener == null)
            {
                return NotFound();
            }

            var partener = await _context.Partener.FirstOrDefaultAsync(m => m.ID == id);
            if (partener == null)
            {
                return NotFound();
            }
            else 
            {
                Partener = partener;
            }
            return Page();
        }
    }
}
