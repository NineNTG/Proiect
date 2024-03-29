﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public DetailsModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

      public Transport Transport { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Transport == null)
            {
                return NotFound();
            }

            var transport = await _context.Transport.FirstOrDefaultAsync(m => m.ID == id);
            if (transport == null)
            {
                return NotFound();
            }
            else 
            {
                Transport = transport;
            }
            return Page();
        }
    }
}
