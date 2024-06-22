using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    public class ChildrenEntryContext : DbContext
    {
        public ChildrenEntryContext() : base("DefaultConnection") { }
        public DbSet<ChildrenEntry> ChildrenEntries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Parent> Parents { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ChildrenEntry>()
        //        .HasOne(ce => ce.Department)
        //        .WithMany(d => d.ChildrenEntries)
        //        .HasForeignKey(ce => ce.Department_ID);

        //    modelBuilder.Entity<ChildrenEntry>()
        //        .HasOne(ce => ce.Parent)
        //        .WithMany(p => p.ChildrenEntries)
        //        .HasForeignKey(ce => ce.Parent_ID);
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("your_connection_string_here");
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ChildrenEntry>()
        //        .HasOne(ce => ce.Department)
        //        .WithMany(d => d.ChildrenEntries)
        //        .HasForeignKey(ce => ce.Department_ID);

        //    modelBuilder.Entity<ChildrenEntry>()
        //        .HasOne(ce => ce.Parent)
        //        .WithMany(p => p.ChildrenEntries)
        //        .HasForeignKey(ce => ce.Parent_ID);
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("your_connection_string_here");
        //}
    }
}
