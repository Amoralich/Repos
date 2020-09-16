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
    public class DetailsModel : PageModel
    {
        private readonly MootorBaike.Models.MootorBaikeContext _context;

        public DetailsModel(MootorBaike.Models.MootorBaikeContext context)
        {
            _context = context;
        }

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
    }
}
