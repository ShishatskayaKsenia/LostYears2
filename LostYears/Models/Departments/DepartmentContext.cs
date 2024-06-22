using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    public class DepartmentContext : DbContext
    {
        public DepartmentContext() : base("DefaultConnection") { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instrument> Instruments { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Department>()
        //        .HasOne(d => d.Instrument)
        //        .WithMany(i => i.Departments)
        //        .HasForeignKey(d => d.Instrument_ID);
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("your_connection_string_here");
        //}
    }
}
