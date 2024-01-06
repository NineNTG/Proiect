using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Produse
{
    public class CreateModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public CreateModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PartenerID"] = new SelectList(_context.Set<Partener>(), "ID","Nume");
            return Page();
        }

        [BindProperty]
        public Produs Produs { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Produse == null || Produs == null)
            {
                return Page();
            }

            _context.Produse.Add(Produs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
