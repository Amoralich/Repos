using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MootorBaike.Models;

namespace MootorBaike.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly MootorBaike.Models.MootorBaikeContext _context;

        public DeleteModel(MootorBaike.Models.MootorBaikeContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Models = await _context.Models.FindAsync(id);

            if (Models != null)
            {
                _context.Models.Remove(Models);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
