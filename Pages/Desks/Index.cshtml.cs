using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebWeek8.Models;

namespace MegaDeskWebWeek8.Pages.Desks
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskWebWeek8.Models.MegaDeskWebWeek8Context _context;

        public IndexModel(MegaDeskWebWeek8.Models.MegaDeskWebWeek8Context context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }


        public async Task OnGetAsync()
        {
            IQueryable<string> quoteQuery = from m in _context.DeskQuote
                                           orderby m.CustomerName
                                           select m.CustomerName;
            var quotes = from m in _context.DeskQuote
                             select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                quotes = quotes.Where(s => s.CustomerName.Contains(SearchString));
            }
            DeskQuote = await quotes.ToListAsync();
            
        }
    }
}
