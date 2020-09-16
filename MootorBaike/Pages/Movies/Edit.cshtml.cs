using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MootorBaike.Models;

namespace MootorBaike.Pages.Movies
{
    public class EditModel : PageModel
    {
        private readonly MootorBaike.Models.MootorBaikeContext _context;

        public EditModel(MootorBaike.Models.MootorBaikeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models Models { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Models = await _context.Models.FirstOrDefaultAsync(m => m.ID == id);

            if (Models == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Models).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModelsExists(Models.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ModelsExists(int id)
        {
            return _context.Models.Any(e => e.ID == id);
        }
    }
}
