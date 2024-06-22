using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LostYears.Models
{
    public class InstrumentContext : DbContext
    {
        public InstrumentContext() : base("DefaultConnection") { }
        public DbSet<Instrument> Instruments { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("your_connection_string_here");
        //}
    }
}
