using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    public class ClassContext : DbContext
    {
        public ClassContext() : base("DefaultConnection") { }
        public DbSet<Class> Classes { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Class>()
        //        .HasOne(c => c.Department)
        //        .WithMany(d => d.Classes)
        //        .HasForeignKey(c => c.Department_ID);

        //    modelBuilder.Entity<Class>()
        //        .HasOne(c => c.Teacher)
        //        .WithMany(t => t.Classes)
        //        .HasForeignKey(c => c.Teacher_ID);
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("your_connection_string_here");
        //}
    }
}
