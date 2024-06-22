using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    public class TeacherContext : DbContext
    {
        public TeacherContext() : base("DefaultConnection") { }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Department> Departments { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Teacher>()
        //        .HasOne(t => t.Department)
        //        .WithMany(d => d.Teachers)
        //        .HasForeignKey(t => t.Department_ID);
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("your_connection_string_here");
        //}
    }
}
