using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Parteneri
{
    [Authorize(Roles = "Admin")]

    public class DeleteModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public DeleteModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Partener == null)
            {
                return NotFound();
            }
            var partener = await _context.Partener.FindAsync(id);

            if (partener != null)
            {
                Partener = partener;
                _context.Partener.Remove(Partener);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
