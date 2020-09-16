using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MootorBaike.Models;

namespace MootorBaike.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly MootorBaike.Models.MootorBaikeContext _context;

        public CreateModel(MootorBaike.Models.MootorBaikeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models Models { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Models.Add(Models);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}