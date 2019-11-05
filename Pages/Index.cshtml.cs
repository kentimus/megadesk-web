﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebWeek8.Models;

namespace MegaDeskWebWeek8.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskWebWeek8.Models.MegaDeskWebWeek8Context _context;

        public IndexModel(MegaDeskWebWeek8.Models.MegaDeskWebWeek8Context context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync()
        {
            DeskQuote = await _context.DeskQuote.ToListAsync();
        }
    }
}
