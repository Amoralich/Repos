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
    public class IndexModel : PageModel
    {
        private readonly MootorBaike.Models.MootorBaikeContext _context;

        public IndexModel(MootorBaike.Models.MootorBaikeContext context)
        {
            _context = context;
        }

        public IList<Models> Models { get;set; }

        public async Task OnGetAsync()
        {
            Models = await _context.Models.ToListAsync();
        }
    }
}
