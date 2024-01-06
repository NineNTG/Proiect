using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Transporturi
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public CreateModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AngajatID"] = new SelectList(_context.Set<Angajat>(), "ID", "Nume");
        ViewData["PartenerID"] = new SelectList(_context.Set<Partener>(), "ID", "Nume");
            return Page();
        }

        [BindProperty]
        public Transport Transport { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Transport == null || Transport == null)
            {
                return Page();
            }

            _context.Transport.Add(Transport);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
