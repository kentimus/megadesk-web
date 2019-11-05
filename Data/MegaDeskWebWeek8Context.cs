using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MegaDeskWebWeek8.Models
{
    public class MegaDeskWebWeek8Context : DbContext
    {
        public MegaDeskWebWeek8Context (DbContextOptions<MegaDeskWebWeek8Context> options)
            : base(options)
        {
        }

        public DbSet<MegaDeskWebWeek8.Models.DeskQuote> DeskQuote { get; set; }
    }
}
