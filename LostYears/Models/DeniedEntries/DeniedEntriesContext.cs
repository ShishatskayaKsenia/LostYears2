using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    public class DeniedEntriesContext:DbContext
    {
        public DeniedEntriesContext() : base("DefaultConnection") { }
        public DbSet<DeniedEntry> DeniedEntries { get; set; }
    }
}
